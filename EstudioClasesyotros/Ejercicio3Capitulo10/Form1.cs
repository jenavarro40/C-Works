using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Capitulo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Valuebutton_Click(object sender, EventArgs e)
        {
            double ski;
            double googles;
            double glooves;
            double smuff;
            double clothes;
            CalcularPrecio calculo=new CalcularPrecio();
            double total;
            if (SkiescheckBox.Checked) ski = 700; else ski = 0;
            if (GooglescheckBox.Checked) googles = 120; else googles = 0;
            if (GloovescheckBox.Checked) glooves = 180; else glooves = 0;
            if (earmuffscheckBox.Checked) smuff = 90; else smuff = 0;
            if (ClothescheckBox1.Checked) clothes = 250; else clothes = 0;
            total = calculo.precioComponentes(ski, googles, glooves, smuff, clothes);
            if (NametextBox.Text.Trim() == "") MessageBox.Show("Enter Data");
            else
            {
                ValuetextBox.Text=total.ToString();
            }


            

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            ValuetextBox.Clear();
            NametextBox.Clear();
            SkiescheckBox.Checked = false;
            GooglescheckBox.Checked=false;
            GloovescheckBox.Checked=false;
            earmuffscheckBox.Checked=false;
            ClothescheckBox1.Checked=false;

        }
    }
}
