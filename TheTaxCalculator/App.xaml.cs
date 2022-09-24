using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace TheTaxCalculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
          
        }
    }








    //public string Convert(double amount, GoodsValue goodsValues)
    //{
    //    if (goodsValues == GoodsValue.NormalRate)
    //        return (amount * 25 * 100).ToString("0.##");

    //    if (goodsValues == GoodsValue.Foodstuffs)
    //        return (amount * 15 * 100).ToString("0.##");

    //    if (goodsValues == GoodsValue.OtherTax)
    //        return (amount * 12 * 100).ToString("0.##");

    //    throw new ArgumentOutOfRangeException("goodsValues");
    //}

    //public enum GoodsValue /*Or DistanceType*/
    //{
    //    NormalRate,
    //    Foodstuffs,
    //    OtherTax,
    //}

}
