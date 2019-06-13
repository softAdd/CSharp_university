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

        List<Product> products = new List<Product>();

        private void showProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Products.Items.Add(products[i].title + " - " + products[i].price.ToString());
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            products.Add(new Product("Лопата", 800));
            products.Add(new Product("Грабли", 420));
            products.Add(new Product("Ведро", 250));
            products.Add(new Product("Набор строительных инструментов", 3500));
            products.Add(new Product("Комплект для топки", 250));
            products.Add(new Product("Лейка", 360));
            products.Add(new Product("Упаковка пакетов (50 шт.)", 100));
            showProducts(products);
            Products.SelectedIndex = 0;
            Counter.Text = "Введите количество товара...";
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            double dis = 0;
            if ((bool)Money.IsChecked)
            {
                dis = 0;
            }
            if ((bool)Visa.IsChecked)
            {
                dis = 0.05;
            }
            if ((bool)MC.IsChecked)
            {
                dis = 0.03;
            }
            try
            {
                int.Parse(Counter.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при заказе! Проверьте введенные данные!");
                return;
            }
            int count = int.Parse(Counter.Text);
            double price = (count - count * dis) * products[Products.SelectedIndex].price;
            MessageBox.Show($"Цена вашего заказа: {price}");
        }

        private void Counter_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Counter.Text = "";
        }
    }
}
