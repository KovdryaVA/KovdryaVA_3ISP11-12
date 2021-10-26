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
    /// Логика взаимодействия для DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Window
    {
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow auth = new MainWindow();
            auth.Show();
            this.Close();
        }
    }
}
