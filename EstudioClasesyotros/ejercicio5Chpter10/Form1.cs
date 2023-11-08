using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5Chpter10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = PhraseLabel.Font;
            if (fontDialog1.ShowDialog() !=DialogResult.Cancel)
            {
                PhraseLabel.Font = fontDialog1.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = PhraseLabel.ForeColor;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                PhraseLabel.ForeColor = colorDialog1.Color;
            }

        }

        private void PhraselistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result="";

            for(int i=0;i < PhraselistBox.SelectedItems.Count;i++) result= PhraselistBox.SelectedItems[i].ToString();

            PhraseLabel.Text = result; 
                
        }

        private void NewPhrasebutton_Click(object sender, EventArgs e)
        {
            if (NewPhrasetextBox.Text.Trim() == "") MessageBox.Show("Do not have data try Again");
            else PhraselistBox.Items.Add(NewPhrasetextBox.Text);
         
                
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Write By Javier Navarro");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
