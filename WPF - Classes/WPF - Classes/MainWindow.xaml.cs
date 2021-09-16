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

namespace WPF___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double price;

            if (string.IsNullOrEmpty(txtMan.Text) == true)
            {
                MessageBox.Show("You did not enter in a manufactruer");
            }

            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                MessageBox.Show("You did not enter in a name");
            }

            if (string.IsNullOrEmpty(txtImg.Text) == true)
            {
                MessageBox.Show("You did not enter in a url");
            }

            if (double.TryParse(txtPrice.Text, out price) == false)
            {
                MessageBox.Show("You did not enter in a valid number");
            }

            Toy t1 = new Toy()
            {
                Manufacturer = txtMan.Text,
                Name = txtName.Text,
                Price = price,
                Image = txtImg.Text,
            };

            ListToy.Items.Add(t1);
            txtMan.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtImg.Clear();
        }

        private void ListToy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)ListToy.SelectedItem;
            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);
            imgBox.Source = img;
            MessageBox.Show($"{selectedToy.GetAisle()}");
        }
    }
}
