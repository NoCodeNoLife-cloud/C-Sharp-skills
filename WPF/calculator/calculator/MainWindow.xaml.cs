﻿using System;
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
            value1 = "0";
            value2 = "0";
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 7);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 7);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 8);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 8);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 9);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 9);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 4);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 4);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 5);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 5);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 6);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 6);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 1);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 1);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 2);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 2);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 3);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 3);
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
                    value1 = Convert.ToString(Double.Parse(value1) * 10 + 0);
                    this.NUM_result.Content = value1;
                }
                else
                {
                    value2 = Convert.ToString(Double.Parse(value2) * 10 + 0);
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
                    this.NUM_result.Content = Double.Parse(value1) / Double.Parse( value2);
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
                value2 = "0";
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
                        value1+=".";
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
    }
}
