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

namespace lab_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
            
            products.Add(new Product("Перекрой шубы", 10000));
            products.Add(new Product("Подшив низа джинс", 450));
            products.Add(new Product("Пошив мужских брюк", 2500));
            products.Add(new Product("Пошив платья из трикотажа", 3500));
            products.Add(new Product("Ремонт обуви", 500));
            products.Add(new Product("Пошив изделий из кожи", 1200));
            products.Add(new Product("Пошив рубашки", 2000));
            showProducts(products);
            Diff.Items.Add("Сложность 1");
            Diff.Items.Add("Сложность 2");
            Diff.Items.Add("Сложность 3");
            Products.SelectedIndex = 0;
        }

        public struct Product
        {
            public string title;
            public int price;

            public Product(string title, int price)
            {
                this.title = title;
                this.price = price;
            }
        }

        private void showProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Products.Items.Add(products[i].title + " - " + products[i].price.ToString());
            }
        }

        private void make_order(object sender, RoutedEventArgs e)
        {
            double coef = 0;
            switch(Diff.SelectedIndex)
            {
                case 0:
                    coef = 0;
                    break;
                case 1:
                    coef = 0.2;
                    break;
                case 2:
                    coef = 0.3;
                    break;
                default:
                    coef = 0;
                    break;
            }
            double price = products[Products.SelectedIndex].price + products[Products.SelectedIndex].price * coef;
            if ((bool)Home.IsChecked)
            {
                price += 250;
            }
            if ((bool)Speed.IsChecked)
            {
                price += (products[Products.SelectedIndex].price + products[Products.SelectedIndex].price * coef) * 0.05;
            }
            MessageBox.Show(price.ToString());
        }
    }
}
