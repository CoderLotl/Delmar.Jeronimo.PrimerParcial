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
    public partial class FrmRandomClient : Form
    {
        //******************************************************
        List<Passenger> currentClients;
        List<Passenger> newClients;
        //******************************************************

        public FrmRandomClient(List<Passenger> currentClients)
        {
            InitializeComponent();
            this.currentClients = currentClients;
            newClients = new List<Passenger>();
        }

        private void Btn_RdmAccept_Click(object sender, EventArgs e)
        {
            int amount = (int)NUD_RdmClients.Value;

            Library.Extras.RandomClientsGenerator(amount,newClients,currentClients);

            this.DialogResult = DialogResult.OK;
        }

        private void Btn_RdmCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public List<Passenger> Clients
        {
            get { return newClients; }
        }
    }
}
