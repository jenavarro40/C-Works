using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa_de_clase
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            double initialcost = 30;
            if(EasyRouteBasiccheckBox.Checked) initialcost += 20;
            if (EasyRouteMediumcheckBox.Checked) initialcost += 25;
            if (EasyRouteAdavancedcheckBox.Checked) initialcost += 30;
            if (AdavancedRouteMediumcheckBox.Checked) initialcost += 35;
            if (AdavancedRouteAdvancedcheckBox.Checked) initialcost += 40;
            if (MediumradioButton.Checked) initialcost -= 10;
            if (Advancedradio.Checked) initialcost -= 20;
            CosttextBox.Text=initialcost.ToString();


        }
    }
}




        
    

