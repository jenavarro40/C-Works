using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10Chapter10
{
    public partial class Form1 : Form
    {
        double valor = 0;
        double Valor_Adicional = 0;
        double Valor_Bevarage = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Changed(object sender, EventArgs e)
        {
            valor = 0;
            Valor_Adicional = 0;
            Valor_Bevarage = 0;
            if (SizecomboBox.SelectedIndex == 0) valor = 7.5;
            else if (SizecomboBox.SelectedIndex == 1) valor = 14.95;
            else if (SizecomboBox.SelectedIndex == 2) valor = 18.99;
            else if (SizecomboBox.SelectedIndex == 3) valor = 21.45;
            else if (SizecomboBox.SelectedIndex == 4) valor = 27.99;
            if (SizecomboBox.SelectedIndex != -1)
            {
                for (int i = 0; i < TopicscheckedListBox.SelectedItems.Count; i++)
                {
                    if (TopicscheckedListBox.SelectedItems[i].ToString() != "Non Sauce-No extra charge")
                    {
                        valor = valor + 1.1;
                    }
                }

                for (int i = 0; i < OthercheckedListBox.SelectedItems.Count; i++)
                {
                    if (OthercheckedListBox.SelectedItems[i].ToString() == "Hamburger-$14")
                    {
                        Valor_Adicional += 14;
                    }
                    if (OthercheckedListBox.SelectedItems[i].ToString() == "Wings-$10.99")
                    {
                        Valor_Adicional += 10.99;
                    }
                    if (OthercheckedListBox.SelectedItems[i].ToString() == "Hot Dog-$8.95")
                    {
                        Valor_Adicional += 8.95;
                    }
                    if (OthercheckedListBox.SelectedItems[i].ToString() == "Chicken Sticks-$11")
                    {
                        Valor_Adicional += 11;
                    }

                }
                for (int i = 0; i < BevaragecheckedListBox.SelectedItems.Count; i++)
                {
                    if (BevaragecheckedListBox.SelectedItems[i].ToString() == "Coke-$2")
                    {
                        Valor_Bevarage += 2;
                    }
                    if (BevaragecheckedListBox.SelectedItems[i].ToString() == "Pepsi-$2")
                    {
                        Valor_Bevarage += 2;
                    }
                    if (BevaragecheckedListBox.SelectedItems[i].ToString() == "Beer-$3")
                    {
                        Valor_Bevarage += 3;
                    }
                }
                TotaltextBox.Text = (valor + Valor_Adicional + Valor_Bevarage).ToString();
                
            }



        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            string Adress=AdresstextBox.Text;
            string Name = NametextBox.Text;
            string email=EmailtextBox.Text;
            string phone=PhonetextBox.Text;
            double value = (valor + Valor_Adicional + Valor_Bevarage);
            tabControl1.SelectedTab = SendtabPage;
            if (NametextBox.Text == "") { OutrichTextBox.Text = "Llene datos"; }
            else
            {
                
                OutrichTextBox.Text = ("Name:\t" + Name + "\nAdress:\t" + Adress + "\nE-Mail\t" + email + "\nphone:\t" + phone + "\nValue:\t" + value);
            }

        }
    }
    
}
