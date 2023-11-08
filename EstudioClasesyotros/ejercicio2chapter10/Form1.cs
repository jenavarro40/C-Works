using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2chapter10
{
    public partial class Form1 : Form

    {
        int valor = 0;
        string Size = "";
        int Quantity;
        string quantity_s;
        public Form1()
        {
            InitializeComponent();
        }

        private void placeAnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseSizes.Visible=true;
            labelSize.Visible = true;
            Quantitylabel.Visible = true;
            QuantitytextBox.Visible = true;
            ChooseSizes.SelectionMode = System.Windows.Forms.SelectionMode.One;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ChooseSizes.Items.Count; i++) 
            {
                ChooseSizes.SetItemChecked(i, false);
            }
           
            QuantitytextBox.Clear();
            valor = 0;
            Size = "";
            Quantity=0;
            Orderlabel.Text = "Order";



        }



        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            valor = 0;
            PedidotabControl.SelectTab(0);
            switch (ChooseSizes.SelectedIndex)
            {
                case 0: Size = "XS"; break;
                case 1: Size = "S"; break;
                case 2: Size = "M"; break;
                case 3: Size = "L"; break;
                case 4: Size = "XL"; break;
                case 5: Size = "XXL"; break;
                default:
                    {
                        MessageBox.Show("Enter Size");
                        Size = "NoVale";
                        break;
                    }
            }

            quantity_s = QuantitytextBox.Text;
            if (int.TryParse(QuantitytextBox.Text,out Quantity)==false)
            {
                MessageBox.Show("Wrong Data Try Again");
                QuantitytextBox.Clear();
            }
            else 
            {
                if (Quantity < 1 || Quantity > 10) MessageBox.Show("Wrong Data Try Again");
                else if (Size != "NoVale")
                {
                    
                    if (Size != "XS" && Size != "XXL") valor = 16;
                    else valor = 20;
                    valor = Quantity * valor;
                    MessageBox.Show("Size: " + Size + "\nQuantity: " + quantity_s +"\nEl Valor es:" + valor);
                }
                else MessageBox.Show("Wrong Data Try Again");
            }


      

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addToCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidotabControl.SelectTab(1);
            Orderlabel.Text= ("Size: " + Size + "\nQuantity: " + quantity_s + "\nEl Valor es:" + valor);
        }
    }
}
