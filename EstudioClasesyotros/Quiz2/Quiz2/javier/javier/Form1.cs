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
        Treasure treasure = new Treasure();
        int[,] trasure_array = new int[3, 3];
        int contador = 0;
        int start = 0;
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


            if (start != 1)
            {
                MessageBox.Show("Please enter Start First");

            }
            else
            {

                contador++;
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

                        if (trasure_array[x, y] == 6000)
                        {
                            button1.Text = trasure_array[0, 0].ToString();
                            button2.Text = trasure_array[0, 1].ToString();
                            button3.Text = trasure_array[0, 2].ToString();
                            button4.Text = trasure_array[1, 0].ToString();
                            button5.Text = trasure_array[1, 1].ToString();
                            button6.Text = trasure_array[1, 2].ToString();
                            button7.Text = trasure_array[2, 0].ToString();
                            button8.Text = trasure_array[2, 1].ToString();
                            button9.Text = trasure_array[2, 2].ToString();
                            MessageBox.Show("you win try " + contador + " times");
         
                            trasure_array = treasure.trasure_array();


                        }
                        else
                        {
                            if (x == 0 && y == 0) button1.Text = trasure_array[0, 0].ToString();
                            if (x == 0 && y == 1) button2.Text = trasure_array[0, 1].ToString();
                            if (x == 0 && y == 2) button3.Text = trasure_array[0, 2].ToString();
                            if (x == 1 && y == 0) button4.Text = trasure_array[1, 0].ToString();
                            if (x == 1 && y == 1) button5.Text = trasure_array[1, 1].ToString();
                            if (x == 1 && y == 2) button6.Text = trasure_array[1, 2].ToString();
                            if (x == 2 && y == 0) button7.Text = trasure_array[2, 0].ToString();
                            if (x == 2 && y == 1) button8.Text = trasure_array[2, 1].ToString();
                            if (x == 2 && y == 2) button9.Text = trasure_array[2, 2].ToString();

                           
                        }


                    }

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CoorXtextBox.Text = "";
            CoorYtextBox.Text = "";
           
            trasure_array = treasure.trasure_array();

            button1.Text = "button1";
            button2.Text = "button2";
            button3.Text = "button3";
            button4.Text = "button4";
            button5.Text = "button5";
            button6.Text = "button6";
            button7.Text = "button7";
            button8.Text = "button8";
            button9.Text = "button9";
            contador = 0;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = trasure_array[0, 0].ToString();
            button2.Text = trasure_array[0, 1].ToString();
            button3.Text = trasure_array[0, 2].ToString();
            button4.Text = trasure_array[1, 0].ToString();
            button5.Text = trasure_array[1, 1].ToString();
            button6.Text = trasure_array[1, 2].ToString();
            button7.Text = trasure_array[2, 0].ToString();
            button8.Text = trasure_array[2, 1].ToString();
            button9.Text = trasure_array[2, 2].ToString();





        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            trasure_array = treasure.trasure_array();
            start = 1;
        }
    }
}
