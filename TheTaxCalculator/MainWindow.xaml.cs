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

namespace TheTaxCalculator
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double totalValue = 0;
            double totalAddedTax = 0;

            try
            {
                int itemValueInput = Convert.ToInt32(ValueInput.Text);

                if (NormalRate.IsSelected)
                {
                    totalAddedTax = (itemValueInput * 25 / 100);
                    totalValue = (itemValueInput + totalAddedTax);

                    TotalValue.Text = Math.Round(totalValue, 2).ToString() ;
                    TotalAddedTax.Text = totalAddedTax + "   " + "25 %";
                }
                if (FoodStuffRate.IsSelected)
                {
                    totalAddedTax += (itemValueInput * 15 / 100);
                    totalValue += (itemValueInput + totalAddedTax);

                    TotalValue.Text = Math.Round(totalValue, 2).ToString() ;
                    TotalAddedTax.Text = totalAddedTax + "   " + "15 %";
                }
                if (OtherRate.IsSelected)
                {
                    totalAddedTax += (itemValueInput * 12 / 100);
                    totalValue += (itemValueInput + totalValue);

                    TotalValue.Text = Math.Round(totalValue, 2).ToString() ;
                    TotalAddedTax.Text = totalAddedTax + "   " + "12 %";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount in item price and tax rate");
            }
        }
    }
}
