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

namespace GradedUnitProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Booking bookings = new Booking();
        VehicleDB vdb;
        List<Booking> vl;

        public MainWindow()
        {
            vdb = VehicleDB.Instance;
            vl = vdb.Bookings;
            InitializeComponent();
            txtName.Focus();
        }

        public void addBooking(string n, string ad, string twn, string pst, string phone)
        {
            bookings = new Booking(n, ad, twn, pst, phone); 
        }

        private void btnBooking_Click(object sender, RoutedEventArgs e)
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

            n = txtName.Text;
            ad = txtAddress.Text;
            twn = txtTown.Text;
            pst = txtPostcode.Text;
            phone = txtPhone.Text;

            addBooking(n, ad, twn, pst, phone);
        }
    }
}
            

     

        
