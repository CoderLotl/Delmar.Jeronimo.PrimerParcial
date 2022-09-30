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
    public partial class FrmLuggageRegistry : Form
    {
        //***********************************************
        int classType;
        List<Passenger> passengers;
        List<List<Luggage>> passengersLuggage;        
        int baggageMax;

        //***********************************************

        public FrmLuggageRegistry(int classType, List<Passenger> passengers)
        {
            InitializeComponent();
            this.classType = classType;
            this.passengers = passengers;
            passengersLuggage = new List<List<Luggage>>();
        }

        //***********************************************

        private void FrmLuggageRegistry_Load(object sender, EventArgs e)
        {
            TreeViewDrawing();

            Lbl_HLuggageAmount.Text = "0/1";

            if (classType == 1)
            {
                baggageMax = 2;
                Lbl_BaggageAmount.Text = "0/2";
                NUD_LuggageWeight.Maximum = 21;
                Lbl_MaxWeight.Text = Lbl_MaxWeight.Text+"21";
            }
            else
            {
                baggageMax = 1;
                Lbl_BaggageAmount.Text = "0/1";
                NUD_LuggageWeight.Maximum = 25;
                Lbl_MaxWeight.Text = Lbl_MaxWeight.Text+"25";
            }            
        }

        public List<List<Luggage>> AllTheLuggage
        {
            get { return passengersLuggage; }
        }
        
        //------------------------------------------------------------
        //-------------------------------------------[ BUTTONS ]
        //------------------------------------------------------------
        //***********************************************

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Parent == null)
            {
                RdoBtn_BaggageType.Checked = false;
                RdoBtn_LuggageType.Checked = false;
                Btn_RmvLuggage.Enabled = false;
            }
            else
            {
                Btn_AddLuggage.Enabled = false;
                if(treeView1.SelectedNode.Parent.Text == "Luggage")
                {
                    Btn_RmvLuggage.Enabled = true;
                    Luggage item = passengersLuggage[treeView1.SelectedNode.Parent.Parent.Index][treeView1.SelectedNode.Index];
                    richTextBox1.Text = item.ToString();
                }
                else
                {
                    Btn_RmvLuggage.Enabled = false;
                }
            }
            UpdateAll();
        }

        //***********************************************

        private void Btn_RmvLuggage_Click(object sender, EventArgs e)
        {
            passengersLuggage[treeView1.SelectedNode.Parent.Parent.Index].RemoveAt(treeView1.SelectedNode.Index);
            treeView1.SelectedNode.Remove();
            UpdateAll();
        }

        //***********************************************

        private void Btn_AddLuggage_Click(object sender, EventArgs e)
        {
            string tag = passengers[treeView1.SelectedNode.Index].Dni;
            if (RdoBtn_BaggageType.Checked == true)
            {
                TreeNode someBaggageNode = new TreeNode();
                someBaggageNode.Text = "Baggage || "+NUD_LuggageWeight.Value.ToString()+" kg. || Tagged";
                treeView1.Nodes[treeView1.SelectedNode.Index].Nodes[0].Nodes.Add(someBaggageNode);

                Baggage someBaggage = new Baggage(tag, LuggageType.Baggage, Convert.ToInt32(NUD_LuggageWeight.Value));
                
                passengersLuggage[treeView1.SelectedNode.Index].Add(someBaggage);                    
            }
            else if(RdoBtn_LuggageType.Checked == true)
            {
                TreeNode someLuggageNode = new TreeNode();
                someLuggageNode.Text = "Luggage || Tagged";
                treeView1.Nodes[treeView1.SelectedNode.Index].Nodes[0].Nodes.Add(someLuggageNode);

                HandLuggage someLuggage = new HandLuggage(tag, LuggageType.HandLuggage,0);

                passengersLuggage[treeView1.SelectedNode.Index].Add(someLuggage);
            }            
            UpdateAll();
        }

        //***********************************************

        private void Btn_LuggageCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //***********************************************

        private void Btn_LuggageAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //***********************************************

        private void RdoBtn_BaggageType_CheckedChanged(object sender, EventArgs e)
        {
            NUD_LuggageWeight.Enabled = true;
            if (treeView1.SelectedNode.Parent == null)
            {
                int amount = 0;
                foreach(var item in passengersLuggage[treeView1.SelectedNode.Index])
                {
                    if(item.GetType() == typeof(Baggage))
                    {
                        amount++;
                    }                    
                }

                if (amount < baggageMax)
                {
                    Btn_AddLuggage.Enabled = true;
                }
                else
                {
                    Btn_AddLuggage.Enabled = false;
                }                
            }
            UpdateAll();
        }

        //***********************************************

        private void RdoBtn_LuggageType_CheckedChanged(object sender, EventArgs e)
        {
            NUD_LuggageWeight.Enabled = false;
            if(treeView1.SelectedNode.Parent == null)
            {
                int amount = 0;
                foreach (var item in passengersLuggage[treeView1.SelectedNode.Index])
                {
                    if (item.GetType() == typeof(Luggage))
                    {
                        amount++;
                    }
                }
                if (amount < 1)
                {
                    Btn_AddLuggage.Enabled = true;
                }
                else
                {
                    Btn_AddLuggage.Enabled = false;
                }                
            }
            UpdateAll();
        }

        //------------------------------------------------------------
        //-------------------------------------------[ METHODS ]
        //------------------------------------------------------------

        private void TreeViewDrawing()
        {
            foreach(Passenger passenger in passengers)
            {
                List<Luggage> passLuggage = new List<Luggage>();
                TreeNode mainNode = new TreeNode();
                TreeNode luggage = new TreeNode();

                //------------------

                mainNode.Name = passenger.Dni;
                mainNode.Text = passenger.Name + " " + passenger.LastName + " DNI " + passenger.Dni;
                this.treeView1.Nodes.Add(mainNode);

                luggage.Name = passenger.Dni;
                luggage.Text = "Luggage";
                mainNode.Nodes.Add(luggage);

                passengersLuggage.Add(passLuggage);
            }
        }

        //***********************************************

        private void UpdateAll()
        {
            int baggage = 0;
            int handLuggage = 0;
            int totalWeight = 0;

            int index;

            if(treeView1.SelectedNode.Parent != null && treeView1.SelectedNode.Parent.Text == "Luggage")
            {
                index = treeView1.SelectedNode.Parent.Parent.Index;
            }
            else if(treeView1.SelectedNode.Parent != null)
            {
                index = treeView1.SelectedNode.Parent.Index;
            }
            else
            {
                index = treeView1.SelectedNode.Index;
            }

            foreach(Luggage item in passengersLuggage[index])
            {
                if(item is Baggage baggageGeneric)
                {
                    totalWeight += baggageGeneric.Weight;
                    baggage++;
                }
                else
                {
                    handLuggage++;
                }
            }
            Lbl_PassLuggWeight.Text = passengers[index].Name+"'s Luggage Weight:";
            Lbl_PassLuggWeightAmount.Text = totalWeight.ToString()+" Kgs.";
            Lbl_BaggageAmount.Text = baggage.ToString() + "/" + baggageMax.ToString();
            Lbl_HLuggageAmount.Text = handLuggage.ToString() +"/1";

            if (handLuggage > 0)
            {
                RdoBtn_LuggageType.Enabled = false;
                RdoBtn_LuggageType.Checked = false;
            }
            else
            {
                RdoBtn_LuggageType.Enabled = true;                
            }
            if (baggage == baggageMax)
            {
                RdoBtn_BaggageType.Enabled = false;
                RdoBtn_BaggageType.Checked = false;
            }
            else
            {
                RdoBtn_BaggageType.Enabled = true;                
            }
        }

    }
}
