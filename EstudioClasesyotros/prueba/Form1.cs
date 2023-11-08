using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label1.ForeColor;
            if(colorDialog1.ShowDialog()!=DialogResult.Cancel) 
            { label1.ForeColor = colorDialog1.Color; }
            fontDialog1.Font= label1.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            { label1.Font = fontDialog1.Font; }
        }
    }
}
