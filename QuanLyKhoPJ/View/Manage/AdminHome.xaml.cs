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

namespace QuanLyKhoPJ.View.Manage
{
    /// <summary>
    /// Interaction logic for AdminHom.xaml
    /// </summary>
    public partial class AdminHome : Window
    {
        public AdminHome()
        {
            InitializeComponent();
            this.Loaded += AdminHome_Loaded;
            

        }
        private void AdminHome_Loaded(object sender, RoutedEventArgs e)
        {
           
            if (TabItemUserVM.DataContext is UserViewModel userVM)
            {
               userVM.reload();
            }
        }

    }
}
