using Course_Work_1.Services;
using Course_Work_1.Services.Abstract;
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

namespace Course_Work_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DiskShop _diskShop;
        private IDataSaver _dataSaver;

        public MainWindow()
        {
            InitializeComponent();

            _dataSaver = new DataSaver("disk_data.json");
            _diskShop = new DiskShop(_dataSaver.LoadData());

            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void Button_Click_List(object sender, RoutedEventArgs e) 
        {
            var page = new ProductListPage(_diskShop);
            page.OnDataChangedEvent += SaveData;
            MainFrame.Navigate(page);
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            var page = new AddingProductPage(_diskShop);
            page.OnDataChangedEvent += SaveData;
            MainFrame.Navigate(page);
        }

        private void Button_Click_Rented_Products(object sender, RoutedEventArgs e) 
        {
            var page = new RentalProductsPage(_diskShop);
            page.OnDataChangedEvent += SaveData;
            MainFrame.Navigate(page);
        }

        private void Button_Click_Product_Sold(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductSoldPage(_diskShop));
        }

        private void SaveData()
        {
            _dataSaver.SaveData(_diskShop.DiskList);
        }
    }
}
