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
    public partial class FrmAddPlane : Form
    {
        //******************************************************
        List<Airplane> airplanes;
        Airplane? airplane;
        //******************************************************

        public FrmAddPlane(List<Airplane> airplanes)
        {
            InitializeComponent();

            this.airplanes = airplanes;
        }

        //------------------------------------------------------------
        //-------------------------------------------[ PROPERTIES ]
        //------------------------------------------------------------

        public Airplane Airplane()
        {
            return airplane!;
        }

        //------------------------------------------------------------
        //-------------------------------------------[ BUTTONS ]
        //------------------------------------------------------------
        private void Btn_FrmAddFlightCancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //***********************************************

        private void Btn_FrmAddFlightAccept_Click(object sender, EventArgs e)
        {
            airplane = new Airplane(TxtBox_PlaneTag.Text, (int)NUD_PlaneSeats.Value, (int)NUD_PlaneWCS.Value, (int)NUD_PlaneCargo.Value, ChckBox_Food.Checked, ChckBox_Wifi.Checked);
            this.DialogResult = DialogResult.OK;
        }

        //***********************************************

        private void TxtBox_PlaneTag_TextChanged(object sender, EventArgs e)
        {
            Extras.ControlColorChange(TxtBox_PlaneTag, 3);
            CheckAll();
        }

        //***********************************************

        private void NUD_PlaneCargo_ValueChanged(object sender, EventArgs e)
        {
            Extras.ControlColorChange(NUD_PlaneCargo, 4);
            CheckAll();
        }

        //------------------------------------------------------------
        //-------------------------------------------[ METHODS ]
        //------------------------------------------------------------

        public void CheckAll()
        {
            if (!string.IsNullOrEmpty(TxtBox_PlaneTag.Text) && TxtBox_PlaneTag.Text.Length <=8 && ((int)NUD_PlaneCargo.Value != 0))
            {
                Btn_FrmAddFlightAccept.Enabled = true;
            }
            else
            {
                Btn_FrmAddFlightAccept.Enabled = false;
            }
        }
    }
}
