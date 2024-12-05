using QuanLyKhoPJ.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyKhoPJ.View
{
    /// <summary>
    /// Interaction logic for AddEntryBill.xaml
    /// </summary>
    public partial class AddEntryBillForm : Window
    {
        private EntryBillViewModel viewModel;
        public AddEntryBillForm()
        {
            InitializeComponent();
            viewModel = new EntryBillViewModel();
            this.DataContext = viewModel;   
            this.Closing += MainWindow_Closing;

        }
            private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs  e)
        {
            
            if ( viewModel.entryBill != null)
            {
              viewModel.entryBill = new EntryBill();
            }
        }
    }
}
