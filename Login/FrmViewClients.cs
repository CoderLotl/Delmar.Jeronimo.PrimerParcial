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
    public partial class FrmViewClients : Form
    {
        //******************************************************

        List<Passenger> clients;
        DataTable clientsDataTable;
        DataView clientsDataView;
        //******************************************************
        public FrmViewClients(List<Passenger> clients)
        {
            InitializeComponent();

            this.clients = clients;
            clientsDataTable = new DataTable();
            clientsDataView = clientsDataTable.DefaultView;
        }



        private void DrawTable()
        {
            clientsDataTable.Columns.Add("Name", typeof(string));
            clientsDataTable.Columns.Add("Last Name", typeof(string));
            clientsDataTable.Columns.Add("Age", typeof(string));
            clientsDataTable.Columns.Add("Gender", typeof(string));
            clientsDataTable.Columns.Add("DNI", typeof(string));
            clientsDataTable.Columns.Add("Flights", typeof(string));
            clientsDataTable.Columns.Add("Is on a flight?", typeof(string));

            foreach(Passenger client in clients)
            {
                string OnFly;
                switch (client.OnFly)
                {
                    case true:
                        OnFly = "On a flight";
                        break;
                    case false:
                        OnFly = "Not on a flight";
                        break;
                }

                int i = 0;

                string clientData = client.ToString();
                string name = "";
                string lastName = "";
                string age = "";
                string gender = "";
                string dni = "";
                string flights = "";

                foreach(string date in clientData.Split('|'))
                {
                    switch (i)
                    {
                        case 0:
                            name = date;
                            break;
                        case 1:
                            lastName = date;
                            break;
                        case 2:
                            gender = date;
                            break;
                        case 3:
                            dni = date;
                            break;
                        case 4:
                            age = date;
                            break;
                        case 5:
                            flights = date;
                            break;
                    }
                    i++;
                }
                clientsDataTable.Rows.Add(name,lastName,age,gender,dni,flights,OnFly);
            }

            Dgv_PassView.DataSource = clientsDataTable;
        }

        private void FrmViewClients_Load(object sender, EventArgs e)
        {
            DrawTable();
        }

        private void Btn_ViewClientsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dgv_PassView.DataSource = clientsDataView;
            if(RdoBttn_PassViewFilterName.Checked == true)
            {
                clientsDataView.RowFilter = "Name LIKE '" + TxtBox_PassViewFilter.Text + "%'";
            }
            else if(RdoBttn_PassViewFilterLastName.Checked == true)
            {
                clientsDataView.RowFilter = "[Last Name] LIKE '" + TxtBox_PassViewFilter.Text + "%'";
            }
            else if(RdoBttn_PassViewFilterGender.Checked == true)
            {
                clientsDataView.RowFilter = "Gender LIKE '" + TxtBox_PassViewFilter.Text + "%'";
            }
            else if(RdoBttn_PassViewFilterDNI.Checked == true)
            {
                clientsDataView.RowFilter = "DNI LIKE '" + TxtBox_PassViewFilter.Text + "%'";
            }
            else if(RdoBttn_PassViewFilterAge.Checked == true)
            {
                clientsDataView.RowFilter = "Age LIKE '" + TxtBox_PassViewFilter.Text + "%'";
            }
            else if(RdoBttn_PassViewFilterFlights.Checked == true)
            {
                clientsDataView.RowFilter = "Flights LIKE '" + TxtBox_PassViewFilter.Text + "%'";
            }
        }
    }
}
