using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstudioExamen
{
    public partial class Form1 : Form

    {
        string filename;
        System.IO.StreamReader input;
        System.IO.StreamWriter output;
        List<string> numbersstr = new List<string>();
        List<double> numbers = new List<double>();
        double Value = 0;
        string[] values_piano;
        string[,] result2;
        int ID;
        string brand;
        string serie;
        double price;
        int year;
        int downp;
        int months;
        string piano;
        double payment;
        public Form1()
        {
            InitializeComponent();
        }

        private void load_info(object sender, EventArgs e)
        {
            filename = "pianos.txt";
            numbers.Clear();
            numbersstr.Clear();
            datalistBox.Items.Clear();
            string[] names;
            int name;


            try
            {
                input = new System.IO.StreamReader(filename);
                string strfile;
                string result1 = "Code" + "      " + "Brand" + "      " + "Model" + "      " + "Series" + "      " + "Year";
                datalistBox.Items.Add(result1);

                while ((strfile = input.ReadLine()) != null)
                {
                    names = strfile.Split(',');
                    string result = "";

                    for (int i = 0; i < names.Length; i++)
                    {
                        result = result + names[i] + "    ";
                    }
                    result1 = names[0] + "      " + names[1] + "      " + names[2] + "      " + names[3] + "      " + names[4];

                    numbersstr.Add(strfile);
                    datalistBox.Items.Add(result1);

                }
                input.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file not exist : " + ex.Message);
            }



        }

        private void datalistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (datalistBox.SelectedIndex == 1) Value = 10900;
            else if (datalistBox.SelectedIndex == 2) Value = 13900;
            else if (datalistBox.SelectedIndex == 3) Value = 7900;
            else if (datalistBox.SelectedIndex == 4) Value = 37900;
            else if (datalistBox.SelectedIndex == 5) Value = 47900;
            else Value = 0;
            if (datalistBox.SelectedIndex > 0 && datalistBox.SelectedIndex < 6)
            {
                piano = numbersstr[datalistBox.SelectedIndex - 1];
                string[] names = piano.Split(',');
                Variables2 var2 = new Variables2(names);
                (ID, brand, serie, price, year) = var2.pianos();
                valuelabel.Text = "$ " + price;
            }
            else
            {
                valuelabel.Text = "$ 0";

            }
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            if (datalistBox.SelectedIndex > 0 && datalistBox.SelectedIndex < 6)
            {


                if (int.TryParse(DowntextBox.Text, out downp) == false)
                {
                    MessageBox.Show("Ingress a correct Value");
                }
                else
                {
                    if (LoancomboBox.SelectedIndex == 0)
                    {
                        months = 1;

                        Mortage mor = new Mortage(price, downp, months);
                        payment = mor.mortagecal();
                        MessageBox.Show("your piano:\n" + piano + "\n" + "Your payment:\n" + payment);
                    }
                    else if (LoancomboBox.SelectedIndex == 1)
                    {
                        months = 2;
                        Mortage mor = new Mortage(price, downp, months);
                        payment = mor.mortagecal();
                        MessageBox.Show("your piano:\n" + piano + "\n" + "Your payment:\n" + payment);

                    }
                    else MessageBox.Show("Ingress a correct Value");

                }
            }
            else MessageBox.Show("Ingress a correct Value");
        }

        private void PalceOrderbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DowntextBox.Text, out downp) == false)
            {
                MessageBox.Show("Ingress a correct Value");
            }
            else if (LoancomboBox.SelectedIndex < 0 && LoancomboBox.SelectedIndex > 1)
            {
                MessageBox.Show("Ingress a correct Value");
            }
            else if (datalistBox.SelectedIndex < 1 || datalistBox.SelectedIndex > 5)
            {
                MessageBox.Show("Ingress a correct Value");
            }
            else
            {


                string filenamerecord = "compra.txt";
                try
                {
                    output = new System.IO.StreamWriter(filenamerecord);
                    output.WriteLine("your piano:\n" + piano + "\n" + "Your payment:\n" + payment);
                    for (int i = 0; i < (months * 12); i++)
                    {
                        output.WriteLine("month " + i + "payment:" + payment);
                    }
                    MessageBox.Show("done");
                    output.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file  : " + ex.Message);
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            DowntextBox.Text = "";
            LoancomboBox.SelectedIndex = -1;
            datalistBox.SelectedIndex = -1;


        }
    }
}
