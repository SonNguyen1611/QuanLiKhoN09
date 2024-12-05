using LiveCharts;
using LiveCharts.Wpf;
using QuanLyKhoPJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKhoPJ.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        private int _sumQuantityProduct { get; set; }
        public int sumQuantityProduct
        {
            get
            {
                return _sumQuantityProduct;
            }
            set
            {
                _sumQuantityProduct = value;
                OnPropertyChanged();
            }
        }
        private int _totalEntryBillInDay { get; set; }
        public int totalEntryBillInDay
        {
            get
            {
                return _totalEntryBillInDay;
            }
            set
            {
                _totalEntryBillInDay = value;
                OnPropertyChanged();
            }
        }
        private int _totalExportBillInDay { get; set; }
        public int totalExportBillInDay
        {
            get
            {
                return _totalExportBillInDay;
            }
            set
            {
                _totalExportBillInDay = value;
                OnPropertyChanged();
            }
        }
        private List<int> _ListEntryBillAllCa { get; set; }
        public List<int> ListEntryBillAllCa
        {
            get
            {
                return _ListEntryBillAllCa;
            }
            set
            {
                _ListEntryBillAllCa = value;
                OnPropertyChanged();
            }
        }
        private List<int> _ListExportBillAllCa { get; set; }
        public List<int> ListExportBillAllCa
        {
            get
            {
                return _ListExportBillAllCa;
            }
            set
            {
                _ListExportBillAllCa = value;
                OnPropertyChanged();
            }
        }
        public SeriesCollection _SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection
        {
            get
            {
                return _SeriesCollection;
            }
            set
            {
                _SeriesCollection = value;
                OnPropertyChanged();
            }
        }
        public string[] _Labels { get; set; }
        public string[] Labels
        {
            get
            {
                return _Labels;
            }
            set
            {
                _Labels = value;
                OnPropertyChanged();
            }
        }
        public Func<double, string> Formatter { get; set; }


        public ICommand ReloadCom { get; set; }

        public HomeViewModel() {
            returnSumQuantity();
            returnTotalEntry();
            returnTotalExport();
            returnEntryInAllCa();
            returnExportInAllCa();
            returnChart();

            

            ReloadCom = new RelayCommand(reload);
        }

        // TÍNH TÔNG SỔ LƯỢNG SẢN PHẨM

        public void returnSumQuantity()
        {
            sumQuantityProduct = _db.Products.Sum(p => p.Quantity);
        }

        // tính số đơn nhập trong ngày
        public void returnTotalEntry()
        {
            totalEntryBillInDay = _db.EntryBills.Where(e => e.TransactionDate.Date == DateTime.Today).Count();
        }
        // tính số đơn xuất trong ngày
        public void returnTotalExport()
        {
            totalExportBillInDay = _db.ExportBills.Where(e => e.TransactionDate.Date == DateTime.Today).Count();
        }

        public void reload(object obj)
        {
            using var db = new QuanLiKhoDbContext();
            sumQuantityProduct = db.Products.Sum(p => p.Quantity);
            totalEntryBillInDay = db.EntryBills.Where(e => e.TransactionDate.Date == DateTime.Today).Count();
            totalExportBillInDay = db.ExportBills.Where(e => e.TransactionDate.Date == DateTime.Today).Count();
            returnEntryInAllCa();
            returnExportInAllCa();
            returnChart();


        }


        public void returnEntryInAllCa()
        {
            using var db = new QuanLiKhoDbContext();
            var startTimeCa1 = DateTime.Today.AddHours(8).AddMinutes(30);  
            var endTimeCa1 = DateTime.Today.AddHours(10).AddMinutes(30);
            var startTimeCa2 = DateTime.Today.AddHours(13).AddMinutes(30);  
            var endTimeCa2 = DateTime.Today.AddHours(17).AddMinutes(30);
            var startTimeCa3 = DateTime.Today.AddHours(17).AddMinutes(30); 
            var endTimeCa3 = DateTime.Today.AddHours(23);
            var toTalBillCa1 = db.EntryBills.Where(eb => eb.TransactionDate >= startTimeCa1 && eb.TransactionDate <= endTimeCa1).Count();
            var toTalBillCa2 = db.EntryBills.Where(eb => eb.TransactionDate >= startTimeCa2 && eb.TransactionDate < endTimeCa2).Count(); 
            var toTalBillCa3 = db.EntryBills.Where(eb => eb.TransactionDate >= startTimeCa3 && eb.TransactionDate <= endTimeCa3).Count();

            ListEntryBillAllCa = new List<int>{ toTalBillCa1, toTalBillCa2, toTalBillCa3 };
             
        }
        public void returnExportInAllCa()
        {
            using var db = new QuanLiKhoDbContext();
            var startTimeCa1 = DateTime.Today.AddHours(8).AddMinutes(30);
            var endTimeCa1 = DateTime.Today.AddHours(10).AddMinutes(30);
            var startTimeCa2 = DateTime.Today.AddHours(13).AddMinutes(30);
            var endTimeCa2 = DateTime.Today.AddHours(17).AddMinutes(30);
            var startTimeCa3 = DateTime.Today.AddHours(17).AddMinutes(30);
            var endTimeCa3 = DateTime.Today.AddHours(23);
            var toTalBillCa1 = db.ExportBills.Where(eb => eb.TransactionDate >= startTimeCa1 && eb.TransactionDate <= endTimeCa1).Count();
            var toTalBillCa2 = db.ExportBills.Where(eb => eb.TransactionDate >= startTimeCa2 && eb.TransactionDate < endTimeCa2).Count();
            var toTalBillCa3 = db.ExportBills.Where(eb => eb.TransactionDate >= startTimeCa3 && eb.TransactionDate <= endTimeCa3).Count();

            ListExportBillAllCa = new List<int> { toTalBillCa1, toTalBillCa2, toTalBillCa3 };

        }
        public void returnChart()
        {
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Phiếu Nhập",
                    Values = new ChartValues<int> {
                        ListEntryBillAllCa[0] , ListEntryBillAllCa[1], ListEntryBillAllCa[2]
                    }
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Phiếu xuất",
                Values = new ChartValues<int> { ListExportBillAllCa[0], ListExportBillAllCa[1], ListExportBillAllCa[2] }
            });


            Labels = new[] { "Ca1(8-12h)", "Ca2(1r-5r)", "Ca3(5r-11h)" };
            Formatter = value => value.ToString("N");
        }









    }
}
