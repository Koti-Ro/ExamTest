using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamTest.DataBase;

namespace ExamTest
{
    public class OrderContains
    {
        public ObservableCollection<Product> ListProduct;
        public OrderContains() 
        { 
            ListProduct = new ObservableCollection<Product>();
        }
    }
}
