using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using HospitalApp;

namespace HospitalApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string email;
        public static bool checker;
        public MainWindow()
        {
            InitializeComponent();
            PasswordBox.Visibility = Visibility.Hidden;
            this.MinHeight = 350;
            this.MinWidth = 600;


        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (EmailBox.Text == "")
            {
                MessageBox.Show("Чтобы продолжить необходимо ввести имя пользователя и пароль");
            }
            else
            {
                if (EmailBox.Text == "admin" & (PasswordBox.Text == "admin" || PasswordBoxPass.Password == "admin"))
                {
                    checker = true;
                    MainWnd mainwnd = new MainWnd();
                    mainwnd.Show();
                    this.Close();
                    email = EmailBox.Text;
                }
                else if (EmailBox.Text == "user" & (PasswordBox.Text == "user" || PasswordBoxPass.Password == "user"))
                {
                    checker = false;
                    MainWnd mainwnd = new MainWnd();
                    mainwnd.Show();
                    this.Close();
                    email = EmailBox.Text;
                }
                else
                {
                    MessageBox.Show("Имя пользователя либо пароль введены неверно");
                }

            }

        }

        private void Checker_Clicked(object sender, RoutedEventArgs e)
        {
                PasswordBox.Text = PasswordBoxPass.Password;
                PasswordBox.Visibility = Visibility.Visible;
                PasswordBoxPass.Visibility = Visibility.Hidden;
        }
        private void Checker_UnClicked(object sender, RoutedEventArgs e)
        {
            PasswordBoxPass.Password = PasswordBox.Text;
            PasswordBoxPass.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Hidden;
        }

    }
}
