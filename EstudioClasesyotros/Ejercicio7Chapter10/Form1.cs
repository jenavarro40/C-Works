using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7Chapter10
{
    public partial class Form1 : Form
    {
        double value = 0;
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
                string var3="";
                for (int i = 0; i < ItemlistBox.SelectedItems.Count; i++)
                {
                    var1 = ItemlistBox.SelectedItems[i].ToString();
                }
                var2 = QuantitycomboBox.SelectedItem as string;
                if (StandarButton.Checked) var3="Standar Shipping";
                if (ThreedaysradioButton.Checked) var3 = "Three days Shipping";
                if (OverNightradioButton.Checked) var3 = "Over Night Shipping";
                string var4=value.ToString();
                string var5 = ("Name:\t" + var1 + "\nQuantity:\t" + var2 + "\n"+var3 + "\nTotal Value:\t" + var4);
                ExittextBox.Text = var5;
                ItemlistBox.ClearSelected();
                QuantitycomboBox.SelectedIndex = -1;
                StandarButton.Checked = true;
                

            }

        }
        
        private void CheckedChanged(object sender, EventArgs e)
        {
            string _items="";
            value = 0;

            for (int i = 0; i < ItemlistBox.SelectedItems.Count; i++)
            {
                _items = ItemlistBox.SelectedItems[i].ToString();
            }
            if (_items == "Full Decorative") value = value + 50;
            else if (_items == "Beaded") value = value + 45;
            else if (_items == "Pirate Design") value = value + 40;
            else if (_items == "Fringed") value = value + 25;
            else if (_items == "Leather") value = value + 80;
            else if (_items == "Plain") value = value + 20;
            string quantity_string = "0";
            quantity_string = QuantitycomboBox.SelectedItem as string;
            if(int.TryParse(quantity_string,out int quantity)) value = value * quantity;
            if (StandarButton.Checked) value = value + (value * 0.05);
            if (ThreedaysradioButton.Checked) value = value+(value * 0.07);
            if (OverNightradioButton.Checked) value = value + (value * 0.1);
            TotaltextBox.Text = value.ToString();
        }

 
    }
}

