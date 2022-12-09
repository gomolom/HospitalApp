using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace HospitalApp
{
    /// <summary>
    /// Логика взаимодействия для MainWnd.xaml
    /// </summary>
    public partial class MainWnd : Window
    {
        public MainWnd()
        {
            InitializeComponent();
            if(MainWindow.checker == true)
            {
                EnteredAs.Content = "Вы вошли как админ";
            }
            else
            {
                EnteredAs.Content = "Вы вошли как пользователь";
            }
        }

        private void BtnReady_Click(object sender, RoutedEventArgs e)
        {
            ChequeWnd chqWnd = new ChequeWnd();
            chqWnd.Show();
            this.Close();
        }
    }
}
