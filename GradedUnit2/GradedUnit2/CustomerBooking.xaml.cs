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

namespace GradedUnit2
{
    /// <summary>
    /// Interaction logic for CustomerBooking.xaml
    /// </summary>
    public partial class CustomerBooking : Window
    {
        public CustomerBooking()
        {
            InitializeComponent();
        }

        Booking bookings = new Booking();
        VehicleDB vdb;
        List<Booking> vl;


        public void addBooking(string n, string ad, string twn, string pst, string phone)
        {
            bookings = new Booking(n, ad, twn, pst, phone); 
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            string n;
            string ad;
            string twn;
            string pst;
            string phone;

            if (this.txtName.Text == "")
            {
                txtName.Focus();
                MessageBox.Show("No name entered");
                return;
            }
            else if (this.txtAddress.Text == "")
            {
                txtAddress.Focus();
                MessageBox.Show("No Address entered");
            }
            else if (this.txtTown.Text == "")
            {
                txtTown.Focus();
                MessageBox.Show("No Town entered");
            }
            else if (this.txtPostcode.Text == "")
            {
                txtPostcode.Focus();
                MessageBox.Show("No Town entered");
            }
            else if (this.txtPhone.Text == "")
            {
                txtPhone.Focus();
                MessageBox.Show("No Phone entered");
            }
            else
            {
                Book book = new Book();
                book.Show();
                this.Close();
                return;
            }


            n = txtName.Text;
            ad = txtAddress.Text;
            twn = txtTown.Text;
            pst = txtPostcode.Text;
            phone = txtPhone.Text;

            addBooking(n, ad, twn, pst, phone);
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            return;
        }
    }
}
