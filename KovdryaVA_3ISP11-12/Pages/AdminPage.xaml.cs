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
using KovdryaVA_3ISP11_12.Pages;

namespace KovdryaVA_3ISP11_12.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void tb_outButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow auth = new MainWindow();
            auth.Show();
            this.Close();
        }

        private void tb_recordPatientButton_Click(object sender, RoutedEventArgs e)
        {
            RecordingPage recording = new RecordingPage();
            recording.Show();
            this.Close();
        }
    }
}
