using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Capitulo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuShow_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text.Trim() != "" || textBoxEmail.Text.Trim() != "" || textBoxAdress.Text.Trim() != "")
            {
                string name_s = textBoxName.Text;
                string email_s = textBoxEmail.Text;
                string address_s = textBoxAdress.Text;
                MessageBox.Show("Name: " + name_s + "\n" + "E-Mail: " + email_s + "\n" + "Address: " + address_s);
            }
            else MessageBox.Show("Please ingress Data");

        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxAdress.Clear();  

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program by Javier Navarro\nDouglas College\n300368873");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}