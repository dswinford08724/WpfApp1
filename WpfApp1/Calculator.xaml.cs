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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();

            txtDisplay.TextAlignment = TextAlignment.Right;
            txtDisplay.VerticalContentAlignment = VerticalAlignment.Center;
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains(""))
            {
                // MessageBox msg 
            }
            else
            {
                txtDisplay.Text += ((Button)sender).Content;
            }
        }
        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }
        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }
        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }
        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }
        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }
        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Content;
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
            {
               // MessageBox msg 
            } else
            {
                txtDisplay.Text += ((Button)sender).Content;
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
