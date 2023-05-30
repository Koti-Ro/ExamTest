using ExamTest.DataBase;
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
using System.Windows.Shapes;

namespace ExamTest.WindowProject
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        Entities Context;
        OrderContains OrderList;
        public OrderWindow(Entities Context, OrderContains OrderList)
        {
            InitializeComponent();
            this.Context = Context;
            this.OrderList = OrderList;
            OrderDataGrid.ItemsSource=OrderList.ListProduct.ToList();
            SumOrderLable.Content = SumOrder() + " руб.";
            DiscountOrderLable.Content = DiscountOrder() + " руб.";
        }
        public string SumOrder()
        {
            decimal SumOrder = 0;
            foreach (var item in OrderList.ListProduct)
            {
                var SumDiscount = (item.Cost * item.Discount) / 100;
                SumOrder += Convert.ToDecimal((item.Cost - SumDiscount) * item.CountOrderProduct);
            }
            return SumOrder.ToString();
        }
        public string DiscountOrder()
        {
            decimal DiscountOrder = 0;
            foreach (var item in OrderList.ListProduct)
            {
                var SumDiscount = (item.Cost * item.Discount) / 100;
                DiscountOrder += Convert.ToDecimal(SumDiscount * item.CountOrderProduct);
            }
            return DiscountOrder.ToString();
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CouponBtn_Click(object sender, RoutedEventArgs e)
        {
            Random Rand = new Random();
            string RandCode = Rand.Next(0, 10).ToString() + Rand.Next(0, 10).ToString() + Rand.Next(0, 10).ToString();
            MessageBox.Show("Ваш код получения: " + RandCode, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
