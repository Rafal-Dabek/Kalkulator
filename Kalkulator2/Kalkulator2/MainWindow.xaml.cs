using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;






namespace Kalkulator2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double FirstNumber;
        string Operation;
        bool is_comma_pressed = false;
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {






            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "1";
            }
            else
            {
                result.Text = result.Text + "1";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "2";
            }
            else
            {
                result.Text = result.Text + "2";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "3";
            }
            else
            {
                result.Text = result.Text + "3";
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "4";
            }
            else
            {
                result.Text = result.Text + "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "5";
            }
            else
            {
                result.Text = result.Text + "5";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "8";
            }
            else
            {
                result.Text = result.Text + "8";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "7";
            }
            else
            {
                result.Text = result.Text + "7";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "9";
            }
            else
            {
                result.Text = result.Text + "9";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "6";
            }
            else
            {
                result.Text = result.Text + "6";
            }
        }



        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "0";
            }

            else result.Text = result.Text + "0";

        }

        private void bchange_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Double.Parse(result.Text);
            FirstNumber *= -1;
            result.Text = FirstNumber.ToString();
        }


        private void bubdo_Click(object sender, RoutedEventArgs e)      //usuwa ostanią cyfre
        {


            if (result.Text != string.Empty)
            {
                int txtlength = result.Text.Length;
                if (txtlength != 1)
                {
                    if (result.Text.EndsWith(",")) is_comma_pressed = false;
                    result.Text = result.Text.Remove(txtlength - 1);


                }
                else
                {
                    result.Text = 0.ToString();
                }
            }




        }

        private void bclear_Click(object sender, RoutedEventArgs e)   //czyści wyświetlacz
        {
            result.Text = "0";
            is_comma_pressed = false;
        }









        private void badd(object sender, RoutedEventArgs e)
        {
            

            FirstNumber = Convert.ToDouble(result.Text);
            result.Text = "0";
            Operation = "+";
            is_comma_pressed = false;
        }



        private void bsub(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            result.Text = "0";
            Operation = "-";
            is_comma_pressed = false;
        }

        private void bmult(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            result.Text = "0";
            Operation = "*";
            is_comma_pressed = false;
        }







        private void b_coma(object sender, RoutedEventArgs e)
        {
            if (is_comma_pressed == false)
            {
                result.Text = result.Text + ",";
                is_comma_pressed = true;
            }
        }

        private void b_div(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            result.Text = "0";
            Operation = "/";
            is_comma_pressed = false;
        }

        private void b_equal(object sender, RoutedEventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(result.Text);

            if (Operation == "+")
            {
                
                Result = (FirstNumber + SecondNumber);
                result.Text = Convert.ToString(Result);
                FirstNumber = Result;
                //result.Text = Result.ToString();
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                result.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    
                    result.Text = "Nie można dzielić przez zero!";
                    Console.Read();
                    
                    
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    result.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        

        

       


       

        private void textBox1_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "0";
                }


                else result.Text = "0";
                
                

            }
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "1";
                }
                else
                {
                    result.Text = result.Text + "1";
                }

            }
            if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "2";
                }
                else
                {
                    result.Text = result.Text + "2";
                }

            }
            if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "3";
                }
                else
                {
                    result.Text = result.Text + "3";
                }

            }
            if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "4";
                }
                else
                {
                    result.Text = result.Text + "4";
                }

            }
            if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "5";
                }
                else
                {
                    result.Text = result.Text + "5";
                }

            }
            if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "6";
                }
                else
                {
                    result.Text = result.Text + "6";
                }

            }
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "7";
                }
                else
                {
                    result.Text = result.Text + "7";
                }

            }

            if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "8";
                }
                else
                {
                    result.Text = result.Text + "8";
                }

            }

            if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {

                if (result.Text == "0" && result.Text != null)
                {
                    result.Text = "9";
                }
                else
                {
                    result.Text = result.Text + "9";
                }

            }
            if (e.Key == Key.Multiply)
            {

                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "0";
                Operation = "*";
                is_comma_pressed = false;

            }
            if (e.Key == Key.Add)
            {

                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "0";
                Operation = "+";
                is_comma_pressed = false;

            }
            if (e.Key == Key.Subtract)
            {

                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "0";
                Operation = "-";
                is_comma_pressed = false;

            }
            if (e.Key == Key.Divide)
            {

                FirstNumber = Convert.ToDouble(result.Text);
                result.Text = "0";
                Operation = "/";
                is_comma_pressed = false;

            }
            

          

        }
    }
}