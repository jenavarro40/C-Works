using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page455ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            string val;
            MessageBoxshow boxshow = new MessageBoxshow();
            val = boxshow.Showdata();
            label1.Visible = true;
            label1.Text = val;
            MessageBox.Show(val);
        }


    }
}

