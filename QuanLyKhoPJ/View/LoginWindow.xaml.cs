using Microsoft.EntityFrameworkCore;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View.Manage;
using QuanLyKhoPJ.ViewModel;
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

namespace QuanLyKhoPJ.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public LoginWindow()
        {
            InitializeComponent();
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordBox.Password;
            using var db = new QuanLiKhoDbContext();    
            var userLogin = db.Users.Where(u => u.UserName == username && u.Password == password).Include(u => u.Role).FirstOrDefault();
            
            if (userLogin != null)
            {
                UserSeesion.CurrentUser = userLogin;
                UserViewModel newUserViewModel = new UserViewModel();
                if (userLogin.Role.RoleName == "Quản Lý")
                {
                    var adminHomePage = new AdminHome();
                    adminHomePage.Show();
                    
                    this.Close();
                }
                else if (userLogin.Role.RoleName == "Nhân Viên")
                {
                   
                    var mainHome = new MainWindow();
                    mainHome.Show();                    
                    this.Close();

                }
            }else
            {
                MessageBox.Show("Thông tin đăng nhập sai", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            
        }
    }
}
