using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string value1;
        private string value2;
        private string oper;
        private bool lockKeyBoard;
        public MainWindow()
        {
            InitializeComponent();
            value1 = "";
            value2 = "";
            oper = "";
            lockKeyBoard = true;
        }

        private void NUM_LOCK_Click(object sender, RoutedEventArgs e)
        {
            lockKeyBoard = !lockKeyBoard;
        }

        private void NUM_division_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    oper = "/";
                }
                this.NUM_result.Content = value1 + oper;
            }
        }
        private void NUM_multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    oper = "*";
                }
                this.NUM_result.Content = value1 + oper;
            }
        }

        private void NUM_7_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "7";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "7";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_8_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "8";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "8";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_9_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "9";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "9";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_4_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "4";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "4";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_5_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "5";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "5";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_6_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "6";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "6";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_1_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "1";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "1";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_2_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "2";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "2";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_3_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "3";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "3";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_0_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    value1 += "0";
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 += "0";
                    this.NUM_result.Content = value1 + oper + value2;
                }
            }
        }

        private void NUM_ENTER_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "" || value2 == "")
                {
                    this.NUM_result.Content = value1;
                }
                else if (oper == "/")
                {
                    this.NUM_result.Content = Double.Parse(value1) / Double.Parse(value2);
                    value1 = Convert.ToString(this.NUM_result.Content);

                }
                else if (oper == "*")
                {
                    this.NUM_result.Content = Double.Parse(value1) * Double.Parse(value2);
                    value1 = Convert.ToString(this.NUM_result.Content);
                }
                else if (oper == "-")
                {
                    this.NUM_result.Content = Double.Parse(value1) - Double.Parse(value2);
                    value1 = Convert.ToString(this.NUM_result.Content);
                }
                else if (oper == "+")
                {
                    this.NUM_result.Content = Double.Parse(value1) + Double.Parse(value2);
                    value1 = Convert.ToString(this.NUM_result.Content);
                }
                oper = "";
                value2 = "";
            }
        }

        private void NUM_subtraction_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    oper = "-";
                }
                this.NUM_result.Content = value1 + oper;
            }
        }

        private void NUM_addition_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    oper = "+";
                }
                this.NUM_result.Content = value1 + oper;
            }
        }

        private void NUM_dot_Click(object sender, RoutedEventArgs e)
        {
            if (lockKeyBoard)
            {
                if (oper == "")
                {
                    if (!value1.Contains("."))
                    {
                        value1 += ".";
                        this.NUM_result.Content = value1;
                    }
                }
                else
                {
                    if (!value2.Contains("."))
                    {
                        value2 += ".";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumLock)
            {
                lockKeyBoard = !lockKeyBoard;
            }
            else if (lockKeyBoard)
            {
                if (e.Key == Key.NumPad0)
                {
                    if (oper == "")
                    {
                        value1 += "0";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "0";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad1)
                {
                    if (oper == "")
                    {
                        value1 += "1";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "1";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad2)
                {
                    if (oper == "")
                    {
                        value1 += "2";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "2";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad3)
                {
                    if (oper == "")
                    {
                        value1 += "3";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "3";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad4)
                {
                    if (oper == "")
                    {
                        value1 += "4";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "4";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad5)
                {
                    if (oper == "")
                    {
                        value1 += "5";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "5";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad6)
                {
                    if (oper == "")
                    {
                        value1 += "6";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "6";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad7)
                {
                    if (oper == "")
                    {
                        value1 += "7";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "7";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad8)
                {
                    if (oper == "")
                    {
                        value1 += "8";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "8";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.NumPad9)
                {
                    if (oper == "")
                    {
                        value1 += "9";
                        this.NUM_result.Content = value1;
                    }
                    else
                    {
                        value2 += "9";
                        this.NUM_result.Content = value1 + oper + value2;
                    }
                }
                else if (e.Key == Key.Multiply)
                {
                    if (oper == "")
                    {
                        oper = "*";
                    }
                    this.NUM_result.Content = value1 + oper;
                }
                else if (e.Key == Key.Divide)
                {
                    if (oper == "")
                    {
                        oper = "/";
                    }
                    this.NUM_result.Content = value1 + oper;
                }
                else if (e.Key == Key.Add)
                {
                    if (oper == "")
                    {
                        oper = "+";
                    }
                    this.NUM_result.Content = value1 + oper;
                }
                else if (e.Key == Key.Subtract)
                {
                    if (oper == "")
                    {
                        oper = "-";
                    }
                    this.NUM_result.Content = value1 + oper;
                }else if (e.Key == Key.Enter)
                {
                    if (oper == "" || value2 == "")
                    {
                        this.NUM_result.Content = value1;
                    }
                    else if (oper == "/")
                    {
                        this.NUM_result.Content = Double.Parse(value1) / Double.Parse(value2);
                        value1 = Convert.ToString(this.NUM_result.Content);

                    }
                    else if (oper == "*")
                    {
                        this.NUM_result.Content = Double.Parse(value1) * Double.Parse(value2);
                        value1 = Convert.ToString(this.NUM_result.Content);
                    }
                    else if (oper == "-")
                    {
                        this.NUM_result.Content = Double.Parse(value1) - Double.Parse(value2);
                        value1 = Convert.ToString(this.NUM_result.Content);
                    }
                    else if (oper == "+")
                    {
                        this.NUM_result.Content = Double.Parse(value1) + Double.Parse(value2);
                        value1 = Convert.ToString(this.NUM_result.Content);
                    }
                    oper = "";
                    value2 = "";
                }
            }
        }
    }
}
