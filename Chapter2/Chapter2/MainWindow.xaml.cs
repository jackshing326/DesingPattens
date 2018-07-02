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
using Cash;


namespace Chapter2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        CashSuper _CashSuper = null;
        double total = 0.0d;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Price.Text = "";
            Amount.Text = "";
            Messageall.Text = "";
           
        }

        private void Comfirm_Click(object sender, RoutedEventArgs e)
        {
        
            /*
            _CashSuper = CashFactoy.createCashAccept(SelectType.Text);         
            double TotalPrice = _CashSuper.acceptCash(double.Parse(Price.Text) * double.Parse(Amount.Text));
            total = total + TotalPrice;
            Messageall.Text += "單價:" + Price.Text + " 數量:" + Amount.Text + " " + SelectType.Text +"\r\n";
            TotalText.Content ="總計 : "+ total.ToString();
            */

            CashContext _CashContext = new CashContext(SelectType.Text);
            double TotalPrice = _CashContext.GetResult(double.Parse(Price.Text) * double.Parse(Amount.Text));
            total = total + TotalPrice;
            Messageall.Text += "單價:" + Price.Text + " 數量:" + Amount.Text + " " + SelectType.Text + "\r\n";
            TotalText.Content = "總計 : " + total.ToString();

        }
    }
}
