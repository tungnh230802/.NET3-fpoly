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

namespace Bai1_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txb_num_KeyUp(object sender, KeyEventArgs e)
        {
            if (long.TryParse(txb_num.Text, out long num))
            {
                return;
            }
            else
            {
                MessageBox.Show("vui lòng nhập số!", "thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txb_num.Text = "";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc muốn thoát!", "thoát", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if(result == MessageBoxResult.Yes) 
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter) 
            {
                binhphuong();
            }
            else if(e.Key == Key.Escape)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void Thoát_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        void binhphuong()
        {
            if (!string.IsNullOrEmpty(txb_num.Text))
            {
                txb_result.Text = (Math.Pow(double.Parse(txb_num.Text),2)).ToString();
            }
        }
        private void btn_bp_Click(object sender, RoutedEventArgs e)
        {
            binhphuong();
        }

        private void btn_lp_Click(object sender, RoutedEventArgs e)
        {
            txb_result.Text = (Math.Pow(double.Parse(txb_num.Text), 3)).ToString();
        }

        private void btn_gt_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txb_num.Text);
            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }

            txb_result.Text = answer.ToString();
        }
    }
}
