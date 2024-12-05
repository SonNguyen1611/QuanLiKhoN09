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

namespace QuanLyKhoPJ.View.ExportBill
{
    /// <summary>
    /// Interaction logic for PrintExportBillForm.xaml
    /// </summary>
    public partial class PrintExportBillForm : Window
    {
        public PrintExportBillForm()
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
            finally
            {
                this.IsEnabled = true;
            }
        }
    }

    
}
