using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UI.FrmAddFlight;

namespace UI
{
    public partial class FrmSellTicketMain : Form
    {
        //******************************************************
        List<Flight> flights;
        List<Passenger> clients;
        DataTable flightsDataTable;
        DataView flightsDataView;
        Flight? aFlight;
        FrmMain main;
        //******************************************************

        public FrmSellTicketMain(List<Flight> flights,List<Passenger> clients, FrmMain main)
        {
            InitializeComponent();
            this.flights = flights;
            this.clients = clients;
            this.main = main;
            flightsDataTable = new DataTable();
            flightsDataView = flightsDataTable.DefaultView;            
        }

        private void FrmSellTicketMain_Load(object sender, EventArgs e)
        {
            DrawDataTable(0);
        }


        private void Btn_SellTicketCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            main.DataGridAllFlightsDisplay();
        }


        private void Btn_SellTicketAccept_Click(object sender, EventArgs e)
        {
            FrmSellTicket sellTicket = new FrmSellTicket(aFlight,clients);
            if(sellTicket.ShowDialog() == DialogResult.OK)
            {
                aFlight = sellTicket.AFlight;

                for(int i = 0; i < flights.Count; i++)
                {
                    if (flights[i].Airplane.Tag == aFlight.Airplane.Tag)
                    {
                        flights[i] = aFlight;
                        break;
                    }
                }
                DrawDataTable(1);
                aFlight = null;
                RchTxtBox_FlightInfo.Text = String.Empty;
                Btn_SellTicketAccept.Enabled = false;
            }
            else
            {
                aFlight = null;
                RchTxtBox_FlightInfo.Text = String.Empty;
                Btn_SellTicketAccept.Enabled = false;
            }
        }

        private void RdoBttn_National_CheckedChanged(object sender, EventArgs e)
        {            
            ChckBox_Food.Checked = false;
            ChckBox_Wifi.Checked = false;
            CmboBox_Origin.Items.Clear();
            CmboBox_Origin.Text = String.Empty;
            CmboBox_Origin.Items.Add("");
            foreach (string item in Enum.GetValues(typeof(National)))
            {
                string? str = "";

                switch (item.ToString())
                {
                    case "SantaRosa":
                        str = "Santa Rosa";
                        break;
                    case "SantiagoDelEstero":
                        str = "Santiago Del Estero";
                        break;
                    case "PuertoMadryn":
                        str = "Puerto Madryn";
                        break;
                    default:
                        str = item.ToString();
                        break;
                }
                CmboBox_Origin.Items.Add(str);
            }

            //--------------

            CmboBox_Destination.Items.Clear();
            CmboBox_Destination.Text = String.Empty;
            CmboBox_Destination.Items.Add("");
            foreach (string item in Enum.GetValues(typeof(National)))
            {
                string str = "";

                switch (item.ToString())
                {
                    case "SantaRosa":
                        str = "Santa Rosa";
                        break;
                    case "SantiagoDelEstero":
                        str = "Santiago Del Estero";
                        break;
                    case "PuertoMadryn":
                        str = "Puerto Madryn";
                        break;
                    default:
                        str = item.ToString();
                        break;
                }
                CmboBox_Destination.Items.Add(str);
            }            
        }

        private void RdoBttn_International_CheckedChanged(object sender, EventArgs e)
        {
            
            ChckBox_Food.Checked = false;
            ChckBox_Wifi.Checked = false;
            CmboBox_Origin.Items.Clear();
            CmboBox_Origin.Text = String.Empty;
            CmboBox_Origin.Text = "Buenos Aires";
            CmboBox_Origin.Items.Add("Buenos Aires");

            //--------------

            CmboBox_Destination.Items.Clear();
            CmboBox_Destination.Text = String.Empty;
            CmboBox_Destination.Items.Add("");
            foreach (var item in Enum.GetValues(typeof(International)))
            {
                string str = "";

                switch (item.ToString())
                {
                    case "Recife":
                        str = "Recife (Brasil)";
                        break;
                    case "Rome":
                        str = "Rome (Italy)";
                        break;
                    case "Acapulco":
                        str = "Acapulco (Mexico)";
                        break;
                    case "Miami":
                        str = "Miami (USA)";
                        break;
                }
                CmboBox_Destination.Items.Add(str);
            }            
        }

        private void CmboBox_Origin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmboBox_Destination.Text))
            {
                flightsDataView.RowFilter = "Origin LIKE '" + CmboBox_Origin.Text + "%'";
                Dgv_TicketFlights.DataSource = flightsDataView;
                
                ChckBox_Food.Checked = false;
                ChckBox_Wifi.Checked = false;
            }
            else
            {
                flightsDataView.RowFilter = "Origin LIKE '" + CmboBox_Origin.Text + "%'"+"AND Destination LIKE '"+CmboBox_Destination.Text+"%'";
                Dgv_TicketFlights.DataSource = flightsDataView;                
            }          
        }

        private void CmboBox_Destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmboBox_Origin.Text))
            {
                flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'";
                Dgv_TicketFlights.DataSource = flightsDataView;
                
                ChckBox_Food.Checked = false;
                ChckBox_Wifi.Checked = false;
            }
            else
            {
                flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'";
                Dgv_TicketFlights.DataSource = flightsDataView;                
            }
        }

        private void ChckBox_Wifi_CheckedChanged(object sender, EventArgs e)
        {
            if(ChckBox_Wifi.Checked == true)
            {
                flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'"
                    + "AND Wifi LIKE '" + "Yes" + "%'";
                if(ChckBox_Food.Checked == true)
                {
                    flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'"
                        + "AND Wifi LIKE '" + "Yes" + "%'" + "AND Food LIKE '" + "Yes" + "%'";
                }
            }
            else
            {
                if (ChckBox_Food.Checked == true)
                {
                    flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'"
                    + "AND Food LIKE '" + "Yes" + "%'";
                }
                flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'";
            }
        }

        private void ChckBox_Food_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckBox_Food.Checked == true)
            {
                flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'"
                    + "AND Food LIKE '" + "Yes" + "%'";
                if (ChckBox_Wifi.Checked == true)
                {
                    flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'"
                        + "AND Wifi LIKE '" + "Yes" + "%'" + "AND Food LIKE '" + "Yes" + "%'";
                }
            }
            else
            {
                if (ChckBox_Wifi.Checked == true)
                {
                    flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'"
                        + "AND Wifi LIKE '" + "Yes" + "%'";
                }
                flightsDataView.RowFilter = "Destination LIKE '" + CmboBox_Destination.Text + "%'" + "AND Origin LIKE '" + CmboBox_Origin.Text + "%'";
            }
        }

        private void Dgv_TicketFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_TicketFlights.Columns[e.ColumnIndex].Name == "dgvSlcFlight")
            {
                RchTxtBox_FlightInfo.Text = String.Empty;
                int index = Dgv_TicketFlights.CurrentRow.Index;
                aFlight = flights[index];                

                if(Convert.ToInt32(aFlight.Airplane.SeatsPremium)!=0 || Convert.ToInt32(aFlight.Airplane.SeatsTourist) != 0)
                {
                    RchTxtBox_FlightInfo.Text = aFlight.Airplane.Tag + " || Origin: " + aFlight.Origin + " || Destination: " + aFlight.Destination + "\n" +
                                    "Flight departure: " + aFlight.FlightStart+"\nPremium seats: "+aFlight.Airplane.SeatsPremium +"\nTourist seats: "+aFlight.Airplane.SeatsTourist;
                    Btn_SellTicketAccept.Enabled = true;
                }
                else
                {
                    RchTxtBox_FlightInfo.Text = "[ERROR]\n\nThat flight has no available seats to sell.";
                    Btn_SellTicketAccept.Enabled = false;
                    aFlight = null;
                }
            }
        }

        private void DrawDataTable(int opt)
        {
            DataGridViewButtonColumn selectFlight = new DataGridViewButtonColumn()
            {
                Name = "dgvSlcFlight",
                Text = "SelectThis Flight",
                HeaderText = "SelectThis Flight",
                UseColumnTextForButtonValue = true
            };

            if (opt == 1)
            {
                Dgv_TicketFlights.DataSource = null;
                Dgv_TicketFlights.Columns.Clear();
                flightsDataTable.Rows.Clear();
            }

            flightsDataTable = new DataTable();
            flightsDataView = flightsDataTable.DefaultView;

            flightsDataTable.Columns.Add("Plane Tag", typeof(string));
            flightsDataTable.Columns.Add("Origin", typeof(string));
            flightsDataTable.Columns.Add("Destination", typeof(string));
            flightsDataTable.Columns.Add("Passengers", typeof(int));
            flightsDataTable.Columns.Add("Available Premium Seats", typeof(string));
            flightsDataTable.Columns.Add("Pr Seats Price", typeof(string));            
            flightsDataTable.Columns.Add("Available Tourist Seats", typeof(string));
            flightsDataTable.Columns.Add("Tr Seats Price", typeof(string));
            flightsDataTable.Columns.Add("Wifi", typeof(string));
            flightsDataTable.Columns.Add("Food", typeof(string));

            foreach (Flight flight in flights)
            {
                string flightData = flight.ToString();

                string tag = "";
                string origin = "";
                string destination = "";
                string passengers = "";
                string availablePremSeats = "";
                string premSeatsPrice = "";
                string availableTourSeats = "";
                string tourSeatsPrice = "";
                string wifi = "";
                string food = "";

                int i = 0;

                foreach(string date in flightData.Split('|'))
                {
                    switch (i)
                    {
                        case 0:
                            tag = date;
                            break;
                        case 1:
                            origin = date;
                            break;
                        case 2:
                            destination = date;
                            break;
                        case 3:
                            passengers = date;
                            break;
                        case 4:
                            availablePremSeats = date;
                            break;
                        case 5:
                            premSeatsPrice = date;
                            break;
                        case 6:
                            availableTourSeats = date;
                            break;
                        case 7:
                            tourSeatsPrice = date;
                            break;
                        case 8:
                            wifi = date;
                            break;
                        case 9:
                            food = date;
                            break;
                    }
                    i++;
                }
                flightsDataTable.Rows.Add(tag, origin, destination, passengers, availablePremSeats, premSeatsPrice, availableTourSeats,
                                            tourSeatsPrice, wifi, food);
            }

            Dgv_TicketFlights.DataSource = flightsDataTable;
            Dgv_TicketFlights.Columns.Add(selectFlight);

        }
    }
}
