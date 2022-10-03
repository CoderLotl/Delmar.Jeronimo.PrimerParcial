using Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    public partial class FrmMain : Form
    {
        //******************************************************

        Agent agent;
        //----
        List<Destination> destinations;
        //----
        List<Airplane> airplanes;
        List<Airplane> inTheAir;
        //----
        List<Flight> flights;
        List<Flight> history;
        //----
        List<Flight> source;
        //----
        List<Passenger> clients;
        List<Passenger> allPassengers = new List<Passenger>();
        float[] earnedTotal;
        float[] earnedNational;
        float[] earnedInternational;
        FrmLogin login;
        
        //******************************************************

        public FrmMain(FrmLogin frmLogin,List<Flight> flightParam, List<Flight> history, Agent agentParam, List<Airplane> planesParam,
                        List<Airplane> inTheAirParam,int intro,List<Passenger> clientsParam,float[] earnedTotal, float[] earnedNational, float[] earnedInternational,List<Destination> destinations)
        {
            InitializeComponent();            

            agent = agentParam;
            airplanes = planesParam;
            flights = flightParam;
            this.history = history;
            inTheAir = inTheAirParam;
            clients = clientsParam;
            this.earnedTotal = earnedTotal;
            this.earnedNational = earnedNational;
            this.earnedInternational = earnedInternational;
            this.destinations = destinations;

            lbl_UserName.Text = agent.Name;
            login = frmLogin;            

            //-----------

            if (intro == 1)
            {
                FrmLogging logging = new FrmLogging();
                logging.Show();
            }
            source = flights;
            FlightsAmountUpdate(); // INITIALIZES THE DATA OF FLIGHTS SHOWN IN THE FLIGHTS LABEL
            PlanesAmountUpdate();  // INITIALIZES THE DATA OF PLANES SHOWN IN THE PLANES LABEL
            CmbBoxFlightsPopulate(); // POPULATES THE COMBOBOX OF FLIGHTS WITH THE FLIGHTS.
        }

        // ------------------------------------------------------ [ LOAD ]

        private void FrmMain_Load(object sender, EventArgs e)
        {   
            // ALL THIS SECTION UPDATES THE DATA SHOWN IN THE MAIN.

            DataGridAllFlightsDisplay(); // DISPLAYING ALL THE FLIGHTS IN THE MAIN DATAGRID
            grpBox_Passengers.Visible = false; // SETTING THE PASSENGER'S GROUPBOX WITH THE COMBOBOX TO INVISIBLE

            DateTime current = DateTime.Now; // CURRENT DATETIME SET TO NOW
            tStrpStatus_Date.Text = "Date: "+current.ToShortDateString(); // SHOWING IN THE TASKBAR THE CURRENT DATE WITHOUT THE HOUR, AS THE PREMISE REQUESTS

            tStrpStatus_User.Text = "Logged user: "+agent.Name; // SHOWING THE CURRENT USER'S NAME IN THE BAR

            ClientsAmountUpdate(); // DISPLAYING THE CURRENT AMOUNT OF CLIENTS IN THE CLIENT'S LABEL

            Lbl_Earned.Text = earnedTotal[0].ToString("c2"); // DISPLAYS THE EARNED MONEY WITH THE PAST FLIGHTS. SAMEFOR THE NEXT 2 LINES.
            Lbl_National.Text = earnedNational[0].ToString("c2");
            Lbl_International.Text = earnedInternational[0].ToString("c2");
            
            RdoBttn_SourceCurrent.Checked = true; // SETTING THE DATASOURCE TO CURRENT.
        }

        //------------------------------------------------------------
        //-------------------------------------------[ BUTTONS ]
        //------------------------------------------------------------

        private void Btn_LogOut_Click(object sender, EventArgs e) //LOGOUT BUTTON
        {
            this.Close();
        }

        //***********************************************

        private void Btn_ExitProgram_Click(object sender, EventArgs e) //EXIT BUTTON
        {
            Environment.Exit(0);
        }

        //***********************************************

        private void CmbBox_Flights_SelectedIndexChanged(object sender, EventArgs e) // FLIGHTS COMBOBOX
        {            
            CmbBox_FlightsMechanics();
        }

        //***********************************************


        private void CmbBox_Passengers_SelectedIndexChanged(object sender, EventArgs e) // PASSENGERS COMBOBOX
        {            
            CmbBox_PassengersMechanics();
        }

        //***********************************************

        private void Btn_AddFlight_Click(object sender, EventArgs e)
        {
            FrmAddFlight addNewFlight = new(airplanes);
            if(addNewFlight.ShowDialog() == DialogResult.OK)
            {
                flights.Add(addNewFlight.Flight);
                inTheAir.Add(addNewFlight.Plane);
                airplanes.Remove(addNewFlight.Plane);                
                DataGridAllFlightsDisplay();
                CmbBoxFlightsPopulate();

                //-----

                FlightsAmountUpdate();
                PlanesAmountUpdate();
            }
        }

        //***********************************************

        private void DgvMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) // FINISH FLIGHT BUTTON
        {
            if (DgvMainGrid.Columns[e.ColumnIndex].Name == "dgvRmvFlight")
            {
                int index = DgvMainGrid.CurrentRow.Index;
                Flight aFlight = flights[index];                

                foreach(Airplane airplane in inTheAir)
                {
                    if(airplane.Tag == aFlight.Airplane.Tag)
                    {
                        inTheAir.Remove(airplane);
                        airplanes.Add(airplane);
                        break;
                    }
                }

                foreach(var touristPassenger in aFlight.Tourist)
                {
                    touristPassenger.Value.OnFly = false;
                }
                foreach(var premiumPassenger in aFlight.Premium)
                {
                    premiumPassenger.Value.OnFly = false;
                }

                history.Add(flights[DgvMainGrid.CurrentRow.Index]);

                earnedTotal[0] += aFlight.FlightEarned;
                
                if(aFlight.IsNational == true)
                {
                    earnedNational[0] += aFlight.FlightEarned;
                }
                else
                {
                    earnedInternational[0] += aFlight.FlightEarned;
                }

                Lbl_Earned.Text = earnedTotal[0].ToString("c2");
                Lbl_National.Text = earnedNational[0].ToString("c2");
                Lbl_International.Text = earnedInternational[0].ToString("c2");

                flights.RemoveAt(DgvMainGrid.CurrentRow.Index);

                for (int i = 0; i < destinations.Count; i++)
                {
                    if (destinations[i].DestinationP == aFlight.Destination)
                    {
                        destinations[i].Flights++;
                        destinations[i].Earned += aFlight.FlightEarned;
                        destinations[i].Passengers += aFlight.AmountPassengers;
                        break;
                    }
                }

                CmbBoxFlightsPopulate();
                DataGridAllFlightsDisplay();

                FlightsAmountUpdate();
                PlanesAmountUpdate();
            }
        }

        //***********************************************

        private void Btn_SellTicket_Click(object sender, EventArgs e) // SELL TICKET BUTTON
        {
            FrmSellTicketMain sellTicket = new FrmSellTicketMain(flights,clients,this);
            sellTicket.ShowDialog();
        }

        //***********************************************

        private void Btn_AddClient_Click(object sender, EventArgs e) // ADD CLIENT BUTTON
        {

            FrmAddPassengerHUB frmAddPassengerHUB = new FrmAddPassengerHUB(clients);
            if(frmAddPassengerHUB.ShowDialog() == DialogResult.OK)
            {
                List<Passenger> someClients = new List<Passenger>();
                someClients = frmAddPassengerHUB.Clients;

                foreach(Passenger passenger in someClients)
                {                 
                    clients.Add(passenger);
                }
                ClientsAmountUpdate();
            }            
        }

        //***********************************************

        private void button3_Click(object sender, EventArgs e)
        {
            FrmViewClients viewClients = new FrmViewClients(clients);
            viewClients.Show();
        }

        //***********************************************

        private void Btn_MainCheckDestinations_Click(object sender, EventArgs e)
        {
            FrmCheckDestinations FrmDestinations = new FrmCheckDestinations(destinations);
            FrmDestinations.Show();
        }

        //***********************************************

        private void Btn_AddPlane_Click(object sender, EventArgs e)
        {
            FrmAddPlane addPlane = new FrmAddPlane(airplanes);
            if(addPlane.ShowDialog() == DialogResult.OK)
            {
                airplanes.Add(addPlane.Airplane());
                Fleet.MaxFlights += 1;
                Fleet.MaxPlanes += 1;
                PlanesAmountUpdate();
                FlightsAmountUpdate();
            }
        }

        //------------------------------------------------------------
        //-------------------------------------------[ METHODS ]
        //------------------------------------------------------------

        private void CmbBox_PassengersMechanics()
        {            
            if(cmbBox_Passengers.Text == "All passengers")
            {
                DataGridAllPassengersDisplay(cmbBox_Flights.SelectedIndex-1);
            }
            else if(cmbBox_Flights.Text != "All passengers")
            {
                DataGridPassengerDisplay(cmbBox_Flights.SelectedIndex - 1, cmbBox_Passengers.SelectedIndex - 1);
            }
        }

        //***********************************************

        private void CmbBox_FlightsMechanics()
        {            
            if (cmbBox_Flights.Text == "All flights")
            {
                DataGridAllFlightsDisplay();
            }
            else if(cmbBox_Flights.Text != "All flights")
            {
                DataGridFlightDisplay(cmbBox_Flights.SelectedIndex-1);
            }
        }

        //***********************************************

        private void DataGridAllPassengersDisplay(int index)
        {
            //Set AutoGenerateColumns False            
            DgvMainGrid.DataSource = null;
            DgvMainGrid.Columns.Clear();
            DgvMainGrid.ColumnCount = 5;
            DgvMainGrid.AutoGenerateColumns = false;            

            ColumnDrawing(0, "Name", "Name", "name");
            ColumnDrawing(1, "Last Name", "Last Name", "lastName");
            ColumnDrawing(2, "Age", "Age", "age");
            ColumnDrawing(3, "Gender", "Gender", "gender");
            ColumnDrawing(4, "DNI", "DNI", "dni");

            allPassengers.Clear();

            foreach(var passengerTourist in source[index].Tourist) // changed
            {
                allPassengers.Add(passengerTourist.Value);
            }
            foreach (var passengerPremium in source[index].Premium) //changed
            {
                allPassengers.Add(passengerPremium.Value);
            }
            DgvMainGrid.DataSource = allPassengers;
        }

        //***********************************************

        private void DataGridPassengerDisplay(int index, int index2)
        {
            //Set AutoGenerateColumns False            
            DgvMainGrid.DataSource = null;
            DgvMainGrid.Columns.Clear();
            DgvMainGrid.ColumnCount = 2;
            DgvMainGrid.AutoGenerateColumns = false;

            allPassengers.Clear();

            foreach (var passengerTourist in source[index].Tourist)
            {
                allPassengers.Add(passengerTourist.Value);
            }
            foreach (var passengerPremium in source[index].Premium)
            {
                allPassengers.Add(passengerPremium.Value);
            }

            Passenger passenger = allPassengers[index2];

            ColumnDrawing(0, "Name", "Name", "name");
            ColumnDrawing(1, "Last Name", "Last Name", "lastName");

            DgvMainGrid.DataSource = new List<Passenger> { passenger };
        }

        //***********************************************

        public void DataGridAllFlightsDisplay()
        {
            DgvMainGrid.DataSource = null;
            DgvMainGrid.Columns.Clear();
            DgvMainGrid.ColumnCount = 9;
            DgvMainGrid.AutoGenerateColumns = false;

            ColumnDrawing(0, "Plane Tag", "Plane Tag", "tag");
            ColumnDrawing(1, "Origin", "Origin", "origin");
            ColumnDrawing(2, "Destination", "Destination", "destination");
            ColumnDrawing(3, "Price", "Price", "price");
            DgvMainGrid.Columns[3].DefaultCellStyle.Format = "C"; // C is for Currency
            ColumnDrawing(4, "PremiumPrice", "Premium Price", "premiumPrice");
            DgvMainGrid.Columns[4].DefaultCellStyle.Format = "C";
            ColumnDrawing(5, "FlightDeparture", "Flight Departure", "flightStart");
            ColumnDrawing(6, "FlightArrival", "Flight Arrival", "flightEnd");
            ColumnDrawing(7, "Flight Duration", "Flight Duration", "flightDuration");
            ColumnDrawing(8, "Earned", "Earned", "flightearned");
            DgvMainGrid.Columns[8].DefaultCellStyle.Format = "C";

            if(RdoBttn_SourceCurrent.Checked == true)
            {
                DrawCancelFlightBttn();
            }
            

            DgvMainGrid.DataSource = source;

            grpBox_Passengers.Visible = false;
        }

        //***********************************************

        private void DataGridFlightDisplay(int index)
        {
            DgvMainGrid.DataSource = null;
            DgvMainGrid.Columns.Clear();
            DgvMainGrid.ColumnCount = 10;
            DgvMainGrid.AutoGenerateColumns = false;

            Flight flight = source[index];

            ColumnDrawing(0, "Plane Tag", "Plane Tag", "tag");
            ColumnDrawing(1, "Total Seats", "Total Seats", "seatsTotal");
            ColumnDrawing(2, "Premium Class Seats", "Premium Class Seats", "premiumPrice");
            ColumnDrawing(3, "Tourist Class Seats", "Tourist Class Seats", "price");
            ColumnDrawing(4, "Bathrooms", "Bathrooms", "WCS");
            ColumnDrawing(5, "Max Cargo", "Max Cargo", "maxCargo");
            ColumnDrawing(6, "Current Cargo", "Current Cargo", "cargo");
            ColumnDrawing(7, "Passengers", "Passengers", "amountPassengers");            
            ColumnDrawing(8, "Has wifi", "Has wifi", "hasWifi");
            ColumnDrawing(9, "Has food", "Has food", "hasFood");

            DrawCancelFlightBttn();

            DgvMainGrid.DataSource = new List<Flight> {flight};
            grpBox_Passengers.Visible = true;

            CmbBoxPassengersPopulate(flight);
        }

        //***********************************************

        private void ColumnDrawing(int index, string name, string header, string field)
        {
            DgvMainGrid.Columns[index].Name = name; // name
            DgvMainGrid.Columns[index].HeaderText = header; // header text
            DgvMainGrid.Columns[index].DataPropertyName = field; // field name
        }

        //***********************************************

        private void CmbBoxPassengersPopulate(Flight flight)
        {
            cmbBox_Passengers.Items.Clear();
            cmbBox_Passengers.Text = string.Empty;

            StringBuilder passengerData = new();

            if(flight.PassengersPremium > 0 || flight.PassengersTourist >0)
            {
                cmbBox_Passengers.Items.Add("All passengers");
            }

            foreach(var passengerTourist in flight.Tourist)
            {
                passengerData.Append(passengerTourist.Value.Name+" "+passengerTourist.Value.LastName);
                
                cmbBox_Passengers.Items.Add(passengerData.ToString());

                passengerData.Clear();
            }
        }

        //***********************************************

        private void CmbBoxFlightsPopulate()
        {
            cmbBox_Flights.Items.Clear();
            if (source.Count < 1)
            {
                cmbBox_Flights.Text = "< there are no flights >";                
            }
            else
            {
                int i=0;
                
                cmbBox_Flights.Text = "[ FLIGHTS ]";
                cmbBox_Flights.Items.Add("All flights");
                foreach (Flight flight in source)
                {
                    i++;
                    cmbBox_Flights.Items.Add("Flight #"+i);
                }                
            }
        }

        //***********************************************

        private void FlightsAmountUpdate()
        {
            Lbl_FlightsAmount.Text = "Current Flights: " + flights.Count.ToString()+" / "+Fleet.MaxFlights.ToString()+" max.";
            if (flights.Count <= (Fleet.MaxFlights/3))
            {
                Lbl_FlightsAmount.ForeColor = System.Drawing.Color.Green;
            }
            else if (flights.Count >= (Fleet.MaxFlights / 3) && flights.Count <= ((Fleet.MaxFlights / 3)*2))
            {
                Lbl_FlightsAmount.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                Lbl_FlightsAmount.ForeColor = System.Drawing.Color.Red;
            }
        }

        //***********************************************

        private void PlanesAmountUpdate()
        {
            Lbl_PlanesAmount.Text = "Free Airplanes: " + airplanes.Count.ToString() + " / " + Fleet.MaxPlanes.ToString() + " max.";
            if (flights.Count <= (Fleet.MaxFlights / 3))
            {
                Lbl_PlanesAmount.ForeColor = System.Drawing.Color.Green;
            }
            else if (airplanes.Count >= (Fleet.MaxPlanes / 3) && airplanes.Count <= ((Fleet.MaxPlanes / 3) * 2))
            {
                Lbl_PlanesAmount.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                Lbl_PlanesAmount.ForeColor = System.Drawing.Color.Red;
            }
        }

        //***********************************************
        private void DrawCancelFlightBttn()
        {
            DataGridViewButtonColumn removeFlight = new DataGridViewButtonColumn()
            {
                Name = "dgvRmvFlight",
                Text = "Finish Flight",
                HeaderText = "Actions",
                UseColumnTextForButtonValue = true
            };
            DgvMainGrid.Columns.Add(removeFlight);
        }

        //***********************************************

        private void ClientsAmountUpdate()
        {
            Lbl_ClientsAmount.Text = "Clients: "+clients.Count.ToString();
        }

        //------------------------------------------------------------
        //-------------------------------------------[ EVENTS ]
        //------------------------------------------------------------

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        //***********************************************

        private void RdoBttn_SourceCurrent_CheckedChanged(object sender, EventArgs e)
        {
            if(RdoBttn_SourceCurrent.Checked == true)
            {
                source = flights;
                DataGridAllFlightsDisplay();
                CmbBoxFlightsPopulate();
            }            
        }

        //***********************************************

        private void RdoBttn_SourceHistory_CheckedChanged(object sender, EventArgs e)
        {
            if(RdoBttn_SourceHistory.Checked == true)
            {
                source = history;
                DataGridAllFlightsDisplay();
                CmbBoxFlightsPopulate();
            }
        }

        //------------------------------------------------------------
        //-------------------------------------------[ TOOLTIPS ]
        //------------------------------------------------------------

        private void Lbl_PlanesAmount_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This label shows amount of currently available airplanes.\nEvery time a plane is taken for a flight, the amount of planes gets reduced.\n" +
                "If a plane is freed, it will be reflected here.",Lbl_PlanesAmount);
        }

        //***********************************************

        private void Lbl_FlightsAmount_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This label shows the amount of currently on-going flights.\nEvery time a flight is created or finished it will be reflected here.",Lbl_FlightsAmount);
        }

        //***********************************************

        private void cmbBox_Flights_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This combobox allows the user to pick among the flights from the source, be it history or current flights.\n" +
                            "If there are no flights, it will appear empty.\n\n" +
                            "If the user selects a flight, they can see the details of the selected flight.", cmbBox_Flights);
        }

        //***********************************************

        private void cmbBox_Passengers_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This combobox allows the user to pick among the passengers from the flight.\n" +
                "If there are no passengers, it will appear empty.\n\n" +
                "If the user selects a passenger, they can see the details of the selected passenger.", cmbBox_Passengers);
        }

        //***********************************************

        private void Btn_SellTicket_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This button opens the ticket selling hub, from which the user can select a flight, filtering if they wish so, and then" +
                            "sell a ticket for that flight.", Btn_SellTicket);
        }

        private void Btn_AddFlight_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This button opens the form for creating a flight.", Btn_AddFlight);
        }

        private void Btn_AddClient_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This button opens the hub from which the user will be allowed to either entry a client manually, or generate N amount of\n" +
                        "random clients, from 1 to 100.", Btn_AddClient);
        }

        private void Btn_ViewClient_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This button allows the user to see the list of clients and all their data.", Btn_ViewClient);
        }

        private void Btn_MainCheckDestinations_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This button opens a form which allows the user to see all the important data about the destinations.", Btn_MainCheckDestinations);
        }

        private void Lbl_ClientsAmount_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This is the amount of registered clients.", Lbl_ClientsAmount);
        }

        private void btn_ExitProgram_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Exit the program completely.",btn_ExitProgram);
        }

        private void btn_LogOut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Logout and return to the login screen.",btn_LogOut);
        }

    }
}
