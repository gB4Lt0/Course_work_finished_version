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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class AddingProductPage : Page
    {
        DiskShop _diskShop;
        public event Action? OnDataChangedEvent;

        public AddingProductPage(DiskShop diskShop)
        {
            InitializeComponent();
            _diskShop = diskShop;
        }

        private void comboBoxTypeOfFile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxTypeOfFile.SelectedIndex == 0)
            {
                lableGenre.Content = "Game category";
                comBoxGenre.ItemsSource = Enum.GetNames(typeof(GameCategories));
            }

            else if (comboBoxTypeOfFile.SelectedIndex == 1)
            {
                lableGenre.Content = "Video ganer";
                comBoxGenre.ItemsSource = Enum.GetNames(typeof(TypesOfVideos));
            }

            else if (comboBoxTypeOfFile.SelectedIndex == 2)
            {
                lableGenre.Content = "Type of program";
                comBoxGenre.ItemsSource = Enum.GetNames(typeof(TypesOfPrograms));
            }
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            TypesOfFiles typesOfFile = (TypesOfFiles)comboBoxTypeOfFile.SelectedIndex;

            File? file = null;

            if (comboBoxTypeOfFile.SelectedIndex == 0)
            {
                file = new GameFile(Guid.NewGuid(), name, description, price, typesOfFile, (GameCategories)comBoxGenre.SelectedIndex);
            }

            else if (comboBoxTypeOfFile.SelectedIndex == 1)
            {
                file = new VideoFile(Guid.NewGuid(), name, description, price, typesOfFile, (TypesOfVideos)comBoxGenre.SelectedIndex);
            }

            else if (comboBoxTypeOfFile.SelectedIndex == 2)
            {
                file = new ProgramFile(Guid.NewGuid(), name,description, price, typesOfFile, (TypesOfPrograms)comBoxGenre.SelectedIndex);
            }

            if (file == null)
                throw new NullReferenceException();

            _diskShop.AddDisk(new Disk(RentalStatus.OnSale, file));
            OnDataChangedEvent?.Invoke();
        }
    }
}
