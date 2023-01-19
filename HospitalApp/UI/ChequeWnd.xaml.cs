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
using HospitalApp;
using Microsoft.Win32;
using System.IO;

namespace HospitalApp
{
    /// <summary>
    /// Interaction logic for ChequeWnd.xaml
    /// </summary>
    public partial class ChequeWnd : Window
    {
        public ChequeWnd()
        {
            InitializeComponent();
            this.MinHeight = 390;
            this.MinWidth = 570;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, Cheque.Text);

            MessageBox.Show("Файл успешно сохранен", "HospitalApp");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cheque.Text = $"Пользователю {MainWindow.email}\nназначен приём у:\n{MainWnd.Service} {MainWnd.Doctor}\nна {MainWnd.Date} ";
            Cheque.Text = Cheque.Text.Replace("\n", Environment.NewLine);
        }
    }
}
