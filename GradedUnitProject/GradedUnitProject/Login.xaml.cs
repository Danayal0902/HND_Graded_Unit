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

namespace GradedUnitProject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private VehicleDB vehicles;
        int attempts = 0;



        public Login()
        {

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Password;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both a username and password");
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

        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
            MainWindow booking = new MainWindow();
            booking.Show();
            this.Close();
        }
    }
}
