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

namespace S00209545_Exam_2022_OOD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>//
    /// github link: https://github.com/ClintanoP/S00209545_Exam_2022_OOD
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RentalPropertyData db = new RentalPropertyData();

            var query = from p in db.Rentals
                        orderby p.Price
                        select p;

            var allProps = query.ToList();
            lbxProperties.ItemsSource = allProps;


        }

        private void lbxProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RentalProperty rp = lbxProperties.SelectedItem as RentalProperty;

            if (rp != null) {
                tblkDescription.Text = rp.Description;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addPropertyWindow a = new addPropertyWindow();
            a.Show();
        }
    }
}
