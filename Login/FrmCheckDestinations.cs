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
    public partial class FrmCheckDestinations : Form
    {

        DataTable destinationsDataTable;
        DataView destinationsDataView;
        List<Destination> destinations;

        public FrmCheckDestinations(List<Destination> destinations)
        {
            InitializeComponent();
            this.destinations = destinations;
            destinationsDataTable = new DataTable();
            destinationsDataView = destinationsDataTable.DefaultView;
        }

        private void DrawDataTable()
        {            
            destinationsDataTable = new DataTable();
            destinationsDataView = destinationsDataTable.DefaultView;
            destinationsDataTable.Columns.Add("Destination", typeof(string));
            destinationsDataTable.Columns.Add("Flights", typeof(string));
            destinationsDataTable.Columns.Add("Passengers", typeof(string));
            destinationsDataTable.Columns.Add("Earned", typeof(float));            

            foreach (Destination destination in destinations)
            {
                string destiNation = destination.ToString();

                string destiny = "";
                string flights = "";
                string passengers = "";
                string earned = "";
                int i = 0;

                foreach(string data in destiNation.Split('|'))
                {
                    switch (i)
                    {
                        case 0:
                            destiny = data;
                            break;
                        case 1:
                            flights = data;
                            break;
                        case 2:
                            passengers = data;
                            break;
                        case 3:
                            earned = data;
                            break;
                    }
                    i++;                    
                }
                destinationsDataTable.Rows.Add(destiny, flights, passengers,earned);
            }
            DgvCheckDestinations.DataSource = destinationsDataTable;
            
        }

        private void FrmCheckDestinations_Load(object sender, EventArgs e)
        {
            DrawDataTable();
        }

        private void Btn_ChckDestClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
