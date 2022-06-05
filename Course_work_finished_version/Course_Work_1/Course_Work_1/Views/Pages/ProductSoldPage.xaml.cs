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
    /// Логика взаимодействия для ProductSoldPage.xaml
    /// </summary>
    public partial class ProductSoldPage : Page
    {
        private DiskShop _diskShop;

        public event Action? OnDataChangedEvent;
        public ProductSoldPage(DiskShop diskShop)
        {
            _diskShop = diskShop;

            InitializeComponent();

            resultDataGrid.ItemsSource = _diskShop.GetSoldFiles();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((File)resultDataGrid.SelectedItem).GetInfo());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            _diskShop.RemoveDiskByFile((File)resultDataGrid.SelectedItem);
            OnDataChangedEvent?.Invoke();
            resultDataGrid.ItemsSource = null;
            resultDataGrid.ItemsSource = _diskShop.GetSoldFiles();
        }
    }
}
