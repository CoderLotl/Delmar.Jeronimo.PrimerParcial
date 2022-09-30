using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmLogging : Form
    {

        int timer=0;
        System.Media.SoundPlayer vuela = new System.Media.SoundPlayer();


        public FrmLogging()
        {
            InitializeComponent();            
            timer1.Start();            
            vuela.SoundLocation = "audiomass-output2.wav";
            vuela.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer == 42)
            {
                vuela.Stop();
                this.Close();
            }
        }
    }
}
