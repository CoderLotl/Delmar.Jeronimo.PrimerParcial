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
    public partial class FrmNewAgent : Form
    {
        Agent newAgent;

        public Agent Agent
        {
            get { return newAgent; }
        }

        public FrmNewAgent()
        {
            InitializeComponent();
            newAgent = new Agent("", "", "");
        }

        private void Btn_NewAgent_Accept_Click(object sender, EventArgs e)
        {

            string user = this.txtBox_NewAgent_Name.Text;
            string password = this.txtBox_NewAgent_Password.Text;
            string realName = this.TxtBox_NewAgent_RealName.Text;

            newAgent = new Agent(user, password,realName);

            this.DialogResult = DialogResult.OK;
        }

        private void Btn_NewAgent_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
