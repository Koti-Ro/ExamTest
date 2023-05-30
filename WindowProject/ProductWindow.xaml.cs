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
using ExamTest.WindowProject;

namespace ExamTest.WindowProject
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        Entities Context;
        OrderContains OrderList;
        public ProductWindow()
        {
            InitializeComponent();
            Context = new Entities();
            OrderList = new OrderContains();
            ProductDataGrid.ItemsSource=Context.Product.ToList();
            if (OrderList.ListProduct.Count == 0) 
            {
                ShowOrderBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void SearchTxb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            List<Product> ProductListSearch=Context.Product.ToList();
            ProductListSearch=ProductListSearch.Where(x=>x.NameProduct.ToLower()
                .Contains(SearchTxb.Text.ToLower())).ToList();
            if (ProductListSearch.Count == 0)
            {
                MessageBox.Show("Поиск не дал результатов!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else ProductDataGrid.ItemsSource = ProductListSearch;
        }

        private void ShowOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow OrderWin = new OrderWindow(Context, OrderList);
            OrderWin.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Product CurrentProduct = ProductDataGrid.SelectedItem as Product;
            if (CurrentProduct == null)
            {
                MessageBox.Show("Выберите товар!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Product FindProduct = OrderList.ListProduct.FirstOrDefault(x=>x.ProductID==CurrentProduct.ProductID);
                if (FindProduct == null)
                {
                    CurrentProduct.CountOrderProduct = 1;
                    OrderList.ListProduct.Add(CurrentProduct);
                }
                else
                {
                    foreach (var item in OrderList.ListProduct)
                    {
                        if (item.ProductID==CurrentProduct.ProductID)
                        {
                            item.CountOrderProduct++;
                        }
                    }
                }
                ShowOrderBtn.Visibility = Visibility.Visible;
            }
        }
    }
}
