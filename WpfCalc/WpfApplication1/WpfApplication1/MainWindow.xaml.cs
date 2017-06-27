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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Result;
        private string Operation = "";
        private double MemoryPlus = 0;
        private string Number1;
        private string Number2;
        private bool flagRes = false;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MC_Click(Object sender, RoutedEventArgs e)
        {
            MemoryPlus = 0;
        }

        private void MR_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                if (MemoryPlus == 0)
                {
                    Number1 = "";
                }
                else
                {
                    Number1 = MemoryPlus.ToString();
                    TextBox.Text = Number1.ToString();
                }
            }
            else
            {
                if (MemoryPlus == 0)
                {
                    Number2 = "";
                }
                else
                {
                    Number2 = MemoryPlus.ToString();
                    TextBox.Text = Number2.ToString();
                }
            }
        }

        private void MPlus_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                try { MemoryPlus += double.Parse(Number1); }
                catch { MessageBox.Show("Число добавлено до пам`яті"); }
            }
            else if (flagRes == false)
            {
                try { MemoryPlus += double.Parse(Number2); }
                catch { MessageBox.Show("Число добавлено до пам`яті"); }
            }

            if (flagRes == true)
            {
                try { MemoryPlus += double.Parse(Result); }
                catch { MessageBox.Show("Число добавлено до пам`яті"); }
            }
        }

        private void Minus_Click(Object sender, RoutedEventArgs e)
        {
            ConvertResNumber();
            Operation = "-"; TextBox.Text = "";
        }

        private void Division_Click(Object sender, RoutedEventArgs e)
        {
            ConvertResNumber();
            Operation = "/"; TextBox.Text = "";
        }

        private void Multiplication_Click(Object sender, RoutedEventArgs e)
        {
            ConvertResNumber();
            Operation = "*"; TextBox.Text = "";
        }

        private void C_Click(Object sender, RoutedEventArgs e)
        {
            Number1 = "";
            Number2 = "";
            TextBox.Text = "";
            Result = "";
            Operation = "";
            flagRes = false;
        }

        private void Plus_Click(Object sender, RoutedEventArgs e)
        {
            ConvertResNumber();
            Operation = "+"; TextBox.Text = "";
        }

        private void MMinus_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                try { MemoryPlus -= double.Parse(Number1); }
                catch { MessageBox.Show("Число віднято з пам`яті"); }
            }
            else if (flagRes == false)
            {
                try { MemoryPlus -= double.Parse(Number2); }
                catch { MessageBox.Show("Число віднято з пам`яті"); }
            }
            if (flagRes == true)
            {
                try { MemoryPlus -= double.Parse(Result); }
                catch { MessageBox.Show("Число віднято з пам`яті"); }
            }
        }


        private void One_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "1";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "1";
                TextBox.Text = Number2;
            }
        }


        private void Two_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "2";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "2";
                TextBox.Text = Number2;
            }
        }

        private void Three_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "3";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "3";
                TextBox.Text = Number2;
            }
        }

        private void Four_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "4";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "4";
                TextBox.Text = Number2;
            }
        }

        private void Five_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "5";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "5";
                TextBox.Text = Number2;
            }
        }

        private void Six_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "6";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "6";
                TextBox.Text = Number2;
            }
        }

        private void Seven_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "7";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "7";
                TextBox.Text += Number2;
            }
        }

        private void Eight_Click(Object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "8";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "8";
                TextBox.Text = Number2;
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "9";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "9";
                TextBox.Text = Number2;
            }
        }


        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += "0";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += "0";
                TextBox.Text = Number2;
            }
        }


        private void BtnPoint_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 += ",";
                TextBox.Text = Number1;
            }
            else
            {
                Number2 += ",";
                TextBox.Text = Number2;
            }
        }

        private void RavnoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "+")
            {
                Result = (double.Parse(Number1) + double.Parse(Number2)).ToString();
                TextBox.Text = Result;
                flagRes = true;
            }
            if (Operation == "-")
            {
                Result = (double.Parse(Number1) - double.Parse(Number2)).ToString();
                TextBox.Text = Result;
                flagRes = true;
            }
            if (Operation == "*")
            {
                Result = (double.Parse(Number1) * double.Parse(Number2)).ToString();
                TextBox.Text = Result;
                flagRes = true;
            }
            if (Operation == "/")
            {
                Result = (double.Parse(Number1) / double.Parse(Number2)).ToString();
                TextBox.Text = Result;
                flagRes = true;
            }
        }

        private void ConvertResNumber()
        {
            if (flagRes == true && Operation == "+" || flagRes == true && Operation == "*" ||
                flagRes == true && Operation == "-" || flagRes == true && Operation == "/")
            {
                Number2 = "";
                Number1 = Result;
            }
        }


    }
}
