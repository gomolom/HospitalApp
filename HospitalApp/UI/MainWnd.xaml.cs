using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HospitalApp;

namespace HospitalApp
{
    /// <summary>
    /// Логика взаимодействия для MainWnd.xaml
    /// </summary>
    public partial class MainWnd : Window
    {
        public static string choiceSer;
        public static string choiceDoc;
        public static string Service;
        public static string Doctor;
        public static string Date;
        public MainWnd()
        {
            InitializeComponent();
            this.MinHeight = 450;
            this.MinWidth = 800;
            if(MainWindow.checker == true)
            {
                EnteredAs.Content = "Вы вошли как админ";
            }
            else
            {
                EnteredAs.Content = "Вы вошли как пользователь";
            }
            Type.Items.Add("Терапевт");
            Type.Items.Add("Окулист");
            Type.Items.Add("Аллерголог");
        }

        private void BtnReady_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Type.SelectedItem == "" || Doc.SelectedItem == "" || Dat.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture) == "")
                {
                    MessageBox.Show("Необходимо выбрать и услугу и врача и дату!");
                }
                else
                {
                    Service = Type.SelectedItem.ToString();
                    Doctor = Doc.SelectedItem.ToString();
                    Date = Dat.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    ChequeWnd chqWnd = new ChequeWnd();
                    chqWnd.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Необходимо указать и услугу, и врача, и дату приёма ");
            }
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow manWnd = new MainWindow();
            manWnd.Show();
            this.Close();
        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Doc.Items.Clear();
            if (Type.SelectedItem == "Терапевт")
            {
                string[] linesForTher = File.ReadAllLines(@"..\..\Service\Therapist.txt");
                foreach (var line in linesForTher)
                {
                    Doc.Items.Add(line);
                }
            }
            if (Type.SelectedItem == "Аллерголог")
            {
                string[] linesForTher = File.ReadAllLines(@"..\..\Service\Allergist.txt");
                foreach (var line in linesForTher)
                {
                    Doc.Items.Add(line);
                }
            }
            if (Type.SelectedItem == "Окулист")
            {
                string[] linesForTher = File.ReadAllLines(@"..\..\Service\Ocullist.txt");
                foreach (var line in linesForTher)
                {
                    Doc.Items.Add(line);
                }
            }
        }
    }
}
