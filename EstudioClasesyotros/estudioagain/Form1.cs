using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudioagain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = comboBox1.Text;
            label1.Text = s;
            string var="";
            checkedListBox1.SelectionMode = SelectionMode.MultiExtended;
            foreach (string value in checkedListBox1.SelectedItems)
                var = var + value;
            label1.Text = var;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
