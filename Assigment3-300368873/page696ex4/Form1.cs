using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page696ex4
{
    public partial class Form1 : Form

    {
        double Value=0;
        string mensaje;
        string mensaje1;
        double implement = 0;
        double Valuefinal = 0;
        string Val;
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void allradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FutbolradioButton.Checked == true)
            {
                SportpictureBox.Image = Properties.Resources.Messi;
                Value = 50;
                implement = 63.5;
                mensaje = ("Require uniform plus soccer cleats\nCost is $ " + Value + "\nImplement cost: $ " + implement + "\nGo to inscription");
            }
            else if (BikeradioButton.Checked == true)
            {
                SportpictureBox.Image = Properties.Resources.Ciclicmo;
                Value = 70;
                implement = 1135.7;
                mensaje = ("Require uniform plus profesional bike\nCost is $ " + Value + "\nImplement cost: $ " + implement + "\nGo to inscription");
            }
            else if (BasketradioButton.Checked == true)
            {
                SportpictureBox.Image = Properties.Resources.Baloncesto;
                Value = 40;
                implement = 80;
                mensaje = ("Require uniform plus tennis \nCost is $ " + Value + "\nImplement cost: $ " + implement + "\nGo to inscription");
            }
            else if (TaekradioButton.Checked == true)
            {
                SportpictureBox.Image = Properties.Resources.taekondow;
                Value = 60;
                implement = 42.5;
                mensaje = ("Require uniform\nCost is $ " + Value + "\nImplement cost: $ " + implement + "\nGo to inscription");
            }
            else if (TenisradioButton.Checked == true)
            {
                SportpictureBox.Image = Properties.Resources.tenis;
                Value = 90;
                implement = 170.8;
                mensaje = ("Require tennis racket\nCost is $ " + Value + "\nImplement cost: $ " + implement + "\nGo to inscription");
            }
            else 
            { 
                Value = 0;
                SportpictureBox.Image = Properties.Resources.sports;
            }

            if (mensaje1 != mensaje)
            {
                MessageBox.Show(mensaje);
                mensaje1 = mensaje;
            }
            if(impcheckBox.Checked == true) 
            {
                Valuefinal = Value + implement;
            }
            else { Valuefinal = Value; }
            Val = "$ " + Valuefinal.ToString("f2");
            Vallabel.Text= Val;


        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (Value != 0)
            {
                if (string.IsNullOrWhiteSpace(NametextBox.Text)) { MessageBox.Show("Please ingress data"); }
                else { MessageBox.Show("Name: "+ NametextBox.Text+"\nFinal Cost is " + Val); }
            }
            else MessageBox.Show("Please ingress sport");
        }

        private void cleanbutton_Click(object sender, EventArgs e)
        {
            foreach(Control control in sportgroupBox.Controls)
            {
                RadioButton radioButton = control as RadioButton;
                radioButton.Checked = false;
            }
            Vallabel.Text = "$ 0";
            NametextBox.Clear();
            impcheckBox.Checked=false;
            tabControl1.SelectedTab = tabPage1;

        }
    }
}
