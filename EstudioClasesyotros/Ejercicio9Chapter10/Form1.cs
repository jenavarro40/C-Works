using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ejercicio9Chapter10
{
    public partial class Form1 : Form
    {
        double cost = 0;
        bool processingEvent = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            
            Floorapp floor = new Floorapp();
            double Widht = floor.inputdata(WidthtextBox.Text,this);
            double Lenght= floor.inputdata(WidthtextBox.Text,this);
            double area=floor.Area(Lenght, Widht);
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            if (Widht!=0|| Lenght!=0) 
            { 
                double _area = floor.Area(Widht, Lenght);
                if (FloortabControl.SelectedTab== HardWoodtabPage)
                {
                    cost = 0;
                    Totallabel.Text = cost.ToString("C");
                    if (OakradioButton.Checked) cost = 34.95;
                    if (MapleradioButton.Checked) cost = 41.23;
                    if (WalnutradioButton.Checked) cost = 39.77;
                    if (CherryradioButton.Checked) cost = 45.27;
                    cost = cost * _area;
                    Totallabel.Text = cost.ToString("C");

                }
                if (FloortabControl.SelectedTab == LaminatetabPage)
                {
                    cost = 0;
                    Totallabel.Text = cost.ToString("C");
                    if (StandarradioButton.Checked) cost = 18.23;
                    if (SoftradioButton.Checked) cost = 16.23;
                    if (HardradioButton.Checked) cost = 22.77;
                    cost = cost * _area;
                    Totallabel.Text = cost.ToString("C");

                }
                if (FloortabControl.SelectedTab == CarpettabPage)
                {
                    cost = 0;
                    Totallabel.Text = cost.ToString("C");
                    if (ThickradioButton.Checked) cost = 22.32;
                    if (MediumradioButton.Checked) cost = 19.23;
                    if (ThinradioButton.Checked) cost = 16.42;
                    cost = cost * _area;
                    Totallabel.Text = cost.ToString("C");
                }



            }


        }
    }
}
