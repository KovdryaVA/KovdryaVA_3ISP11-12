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
using KovdryaVA_3ISP11_12.Pages;

namespace KovdryaVA_3ISP11_12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void bt_authButton(object sender, RoutedEventArgs e)
        {
            var userAuthData = DB.BDClass.Context.User.Where(i => i.Login == tb_login.Text && i.Password == tb_password.Text).FirstOrDefault();

            if (userAuthData != null)
            {
                ClassHelper.UserClass.person = userAuthData;
                switch (userAuthData.RoleId)
                {
                    case 1: MessageBox.Show(userAuthData.Role.RoleName);
                        AdminPage admin = new AdminPage();
                        admin.Show();
                        this.Close();
                        break;
                    
                    case 2: MessageBox.Show(userAuthData.Role.RoleName); break;

                    case 3: MessageBox.Show(userAuthData.Role.RoleName);
                        DoctorPage doctor = new DoctorPage();
                        doctor.Show();
                        this.Close();
                        break;

                    default: break;

                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
