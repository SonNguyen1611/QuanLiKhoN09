using LiveCharts.Wpf;
using LiveCharts;
using QuanLyKhoPJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace QuanLyKhoPJ.ViewModel
{
    public class AdminStatisticalViewModel :BaseViewModel
    {
        private int _totalProductInto { get; set; }
        public int totalProductInto
        {
            get
            {
                return _totalProductInto;
            }
            set
            {
                _totalProductInto = value;
                OnPropertyChanged();

            }
        }
        private int _totalProductOutto { get; set; }
        public int totalProductOutto
        {
            get
            {
                return _totalProductOutto;
            }
            set
            {
                _totalProductOutto = value;
                OnPropertyChanged();

            }
        }
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
        private float _profit { get; set; }
        public float profit
        {
            get
            {
                return _profit;
            }
            set
            {
                _profit = value;
                OnPropertyChanged();
            }
        }
       
        private List<int> _totalProductInCa { get; set; }
        public List<int> totalProductIntoCa
        {
            get
            {
                return _totalProductInCa;
            }
            set
            {
                _totalProductInCa = value;
                OnPropertyChanged();
            }
        }
        private List<int> _totalProductOutoCa { get; set; }
        public List<int> totalProductOutoCa
        {
            get
            {
                return _totalProductOutoCa;
            }
            set
            {
                _totalProductOutoCa = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> products
        {
            get { return _products; }
            set
            {
                _products = value;
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
        public AdminStatisticalViewModel()
        {
            returnTotalProductInto();
            returnTotalProductOuto();
            returnSumQuantity();
            returnProfit();
            returnProductIntoAllCa();
            returnProductOutAllCa();
            getAllProduct();
            returnChart();
            returnPieChart1();
            returnPieChart2();


            ReloadCom = new RelayCommand(reload);
        }

        // tính tổng số hàng nhập trong ngày
        public void returnTotalProductInto()
        {
            var listEntryBill = _db.EntryBills.Where(eb => eb.TransactionDate.Date == DateTime.Today).ToList();
            totalProductInto = 0;
            foreach (var entryBill in listEntryBill) {
                totalProductInto += entryBill.CountProduct;
            }
        }
        // tính tổng số hàng xuất trong ngày
        public void returnTotalProductOuto()
        {
            var listExportBill = _db.ExportBills.Where(eb => eb.TransactionDate.Date == DateTime.Today).ToList();
            totalProductOutto = 0;
            foreach (var exportBill in listExportBill)
            {
                totalProductOutto += exportBill.CountProduct;
            }
        }
        // tồn kho
       

        public void returnSumQuantity()
        {
            sumQuantityProduct = _db.Products.Sum(p => p.Quantity);
        }
        // tính lợi nhuận ( tổng giá xuất - tổng giá nhập)
        public void returnProfit()
        {
            var listEntryBill = _db.EntryBills.Where(eb => eb.TransactionDate.Date == DateTime.Today).ToList();
            var listExportBill = _db.ExportBills.Where(eb => eb.TransactionDate.Date == DateTime.Today).ToList();
            float sumPriceEntry = 0;
            decimal sumPriceExport = 0;
            foreach (var entryBill in listEntryBill)
            {
              sumPriceEntry += entryBill.EntryBillPrice;
            }
            foreach (var exportBill in listExportBill)
            {
                sumPriceExport += exportBill.ExportBillPrice;
            }

            profit = (float)sumPriceExport - sumPriceEntry;

        }
        // reload
        public void reload(object obj)
        {
            using var db = new QuanLiKhoDbContext();
            sumQuantityProduct = db.Products.Sum(p => p.Quantity);
            returnTotalProductOuto();
            returnTotalProductInto();
            returnProductIntoAllCa();
            returnProductOutAllCa();
            getAllProduct();
            returnProfit();
            returnChart();
            returnPieChart1();
            returnPieChart2();
        }
        //hàng nhâp mỗi ca làm việc
        public void returnProductIntoAllCa()
        {
            using var db = new QuanLiKhoDbContext();
            var startTimeCa1 = DateTime.Today.AddHours(8).AddMinutes(30);
            var endTimeCa1 = DateTime.Today.AddHours(10).AddMinutes(30);
            var startTimeCa2 = DateTime.Today.AddHours(13).AddMinutes(30);
            var endTimeCa2 = DateTime.Today.AddHours(17).AddMinutes(30);
            var startTimeCa3 = DateTime.Today.AddHours(17).AddMinutes(30);
            var endTimeCa3 = DateTime.Today.AddHours(23);
            var listBillCa1 = db.EntryBills.Where(eb => eb.TransactionDate >= startTimeCa1 && eb.TransactionDate <= endTimeCa1).ToList();
            var listBillCa2 = db.EntryBills.Where(eb => eb.TransactionDate >= startTimeCa2 && eb.TransactionDate < endTimeCa2).ToList();
            var listBillCa3 = db.EntryBills.Where(eb => eb.TransactionDate >= startTimeCa3 && eb.TransactionDate <= endTimeCa3).ToList();
            var totalProductCa1 = 0;
            var totalProductCa2 = 0;
            var totalProductCa3 = 0;

            foreach ( var bill in listBillCa1)
            {
                totalProductCa1 = (int)(totalProductCa1 + bill.CountProduct);
            }

            foreach (var bill in listBillCa2)
            {
                totalProductCa2 = (int)(totalProductCa2 + bill.CountProduct);
            }
            foreach (var bill in listBillCa3)
            {
                totalProductCa3 = (int)(totalProductCa3 + bill.CountProduct); ;
            }

            totalProductIntoCa = new List<int> { totalProductCa1, totalProductCa2, totalProductCa3 };
        }
        // hàng xuất mỗi ca làm việc 
        public void returnProductOutAllCa()
        {
            using var db = new QuanLiKhoDbContext();
            var startTimeCa1 = DateTime.Today.AddHours(8).AddMinutes(30);
            var endTimeCa1 = DateTime.Today.AddHours(10).AddMinutes(30);
            var startTimeCa2 = DateTime.Today.AddHours(13).AddMinutes(30);
            var endTimeCa2 = DateTime.Today.AddHours(17).AddMinutes(30);
            var startTimeCa3 = DateTime.Today.AddHours(17).AddMinutes(30);
            var endTimeCa3 = DateTime.Today.AddHours(23);
            var listBillCa1 = db.ExportBills.Where(eb => eb.TransactionDate >= startTimeCa1 && eb.TransactionDate <= endTimeCa1).ToList();
            var listBillCa2 = db.ExportBills.Where(eb => eb.TransactionDate >= startTimeCa2 && eb.TransactionDate < endTimeCa2).ToList();
            var listBillCa3 = db.ExportBills.Where(eb => eb.TransactionDate >= startTimeCa3 && eb.TransactionDate <= endTimeCa3).ToList();
            var totalProductCa1 = 0;
            var totalProductCa2 = 0;
            var totalProductCa3 = 0;

            foreach (var bill in listBillCa1)
            {
                totalProductCa1 = (int)(totalProductCa1 + bill.CountProduct);
            }

            foreach (var bill in listBillCa2)
            {
                totalProductCa2 = (int)(totalProductCa2 + bill.CountProduct);
            }
            foreach (var bill in listBillCa3)
            {
                totalProductCa3 = (int)(totalProductCa3 + bill.CountProduct); ;
            }

            _totalProductOutoCa = new List<int> { totalProductCa1, totalProductCa2, totalProductCa3 };
        }
        // hàm vẽ biểu đồ
        public void returnChart()
        {
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Lượng hàng nhập",
                    Values = new ChartValues<int> {
                        totalProductIntoCa[0] , totalProductIntoCa[1], totalProductIntoCa[2]
                    }
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Lượng hàng xuất",
                Values = new ChartValues<int> { totalProductOutoCa[0], totalProductOutoCa[1], totalProductOutoCa[2] }
            });


            Labels = new[] { "Ca1(8-12h)", "Ca2(1r-5r)", "Ca3(5r-11h)" };
            Formatter = value => value.ToString("N");
        }
        // lấy lên toàn bộ products 
        public void getAllProduct()
        {
            using var db = new QuanLiKhoDbContext();
           List<Product> ListProducts = db.Products.ToList() ;
           products = new ObservableCollection<Product>(ListProducts) ;
        }
        // đoạn code vẽ pie chat 1
        public Func<ChartPoint, string> PointLabel1 { get; set; }
        public SeriesCollection _PieSeriesCollection1 { get; set; }
       
        public SeriesCollection PieSeriesCollection1
        {
            get
            {
                return _PieSeriesCollection1;
            }
            set
            {
                _PieSeriesCollection1 = value;
                OnPropertyChanged();
            }
        }
        public void returnPieChart1()
        {
            PointLabel1 = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            PieSeriesCollection1 = new SeriesCollection();
            foreach (var product in products)
            {
                PieSeriesCollection1.Add(new PieSeries
                {
                    Title = product.ProductName,
                    Values = new ChartValues<int> { product.Quantity },
                    DataLabels = true,
                    LabelPoint = PointLabel1
                });
            }
        }
        
        
        

        // đoạn code vẽ pie chart 2 
        public Func<ChartPoint, string> PointLabel2 { get; set; }
        public SeriesCollection _PieSeriesCollection2 { get; set; }

        public SeriesCollection PieSeriesCollection2
        {
            get
            {
                return _PieSeriesCollection2;
            }
            set
            {
                _PieSeriesCollection2 = value;
                OnPropertyChanged();
            }
        }
        public void returnPieChart2()
        {
            PointLabel2 = chartPoint2 =>
                string.Format("{0} ({1:P})", chartPoint2.Y, chartPoint2.Participation);
            PieSeriesCollection2 = new SeriesCollection();
            foreach (var product in products)
            {
                PieSeriesCollection2.Add(new PieSeries
                {
                    Title = product.ProductName,
                    Values = new ChartValues<int> { (int)product.Profit },
                    DataLabels = true,
                    LabelPoint = PointLabel2
                });
            }
        }


    }
}
