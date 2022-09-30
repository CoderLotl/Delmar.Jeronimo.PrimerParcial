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

namespace UI
{
    public partial class FrmSellTicket : Form
    {
        //******************************************************
        Flight aFlight;
        List<Passenger> clients;
        List<Passenger> availableClients;
        List<Passenger> passengers;

        //******************************************************

        public FrmSellTicket(Flight aFlight, List<Passenger> clients)
        {
            InitializeComponent();

            this.aFlight = aFlight;
            this.clients = clients;
            passengers = new List<Passenger>();
            availableClients = new List<Passenger>();
        }

        // ------------------------------------------------------ [ LOAD ]

        private void FrmSellTicket_Load(object sender, EventArgs e)
        {
            foreach(Passenger client in clients)
            {
                if(!client.OnFly)
                {
                    availableClients.Add(client);
                }
            }

            Dgv_Clients.AutoGenerateColumns = false;
            Dgv_Passengers.AutoGenerateColumns = false;            

            Dgv_Clients.DataSource = availableClients;
            UpdateAll(0);
        }

        // ------------------------------------------------------ [ PROPERTIES ]

        public Flight AFlight
        {
            get { return aFlight; }
        }

        //------------------------------------------------------------
        //-------------------------------------------[ BUTTONS ]
        //------------------------------------------------------------        

        private void Btn_SellTicketAddPass_Click(object sender, EventArgs e)
        {
            int num = 0;

            foreach (DataGridViewRow row in Dgv_Clients.Rows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value))
                {
                    row.Selected = true;                    
                }
            }

            foreach (DataGridViewRow row in Dgv_Clients.Rows)
            {
                if(row.Selected == true)
                {
                    passengers.Add(availableClients[row.Index-num]);
                    availableClients.RemoveAt(row.Index-num);
                    num++;
                }
            }
            UpdateAll(1);
        }

        //***********************************************

        private void Btn_SellTicketRmvPass_Click(object sender, EventArgs e)
        {
            int num = 0;

            foreach (DataGridViewRow row in Dgv_Passengers.Rows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value))
                {
                    row.Selected = true;
                }
            }

            foreach (DataGridViewRow row in Dgv_Passengers.Rows)
            {
                if (row.Selected == true)
                {
                    availableClients.Add(passengers[row.Index - num]);
                    passengers.RemoveAt(row.Index - num);
                    num++;
                }
            }
            UpdateAll(1);
        }

        //***********************************************


        private void Btn_SellTicketCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //***********************************************

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAll(0);
        }

        //***********************************************

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAll(0);
        }

        //***********************************************

        private void Btn_SellTicketAccept_Click(object sender, EventArgs e)
        {
            int classType;

            if (RdoBttn_Premium.Checked == true)
            {
                classType = 1;
            }
            else
            {
                classType = 2;
            }

            FrmLuggageRegistry luggageRegistry = new FrmLuggageRegistry(classType, passengers);
            if(luggageRegistry.ShowDialog() == DialogResult.OK)
            {
                if (classType == 1)
                {
                    foreach (Passenger passenger in passengers)
                    {
                        passenger.OnFly = true;
                        if (aFlight.Premium.Count > 0)
                        {
                            aFlight.Premium.Add(aFlight.Premium.Keys.Last() + 1, passenger);
                        }
                        else
                        {
                            aFlight.Premium.Add(1, passenger);
                        }
                    }
                }
                else
                {
                    foreach (Passenger passenger in passengers)
                    {
                        passenger.OnFly = true;
                        passenger.Flights++;
                        if (aFlight.Tourist.Count > 0)
                        {
                            aFlight.Tourist.Add(aFlight.Tourist.Keys.Last() + 1, passenger);
                        }
                        else
                        {
                            aFlight.Tourist.Add(1, passenger);
                        }
                    }
                }

                List<List<Luggage>> passengersLuggage = luggageRegistry.AllTheLuggage;


                foreach(List<Luggage> luggageList in passengersLuggage)
                {
                    foreach(Luggage luggage in luggageList)
                    {
                        aFlight.CargoLst.Add(luggage);
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
            UpdateAll(1);            
        }

        //------------------------------------------------------------
        //-------------------------------------------[ METHODS ]
        //------------------------------------------------------------

        private void UpdateAll(int param)
        {
            if(param == 1)
            {
                Dgv_Clients.DataSource = null;
                Dgv_Passengers.DataSource = null;
                Dgv_Clients.DataSource = availableClients;
                Dgv_Passengers.DataSource = passengers;
            }

            Lbl_PremSeatsAmount.Text = (aFlight.Airplane.SeatsPremium - aFlight.PassengersPremium).ToString();
            Lbl_TourSeatsAmount.Text = (aFlight.Airplane.SeatsTourist - aFlight.PassengersTourist).ToString();
            Lbl_PassengersToEmbark.Text = passengers.Count.ToString();
            Lbl_CrntPassAmount.Text = aFlight.AmountPassengers.ToString();

            if(passengers.Count > (aFlight.Airplane.SeatsPremium - aFlight.PassengersPremium))
            {
                RdoBttn_Premium.Enabled = false;
                RdoBttn_Premium.Checked = false;
            }
            else
            {
                RdoBttn_Premium.Enabled = true;
            }
            if (passengers.Count > (aFlight.Airplane.SeatsTourist - aFlight.PassengersTourist))
            {
                RdoBttn_Tourist.Enabled = false;
                RdoBttn_Tourist.Checked = false;
            }
            else
            {
                RdoBttn_Tourist.Enabled = true;
            }

            RchTxtBox_Total.Text = String.Empty;

            if ((RdoBttn_Premium.Checked == true || RdoBttn_Tourist.Checked == true) && passengers.Count > 0)
            {
                Btn_SellTicketAccept.Enabled = true;

                int seats = passengers.Count;
                float pricePerSeat = aFlight.Price;
                if(RdoBttn_Premium.Checked == true)
                {
                    pricePerSeat = aFlight.Price * 1.15f;
                }                


                RchTxtBox_Total.Text = "------ Price ------\n"+
                                       "Price per seat: "+pricePerSeat.ToString("c2")+"\n"+
                                       "Total Gross Price: "+(pricePerSeat*seats).ToString("c2")+"\n"+
                                       "Total Net Price with taxes (21%): "+(pricePerSeat*seats*1.21f).ToString("c2")+"\n";
            }
            else
            {
                Btn_SellTicketAccept.Enabled = false;
                RchTxtBox_Total.Text = String.Empty;
            }
        }
    }
}
