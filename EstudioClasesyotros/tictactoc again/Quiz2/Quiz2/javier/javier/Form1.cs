using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace javier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure=new Treasure();
            int[,] calculate=treasure.inicializar_cuadricula();
            calculate[0, 0] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[0, 1] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[0, 2] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[1, 0] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[1, 1] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[1, 2] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[2, 0] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[2, 1] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] calculate = treasure.inicializar_cuadricula();
            calculate[2, 2] = 1;
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {
                    calculate[x, y] = 1;
                    int cal = treasure.DrillDistance(calculate);

                    MessageBox.Show("Distance is:" + cal.ToString());
                }
            }
        }

        private void Trybutton_Click(object sender, EventArgs e)
        {

            int x;
            int y;
            Treasure treasure = new Treasure();
            int[,] trasure_array = treasure.trasure_array();
            if (int.TryParse(CoorXtextBox.Text, out x) == false || int.TryParse(CoorYtextBox.Text, out y) == false)
            {
                MessageBox.Show("Try Again");
                CoorXtextBox.Text = "";
            }
            else
            {
                if ((x < 0 || x > 2) || (y < 0 || y > 2))
                {
                    MessageBox.Show("Try Again");
                    CoorXtextBox.Text = "";
                }

                else
                {

                    if (trasure_array[x,y]==9)
                    {
                        MessageBox.Show("you win");

                    }
                    else 
                    {
                        MessageBox.Show("you Loose Try Again");
                    }
                       
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CoorXtextBox.Text = "";
            CoorYtextBox.Text = "";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }
    }
}
