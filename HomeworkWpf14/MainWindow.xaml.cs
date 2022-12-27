using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HomeworkWpf14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
            {
                new Product()
                {
                    Name = "Бананы",
                    Price = 70.4,
                    Image = "Data/Banana.png",
                    Category = Categories.Food
                },
                new Product()
                {
                    Name = "Яблоки",
                    Price = 51,
                    Image = "Data/Apple.png",
                    Category = Categories.Food
                },
                new Product()
                {
                    Name = "Хлеб",
                    Price = 30,
                    Image = "Data/Bread.png",
                    Category = Categories.Food
                },
                new Product()
                {
                    Name = "Холодильник",
                    Price = 18000,
                    Image = "Data/Fridge.png",
                    Category = Categories.Appliances
                },
                new Product()
                {
                    Name = "Микроволновка",
                    Price = 3000,
                    Image = "Data/Microwave.png",
                    Category = Categories.Appliances
                },
                new Product()
                {
                    Name = "Креветки",
                    Price = 2000,
                    Image = "Data/Prawn.png",
                    Category = Categories.Food
                }
            };
            ListBox.ItemsSource = products;

        }
    }
}
