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
    /// Interaction logic for PrintEntryBillForm.xaml
    /// </summary>
    public partial class PrintEntryBillForm : Window
    {
        public PrintEntryBillForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "invoice");

                }
            }
            finally { 
                this.IsEnabled = true;
            }
        }
    }
}
