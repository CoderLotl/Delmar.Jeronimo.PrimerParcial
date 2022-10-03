using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UI.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class FrmAddFlight : Form
    {
        //******************************************************
        List<Airplane> airplanes;
        Airplane? plane;
        Flight? flight;
        Image? planeImage;

        Random randomNumber = new Random();        
        DateTime currentDate;
        //******************************************************

        
        public FrmAddFlight(List<Airplane> airplanesParam)
        {
            InitializeComponent();
            airplanes = airplanesParam;

            currentDate = DateTime.Now;
        }

        // ------------------------------------------------------

        public Airplane Plane
        {
            get { return plane!; }
        }

        public Flight Flight
        {
            get { return flight!; }
        }

        //------------------------------------------------------------
        //-------------------------------------------[ BUTTONS ]
        //------------------------------------------------------------

        private void CmbBox_Plane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(CmbBox_Plane.Text)))
            {
                plane = airplanes[CmbBox_Plane.SelectedIndex - 1];

                richTextBox1.Text = plane.ToString();
                planeImage = (Image)Resources.ResourceManager.GetObject(plane.PictureURL)!;
                pictureBox1.Image = (Image)planeImage;

                if (!(string.IsNullOrEmpty(CmboBox_Origin.Text)) && !(string.IsNullOrEmpty(CmboBox_Destination.Text)))
                {
                    if (CmboBox_Origin.Text != CmboBox_Destination.Text)
                    {
                        Btn_FrmAddFlightAccept.Enabled = true;
                    }
                }
            }
            else
            {
                richTextBox1.Text = String.Empty;
                plane = null;
                Btn_FrmAddFlightAccept.Enabled = false;
            }
        }

        //-------------------------------------------

        private void FrmAddFlight_Load(object sender, EventArgs e)
        {
            PopulateAirplanesComboBox();
            Btn_FrmAddFlightAccept.Enabled = false;
            Lbl_NewFlightError.Visible = false;

            DTP_FlightStart.MinDate = currentDate;
        }

        //-------------------------------------------

        private void Btn_FrmAddFlightAccept_Click(object sender, EventArgs e)
        {
            string[] values = new string[4];
            bool isNational;

            if (RdoBttn_International.Checked == true)
            {                
                FlightPriceAndDurationCalc(values, 480, 721, 100);
                isNational = false;
            }
            else
            {                
                FlightPriceAndDurationCalc(values, 120, 241, 50);
                isNational = true;
            }

            SortedDictionary<int, Passenger> tourist = new SortedDictionary<int, Passenger>();
            SortedDictionary<int, Passenger> premium = new SortedDictionary<int, Passenger>();

            List < Luggage > cargo = new List<Luggage>();

            flight = new Flight(plane,CmboBox_Origin.Text, CmboBox_Destination.Text,
                                tourist, premium, cargo, float.Parse(values[1]), values[0], values[2], values[3]);
            flight.IsNational = isNational;
            this.DialogResult = DialogResult.OK;
        }

        //-----------------------------------------------
        //----------------------------------------------- [ METHODS ]
        //-----------------------------------------------

        private void PopulateAirplanesComboBox()
        {
            CmbBox_Plane.Items.Add("");
            foreach(Airplane aPlane in airplanes)
            {
                CmbBox_Plane.Items.Add(aPlane.Tag);
            }
        }

        //-------------------------------------------

        private void Btn_FrmAddFlightCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //-------------------------------------------

        private void RdoBttnNational_CheckedChanged(object sender, EventArgs e)
        {
            CmboBox_Origin.Items.Clear();
            CmboBox_Origin.Text = String.Empty;            
            foreach(var item in Enum.GetValues(typeof(National)))
            {
                string str = "";

                switch (item.ToString())
                {
                    case "BuenosAires":
                        str = "Buenos Aires";
                        break;
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
            foreach (var item in Enum.GetValues(typeof(National)))
            {
                string str = "";

                switch (item.ToString())
                {
                    case "BuenosAires":
                        str = "Buenos Aires";
                        break;
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
            Btn_FrmAddFlightAccept.Enabled = false;
        }

        //-------------------------------------------

        private void RdoBttnInternational_CheckedChanged(object sender, EventArgs e)
        {
            CmboBox_Origin.Items.Clear();
            CmboBox_Origin.Text = String.Empty;
            CmboBox_Origin.Text = "Buenos Aires";
            CmboBox_Origin.Items.Add("Buenos Aires");

            //--------------

            CmboBox_Destination.Items.Clear();
            CmboBox_Destination.Text = String.Empty;
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
            Btn_FrmAddFlightAccept.Enabled = false;
        }

        //-------------------------------------------

        private void CmboBox_Origin_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddFlightErrorMessage();
        }

        //-------------------------------------------

        private void CmboBox_Destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddFlightErrorMessage();
        }

        //-------------------------------------------


        private void AddFlightErrorMessage()
        {
            if (CmboBox_Origin.Text != CmboBox_Destination.Text && CmboBox_Destination.Text != CmboBox_Origin.Text)
            {                
                if(!string.IsNullOrEmpty(CmboBox_Origin.Text) && !string.IsNullOrEmpty(CmboBox_Destination.Text))
                {
                    Lbl_NewFlightError.Visible = true;
                    Lbl_NewFlightError.ForeColor = System.Drawing.Color.Green;
                    Lbl_NewFlightError.Text = "All fine.";

                    if (plane != null)
                    {
                        Btn_FrmAddFlightAccept.Enabled = true;
                    }
                }
            }
            else
            {
                Btn_FrmAddFlightAccept.Enabled = false;
                Lbl_NewFlightError.Visible = true;
                Lbl_NewFlightError.ForeColor = System.Drawing.Color.Red;
                Lbl_NewFlightError.Text = "The destination can't be the same\nas the origin.";                
            }
        }

        //-------------------------------------------

        private string[] FlightPriceAndDurationCalc(string[] values, int min, int max, float price)
        {
            float flightDuration;            

            flightDuration = randomNumber.Next(min, max);            

            TimeSpan duration = TimeSpan.FromMinutes(flightDuration);
                        
            values[0] = duration.ToString(@"hh\:mm") + " hours";
            
            values[1] = ((flightDuration / 60) * price).ToString("0.00");
                        
            values[2] = DTP_FlightStart.Value.ToString();
                        
            values[3] = (DTP_FlightStart.Value + duration).ToString();

            return values;
        }
    }
}
