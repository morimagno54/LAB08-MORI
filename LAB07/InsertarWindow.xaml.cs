using Business;
using Entity;
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
using System.Windows.Shapes;

namespace LAB07
{
    /// <summary>
    /// Lógica de interacción para InsertarWindow.xaml
    /// </summary>
    public partial class InsertarWindow : Window
    {
        public InsertarWindow()
        {
            InitializeComponent();
        }

        private void btn1Click(object sender, RoutedEventArgs e)
        {
            string customerName = tb_Name.Text;
            string customerAddress = tb_Address.Text;
            string customerPhone = tb_Phone.Text;

            Customer customer = new Customer(customerName, customerAddress, customerPhone);

            try
            {
                CustomerBusiness customerBusiness = new CustomerBusiness();
                customerBusiness.InsertCustomer(customer);

                MessageBox.Show("Customer inserted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
