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

namespace GradedUnit2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VehicleDB vehicles;
        int attempts = 0;

        public MainWindow()
        {
            vehicles = VehicleDB.Instance;
            attempts = 0;
            InitializeComponent();
            txtUsername.Focus();
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = pwdPassword.Password;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both a username and password");
            }
            else
            {
                if (username == "")
                {
                    MessageBox.Show("Please enter a username");
                }
                else
                {
                    if (password == "")
                    {
                        MessageBox.Show("Please enter a password");
                    }
                    else
                    {
                        if (attempts == 3)
                        {
                            btnLogin.IsEnabled = false;
                            MessageBox.Show("No more attempts left");
                            return;
                        }
                        else
                        {
                            if (username == "admin" && password == "password")
                            {
                                WindowAdmin admin = new WindowAdmin();
                                admin.Show();
                                this.Close();
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void btnCust_Click(object sender, RoutedEventArgs e)
        {
            CustomerBooking booking = new CustomerBooking();
            booking.Show();
            this.Close();
        }


    }
}
