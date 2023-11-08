using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6Chapter10
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
            
           
            if (ItemlistBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose and try Again");
            }
            else if (QuantitycomboBox.SelectedItem == null)
            {
                MessageBox.Show("Choose and try Again");
            }
            else
            {
                string var1 = "";
                string var2;
                for (int i = 0; i < ItemlistBox.SelectedItems.Count; i++)
                {
                    var1 = ItemlistBox.SelectedItems[i].ToString();
                }
                var2 = QuantitycomboBox.SelectedItem as string;
                string var3 = ("Name:\t" + var1 + "\nQuantity:\t" + var2);
                ExittextBox.Text = var3;
                ItemlistBox.ClearSelected();
                QuantitycomboBox.SelectedIndex = -1;
            }

        }


    }
}