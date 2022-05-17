using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace S00209545_Exam_2022_OOD
{
    /// <summary>
    /// Interaction logic for addPropertyWindow.xaml
    /// </summary>
    public partial class addPropertyWindow : Window
    {
        public addPropertyWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            RentalPropertyData db = new RentalPropertyData();
            RentalProperty newProp = new RentalProperty();

            if (cbxTypeOfRental.SelectedItem != null && tbxLocation.Text != null && tbxPrice != null) {
                newProp.TypeOfRental = ((RentalType)cbxTypeOfRental.SelectedItem);
                newProp.Location = tbxLocation.Text;
                newProp.Price = int.Parse(tbxPrice.Text);

                db.Rentals.Add(newProp);
                db.SaveChanges();

            }
            
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxTypeOfRental.Items.Add(RentalType.House);
            cbxTypeOfRental.Items.Add(RentalType.Flat);
            cbxTypeOfRental.Items.Add(RentalType.Share);
        }
    }
}
