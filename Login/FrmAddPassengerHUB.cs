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
    public partial class FrmAddPassengerHUB : Form
    {
        //******************************************************
        List<Passenger> currentClients;
        List<Passenger> newClients;
        //******************************************************

        public FrmAddPassengerHUB(List<Passenger> clients)
        {
            InitializeComponent();
            currentClients = clients;
            newClients = new List<Passenger>();
        }
        public List<Passenger> Clients
        {
            get { return newClients; }
        }

        private void Btn_AddHubRandom_Click(object sender, EventArgs e)
        {
            FrmRandomClient frmRandomPassenger = new FrmRandomClient(currentClients);
            if(frmRandomPassenger.ShowDialog() == DialogResult.OK)
            {
                newClients = frmRandomPassenger.Clients;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Btn_AddHubManual_Click(object sender, EventArgs e)
        {            
            FrmAddClient frmAddPassenger = new FrmAddClient(currentClients);
            if (frmAddPassenger.ShowDialog() == DialogResult.OK)
            {
                newClients.Add(frmAddPassenger.Passenger);
                this.DialogResult = DialogResult.OK;            
            }
        }


        private void Btn_AddHubCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
