using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace UI
{
    public partial class FrmAddClient : Form
    {
        //******************************************************
        Passenger aPassenger;
        List<Passenger> clients;
        string gender;
        //******************************************************

        public FrmAddClient(List<Passenger> clients)
        {
            InitializeComponent();
            this.clients = clients;
            gender = "";
        }

        // ------------------------------------------------------

        public Passenger Passenger
        {
            get { return aPassenger; }
        }

        // ------------------------------------------------------


        private void TxtBox_DNI_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
            ColorChange(TxtBox_DNI, 1);
        }

        // ------------------------------------------------------

        private void TxtBox_Name_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
            ColorChange(TxtBox_Name, 0);
        }

        // ------------------------------------------------------

        private void TxtBox_LastName_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
            ColorChange(TxtBox_LastName, 0);
        }

        // ------------------------------------------------------

        private void RdBttn_Female_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
            gender = "Female";
        }

        // ------------------------------------------------------

        private void RdBttn_Male_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
            gender = "Male";
        }

        // ------------------------------------------------------

        private void RdBttn_NonBinary_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
            gender = "NonBinary";
        }

        // ------------------------------------------------------

        private void Btn_PassengerCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // ------------------------------------------------------

        private void Btn_PassengerAccept_Click(object sender, EventArgs e)
        {
            aPassenger = new Passenger(TxtBox_Name.Text, TxtBox_LastName.Text, gender, TxtBox_DNI.Text,
                Convert.ToInt32(NUD_Age.Value));

            aPassenger.OnFly = false;
            
            foreach(Passenger passenger in clients)
            {
                if(aPassenger.Equals(passenger))
                {
                    MessageBox.Show("This client exists already.");
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        // ------------------------------------------------------

        public void CheckAll()
        {
            Btn_PassengerAccept.Enabled = false;

            if (!(string.IsNullOrEmpty(TxtBox_Name.Text)) && !(string.IsNullOrEmpty(TxtBox_LastName.Text)) &&
                (TxtBox_Name.Text.All(char.IsLetter) && TxtBox_LastName.Text.All(char.IsLetter)) &&
                (RdBttn_Female.Checked == true || RdBttn_Male.Checked == true || RdBttn_NonBinary.Checked == true) &&
                (int.TryParse(TxtBox_DNI.Text, out _) != false))                
            {
                Btn_PassengerAccept.Enabled = true;
            }
        }

        private void Btn_RandomData_Click(object sender, EventArgs e)
        {
            Random randomNum = new Random();

            int num = randomNum.Next(0, 3);
            switch (num)
            {
                case 0:
                    RdBttn_NonBinary.Checked = true;
                    break;
                case 1:
                    RdBttn_Male.Checked = true;
                    break;
                case 2:
                    RdBttn_Female.Checked = true;
                    break;
            }            

            if (num == 2 || num == 0)
            {
                num = randomNum.Next(0, 12);                
                string[] name = { "Adriana", "Ariadna", "Aleatha","Daria","Chloe","Fiora","Jasmine","Loraine","Moira","Paula","Rose","Susan" };
                TxtBox_Name.Text = name[num];
                num = randomNum.Next(0,9);                
                string[] lastName = { "Steinman","Ramirez", "Woods", "Smith", "Cohen", "Ryan","Miller","Brown","Johnson" };
                TxtBox_LastName.Text = lastName[num];
            }
            if (num == 1 || num ==0)
            {                
                num = randomNum.Next(0, 12);                
                string[] name = { "John", "David", "Arthur", "Garen", "Andrew", "Jack", "Frank", "Sander", "Luke", "Charles", "Mathew", "Alexander" };
                TxtBox_Name.Text = name[num];
                num = randomNum.Next(0, 9);                
                string[] lastName = { "Steinman", "Ramirez", "Woods", "Smith", "Cohen", "Ryan", "Miller", "Brown", "Johnson" };
                TxtBox_LastName.Text = lastName[num];
            }

            num = randomNum.Next(0, 99);
            NUD_Age.Value = num;
            num = randomNum.Next(10000, 50000);
            TxtBox_DNI.Text = num.ToString();

            CheckAll();
        }


        public void ColorChange(Control control, int option)
        {
            if (!String.IsNullOrEmpty(control.Text))
            {
                if((option == 1 && !int.TryParse(control.Text, out _)) || (option != 1 && !control.Text.All(char.IsLetter)))
                {
                    control.BackColor = System.Drawing.Color.PaleVioletRed;
                }
                else if(option == 2 && control.Text.Length >= 8)
                {
                    control.BackColor = System.Drawing.Color.PaleVioletRed;
                }
                else
                {
                    control.BackColor = System.Drawing.Color.LightGreen;
                }
            }
            else
            {
                control.BackColor = SystemColors.Window;
            }
        }
    }
}
