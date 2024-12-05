using Microsoft.EntityFrameworkCore;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View;
using QuanLyKhoPJ.View.ExportBill;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyKhoPJ.ViewModel
{
    public class ExportBillViewModel :BaseViewModel
    {
        
        private ObservableCollection<ExportBill> _exportBills { get; set; }

        // trường dữ liêu lưu trữ số lượng xuất thêm
        public int quantityAdd { get; set; }
        public ObservableCollection<ExportBill> exportBills { 
            get
            {
                return _exportBills;
            }
            set
            {
                _exportBills = value;
                OnPropertyChanged();
            }
        }
        private ExportBill _exportBill { get; set; }
        public ExportBill exportBill
        {
            get
            {
                return _exportBill;
            }
            set
            {
                _exportBill = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Product> _products { get; set; }
        public ObservableCollection<Product> products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }
        // truuonwgf dữ liệu chứa thông tin tổng số sản phẩm 
        private int _countProductInList { get; set; }
        public int countProductInList
        {
            get
            {
                return _countProductInList;
            }
            set
            {
                _countProductInList = value;
                OnPropertyChanged();
            }
        }

        private Product _selectedItemInBill { get; set; }
        public Product selectedItemInBill
        {
            get
            {
                return _selectedItemInBill;
            }
            set
            {
                _selectedItemInBill = value;
                OnPropertyChanged();
            }
        }
        // trường chứa dữ liệu các sản phầm từ bill
        private Product _selectedProductAddBill { get; set; }
        public Product selectedProductAddBill
        {
            get
            {
                return _selectedProductAddBill;
            }
            set
            {
                _selectedProductAddBill = value;
                OnPropertyChanged();
            }
        }

        // đối tượng hiển thị tổng tiền
        private float _totalPrice { get; set; }
        public float totalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
                OnPropertyChanged();
            }
        }

        // danh sách sản phẩm trong bill
        private ObservableCollection<Product> _listProductsInBill { get; set; }
        public ObservableCollection<Product> listProductsInBill
        {
            get
            {
                return _listProductsInBill;
            }
            set
            {
                _listProductsInBill = value;
                OnPropertyChanged();
            }
        }
        // đối tượng chứa danh sách user
        private ObservableCollection<User> _users { get; set; }
        public ObservableCollection<User> users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        // trường dữ liệu chứa đối tương user được chọn
        private User _selectedUser { get; set; }
        public User selectedUser
        {
            get
            {
                return _selectedUser;
            }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }
        // selected item trong view 
        private ExportBill _selectedItemInView { get; set; }
        public ExportBill selectedItemInView
        {
            get
            {
                return _selectedItemInView;
            }
            set
            {
                _selectedItemInView = value;
                OnPropertyChanged();
            }
        }
        private int? _keySearch { get; set; }
        public int? keySearch
        {
            get
            {
                return _keySearch;
            }
            set
            {
                _keySearch = value;
                OnPropertyChanged();
            }
        }
        //command

        public  ICommand OpenAddExportBillFormCom { get; set; }

        public ICommand AddProductIntoListBillCom { get; set; }

        public ICommand AddExportBillCom { get; set; }

        public ICommand OpenEditFormCom { get; set; }

        public ICommand EditExportBillCom { get; set; }

        public ICommand deleteProductOuttoListBillCom { get; set; }
        public ICommand ReloadCom { get; set; }
        public ICommand ClearCom { get; set; }


        public ICommand SearchExportBillsCom { get; set; }
        public ICommand FilterExportBillCom { get; set; }
        public ICommand ArrangeTransactionDateDownCom { get; set; }
        public ICommand ArrangeTransactionDateUpCom{ get; set; }

        public ICommand OpenPrintFormCom { get; set; }
        public ExportBillViewModel() {
            returnObsExportBill();
            returnObsProduct();
            getAllUser();

            OpenAddExportBillFormCom = new RelayCommand(openAddExportBillForm);
            AddProductIntoListBillCom = new RelayCommand(addProductIntoListBill);
            AddExportBillCom = new RelayCommand(addExportBill);
            OpenEditFormCom = new RelayCommand(openEditForm);
            EditExportBillCom = new RelayCommand(editExportBill);
            deleteProductOuttoListBillCom = new RelayCommand(deleteProductOuttoListBill);
            ReloadCom = new RelayCommand(reload);
            SearchExportBillsCom = new RelayCommand(searchExportBills);
            FilterExportBillCom = new RelayCommand(filterExportBill);
            ClearCom = new RelayCommand(clear);
            ArrangeTransactionDateDownCom = new RelayCommand(arrangeTransactionDateDown);
            ArrangeTransactionDateUpCom = new RelayCommand(arrangeTransactionDateUp);
            OpenPrintFormCom = new RelayCommand(openPrintForm);

            listProductsInBill = new ObservableCollection<Product>();
        }

        // lấy lên toàn bộ export bill
        public ObservableCollection<ExportBill> returnObsExportBill()
        {
            List<ExportBill> listEx = _db.ExportBills.Include(exb => exb.ExportBillProducts).ToList();
            return exportBills = new ObservableCollection<ExportBill>(listEx);
            
        }


        //lấy lên toàn bộ products
        public ObservableCollection<Product> returnObsProduct()
        {

            List<Product> listProducts = (from p in _db.Products select p).Include(p => p.Category)
                                                                                 .Include(p => p.Suplier)

                                                                                 .ToList();

            products = new ObservableCollection<Product>(listProducts);
            return products;
        }


        //mở form ad 
        public void openAddExportBillForm(object obj)
        {
            exportBill = new ExportBill();
            AddExportBillForm addExportBillForm = new AddExportBillForm();
            addExportBillForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addExportBillForm.ShowDialog();
        }

        // tính totalprice 
        public void returnTotalPrice()
        {
            totalPrice = 0;
            if (listProductsInBill != null)
            {
                for (int i = 0; i < listProductsInBill.Count; i++)
                {
                    totalPrice += (float)(listProductsInBill[i].QuantityAddInBill * listProductsInBill[i].EnTryPrice);
                }
            }

        }
        // trả về số sản phẩm để hiển thị
        public void returnCountProduct()
        {
            countProductInList = 0;
            for (int i = 0; i < listProductsInBill.Count; i++)
            {
                countProductInList += (int)listProductsInBill[i].QuantityAddInBill;
            }

        }

        // thêm sản phẩm vào list product của phiếu xuất
        public void addProductIntoListBill(object obj)
        {
            if(quantityAdd <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng phù hợp", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;

            }
            var newProduct = new Product
            {
                ProductId = selectedProductAddBill.ProductId,
                ProductName = selectedProductAddBill.ProductName,
                QuantityAddInBill = quantityAdd,
                EnTryPrice = selectedProductAddBill.EnTryPrice,
                Category = selectedProductAddBill.Category,
                Suplier = selectedProductAddBill.Suplier,
            };

            listProductsInBill.Add(newProduct);
            returnTotalPrice();
            returnCountProduct();
        }
        // xóa sản phẩm ra khỏi list product của phiếu xuất
        public void deleteProductOuttoListBill(object obj)
        {
            listProductsInBill.Remove(selectedItemInBill);
            returnTotalPrice();
            returnCountProduct();
        }

        // // lấy lên danh sách user
        public ObservableCollection<User> getAllUser()
        {
            List<User> listUsers = new List<User>();
            listUsers = _db.Users.ToList();
            users = new ObservableCollection<User>(listUsers);
            return users;
        }

        // lưu phiếu xuất xuống 
        public void addExportBill(object obj)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Hãy nhập thông tin người tạo", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            ExportBill newExportBill = new ExportBill()
            {
                User = selectedUser,
                TransactionDate = DateTime.Now,
                CountProduct = countProductInList,
                ExportBillPrice =(decimal)totalPrice,
                ExportBillProducts = new List<ExportBillProduct>()
            };



            foreach (var productEbl in listProductsInBill)
            {
                // tìm sản phẩm nào trong listinbill trùng với trong list db
                var productdb = _db.Products.FirstOrDefault(p => p.ProductId == productEbl.ProductId);
                if (productdb != null)
                {
                    productdb.Quantity -= (int)productEbl.QuantityAddInBill;
                    productdb.UpdateDay = DateTime.Now;

                    var exportBillProduct = new ExportBillProduct()
                    {
                        Product = productdb,
                        QuantityOutLast = (int)productEbl.QuantityAddInBill

                    };
                    newExportBill.ExportBillProducts.Add(exportBillProduct);

                }
            }

            exportBills.Add(newExportBill);

            _db.ExportBills.Add(newExportBill);
            _db.SaveChanges();

            MessageBox.Show("Bạn đã thêm phiếu xuất thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        // mở form edit
        public void openEditForm(object obj)
        {
            
            EditExportBillForm editExportBillForm = new EditExportBillForm();

            if (selectedItemInView == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất hợp lệ.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            exportBill = selectedItemInView;
            selectedUser = exportBill.User;
           
            listProductsInBill = new ObservableCollection<Product>(exportBill.ExportBillProducts.Select(ebp =>
            {
                ebp.Product.QuantityAddInBill = ebp.QuantityOutLast;
                return ebp.Product;
            }));


            returnCountProduct();
            returnTotalPrice();

            editExportBillForm.ShowDialog();

        }


        // chỉnh sửa 
        public void editExportBill(object obj)
        {
            ExportBill exportEdit = selectedItemInView;
            exportEdit.TransactionDate = DateTime.Now;
            exportEdit.CountProduct = countProductInList;
            exportEdit.User = selectedUser;
            exportEdit.ExportBillPrice = (decimal)totalPrice;
            var ExportBillProducts = new List<ExportBillProduct>();

            var oldExportBillProducts = exportEdit.ExportBillProducts.ToList();
            foreach (var item in oldExportBillProducts)
            {
                var productdb = _db.Products.FirstOrDefault(p => p.ProductId == item.Product.ProductId);
                if (productdb != null)
                {
                    productdb.Quantity += item.QuantityOutLast; // Trừ số lượng cũ
                }
            }


            foreach (var productebl in listProductsInBill)
            {

                var productdb = _db.Products.FirstOrDefault(p => p.ProductId == productebl.ProductId);
                if (productdb != null)
                {
                    productdb.Quantity -= (int)productebl.QuantityAddInBill;
                    productdb.UpdateDay = DateTime.Now;

                    var exportBillProduct = new ExportBillProduct()
                    {
                        Product = productdb,
                        QuantityOutLast = (int)productebl.QuantityAddInBill

                    };
                    ExportBillProducts.Add(exportBillProduct);


                }


            }
            exportEdit.ExportBillProducts = ExportBillProducts;


            _db.SaveChanges();
            MessageBox.Show("Bạn đã chỉnh sửa phiếu xuất thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);




        }
        // reload
        public void reload(object obj)
        {
            exportBills = returnObsExportBill();
        }

        // tìm kiếm theo mã
        public List<ExportBill> getListExportBillById()
        {

            List<ExportBill> listExportBillAfterSearch = new List<ExportBill>();


            if (!keySearch.HasValue)
            {
                List<ExportBill> listExportBillSearch = (from e in _db.ExportBills select e).ToList();
                listExportBillAfterSearch = listExportBillSearch;
                return listExportBillAfterSearch;

            }
            else
            {
                List<ExportBill> listExportBillSearch = (from e in _db.ExportBills
                                                       where e.ExportBillId == keySearch
                                                       select e).ToList();
                listExportBillAfterSearch = listExportBillSearch;
                return listExportBillAfterSearch;

            }
        }

        // phương thức tìm kiếm 
        public void searchExportBills(object obj)
        {
            exportBills = new ObservableCollection<ExportBill>(getListExportBillById());
        }


        // // phương thức lọc
        public void filterExportBill(object obj)
        {
            if (selectedUser != null)
            {
                List<ExportBill> exportBillFilter = _db.ExportBills.Where(eb => eb.User.UserName == selectedUser.UserName).ToList();
                exportBills = new ObservableCollection<ExportBill>(exportBillFilter);
            }
            else
            {
                exportBills = new ObservableCollection<ExportBill>(_db.ExportBills.ToList());
            }
        }
        // clear
        public void clear(object obj)
        {
            selectedUser = null;
        }


        // sắp ngày tạo giảm
        public void arrangeTransactionDateDown(object obj)
        {
            var sortedExportBill = _db.ExportBills.OrderByDescending(eb => eb.TransactionDate).ToList();
            exportBills = new ObservableCollection<ExportBill>(sortedExportBill);
        }
        // sắp xếp ngày tạo tăng
        public void arrangeTransactionDateUp(object obj)
        {
            var sortedExportBill = _db.ExportBills.OrderBy(eb => eb.TransactionDate).ToList();
            exportBills = new ObservableCollection<ExportBill>(sortedExportBill);
        }
        // mở form in phiếu

        public void openPrintForm(object obj)
        {
            var printExportBillForm = new PrintExportBillForm();

            if (selectedItemInView == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất hợp lệ.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            exportBill = selectedItemInView;
            selectedUser = exportBill.User;

            listProductsInBill = new ObservableCollection<Product>(exportBill.ExportBillProducts.Select(ebp =>
            {
                ebp.Product.QuantityAddInBill = ebp.QuantityOutLast;
                return ebp.Product;
            }));




            returnCountProduct();
            returnTotalPrice();

            printExportBillForm.ShowDialog();
        }

    }

}
