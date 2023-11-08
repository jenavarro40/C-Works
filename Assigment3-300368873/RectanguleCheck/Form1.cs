using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectanguleCheck
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            Rectangule rect = new Rectangule();
            double lenght;
            double widht;
            string area;
            string perimeter;
            string diagonal;
            if (double.TryParse(LenghttextBox.Text, out lenght)==false) 
            {
                MessageBox.Show("Wrong Lenght Data Try Again");
                LenghttextBox.Text = "";
                
            }
            else if (lenght < 1 )
            {
                MessageBox.Show("Data less than 0 Try Again");
                LenghttextBox.Text = "";
                
            }

            if (double.TryParse(WidhttextBox.Text, out widht) == false)
            {
                MessageBox.Show("Wrong Widht Data Try Again");
                WidhttextBox.Text = "";

            }
            else if (widht < 1)
            {
                MessageBox.Show("Data less than 0 Try Again");
                WidhttextBox.Text = "";
            }


            else
            {
                (perimeter, area, diagonal) =rect.calculate(lenght,widht);
                Perimeterlabel.Visible= true;
                Perimeterlabel.Text = perimeter;
                Arealabel.Visible= true;
                Arealabel.Text = area;
                Diagonallabel.Visible= true;
                Diagonallabel.Text = diagonal;

                if(lenght== widht)
                {
                    MessageBox.Show("Perimeter: " + perimeter + "\nArea: " + area + "\nDiagonal: " + diagonal + "\nis a square lenght and widht are equals");
                }
                else MessageBox.Show("Perimeter: " + perimeter + "\nArea: " + area + "\nDiagonal: " + diagonal);

            }
      


        }
    }
}
