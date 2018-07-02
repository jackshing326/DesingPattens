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
using Operators;

namespace Chapter1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
                {
            try
            {
                double num1 = 0;
                double num2 = 0;

                Operator _OP = null; 
                
                if (!double.TryParse(TB_Number1.Text, out num1))
                {
                    MessageBox.Show("Input Error Number1 :" + TB_Number1.Text, "錯誤");
                    return;
                }

                if (!double.TryParse(TB_Number2.Text, out num2))
                {
                    MessageBox.Show("Input Error Number2 :" + TB_Number2.Text, "錯誤");
                    return;
                }

                string _Operators = Operators.Text;
                if (_Operators.Trim() == "")
                {
                    MessageBox.Show("Select Error Operators :" + Operators.Text, "錯誤");
                    return;
                }
                else
                {                
                    if (_Operators == "+")
                    {
                        _OP = new OperationAdd();
                    }
                    else if (_Operators == "-")
                    {
                        _OP = new OperationSub();
                    }
                    else if (_Operators == "*")
                    {
                        _OP = new OperationMul();
                    }
                    else if (_Operators == "/")
                    {
                        _OP = new OperationDiv();
                    }
                }
                _OP.NumberA = num1;
                _OP.NumberB = num2;
                double result=_OP.GetResult();
                Result_Cal.Text = result.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("The ex is: " + ex.ToString());
            }
        }


    }

}
