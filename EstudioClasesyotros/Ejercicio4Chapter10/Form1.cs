using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Chapter10
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (KidNametextBox.Text.Trim()=="")
            {
                MessageBox.Show("Data Incomplete Try Again");
            }
            else
            {
                if (FutbolcheckBox.Checked) { MessageBox.Show("Name:"+ KidNametextBox.Text+"\nSport: Futbol"); }
                else if (BasketcheckBox.Checked) { MessageBox.Show("Name:" + KidNametextBox.Text + "\nSport: Basketbal"); }
                else if (SwimmingcheckBox.Checked) { MessageBox.Show("Name:" + KidNametextBox.Text + "\nSport: Swimming"); }
                else if (BaseballcheckBox.Checked) { MessageBox.Show("Name:" + KidNametextBox.Text + "\nSport: Baseball"); }
                else if (TaekondocheckBox.Checked) { MessageBox.Show("Name:" + KidNametextBox.Text + "\nSport: Taekondo"); }
                else MessageBox.Show("Data Incomplete Try Again");
            }
            KidNametextBox.Clear();
            FutbolcheckBox.Checked = false;
            BasketcheckBox.Checked = false;
            SwimmingcheckBox.Checked = false;
            BaseballcheckBox.Checked = false;
            TaekondocheckBox.Checked = false;
            SportPictureBox.Image = null;
        }

        private void FutbolcheckBox_CheckedChanged(object sender, EventArgs e)
        {


            BasketcheckBox.Checked = false;
            SwimmingcheckBox.Checked = false;
            BaseballcheckBox.Checked = false;
            TaekondocheckBox.Checked = false;
            if (FutbolcheckBox.Checked)
            {
                SportPictureBox.Image = Properties.Resources.Ajiaco;
            }
                



        }

        private void BasketcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            FutbolcheckBox.Checked = false;
            SwimmingcheckBox.Checked = false;
            BaseballcheckBox.Checked = false;
            TaekondocheckBox.Checked = false;
            SportPictureBox.Image = Properties.Resources.CartagenaMuralla;
        }

        private void SwimmingcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            FutbolcheckBox.Checked = false;
            BasketcheckBox.Checked = false;
            BaseballcheckBox.Checked = false;
            TaekondocheckBox.Checked = false;
            SportPictureBox.Image = Properties.Resources.musica;
        }

        private void BaseballcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            FutbolcheckBox.Checked = false;
            BasketcheckBox.Checked = false;
            SwimmingcheckBox.Checked = false;
            TaekondocheckBox.Checked = false;
            SportPictureBox.Image = Properties.Resources.people;
        }

        private void TaekondocheckBox_CheckedChanged(object sender, EventArgs e)
        {

            FutbolcheckBox.Checked = false;
            BasketcheckBox.Checked = false;
            SwimmingcheckBox.Checked = false;
            BaseballcheckBox.Checked = false;
            SportPictureBox.Image = Properties.Resources.turisticos;

        }
    }
}
