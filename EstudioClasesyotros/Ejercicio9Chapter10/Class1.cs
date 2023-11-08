using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9Chapter10
{
    internal class Floorapp
    {
        public double inputdata(string _inputdata, Form1 form)
        {
            double outdata=0;
            if(double.TryParse(_inputdata,out outdata)==false)
            {
                form.DataErroneaLabel.Visible = true;
                form.DataErroneaLabel.Text = "Try Again wrong data";
            }
            else form.DataErroneaLabel.Visible = false;
            return outdata;
        }
        public double Area(double Lenght, double Widht) 
        {
            double Area = Lenght * Widht;
            return Area;
        }
    }
}
