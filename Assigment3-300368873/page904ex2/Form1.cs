using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace page904ex2
{    
    public partial class Form1 : Form
    {
        
        string filename;
        System.IO.StreamReader input;
        List<string> numbersstr = new List<string>();
        List<double> numbers = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void readfile(object sender, EventArgs e)
        {
            
            filename=FiletextBox.Text;
            numbers.Clear();
            RdBox.Items.Clear();
            OrganizeBox.Items.Clear ();

            try
            {
                input = new System.IO.StreamReader(filename);
                string strfile;
                while ((strfile = input.ReadLine()) != null)
                {
                    RdBox.Items.Add(strfile);
                    numbers.Add(double.Parse(strfile));

                }
                input.Close();
                numbers.Sort();
                double avg = 0;
                foreach (double item in numbers)
                {
                    avg = avg + item;
                    OrganizeBox.Items.Add(item.ToString());
                }
                avg = avg / numbers.Count;
                Avglabel.Text = avg.ToString("f2");
                Maxlabel.Text = numbers[numbers.Count - 1].ToString("f2");
                Minlabel.Text = numbers[0].ToString("f2");
                Proccesslabel.Text = numbers.Count.ToString();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The file not exist : " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error in read file: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }
        }
        
    

        private void Form1_Load(object sender, EventArgs e)
        {
            filename = System.IO.Directory.GetCurrentDirectory() + "\\filenumber.txt";
            FiletextBox.Text = filename;
            
        }


    }
}
