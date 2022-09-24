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
            decimal total = 0;

            if (ValueInput != null)
            {
                try
                {
                    decimal itemValueInput = Decimal.Parse(ValueInput.Text);
                    if (NormalRate.IsSelected)
                    {
                        total += (itemValueInput * 25 * 100).ToString("0.##");
                        TotalValue.Text = String.Format("{0:C}", total);
                        ValueAddedTax.Text = String.Format("{0:C}", total);
                    }
                    if (FoodStuffRate.IsSelected)
                    {
                        (itemValue * 15 * 100).ToString("0.##");
                        TotalValue.Text = String.Format("{0:C}", total);

                    }
                    if (OtherRate.IsSelected)
                    {
                        (itemValue * 12 * 100).ToString("0.##");
                        TotalValue.Text = String.Format("{0:C}", total);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid amount in item price and tax rate");
                }
            }
        }
    }
}
