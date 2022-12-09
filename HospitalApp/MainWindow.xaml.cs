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

namespace HospitalApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool checker;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (EmailBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                checker = true;
            }
            else
            {
                checker = false;
            }
            MainWnd mainwnd = new MainWnd();
            mainwnd.Show();
            this.Close();
            
        }

        private void Checker_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Объект в разработке");
        }
    }
}
