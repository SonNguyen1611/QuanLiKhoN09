using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKhoPJ.ViewModel
{
    public class EntryBillViewModel : BaseViewModel
    {
       
        public AddEntryBillForm addEntryBillForm { get; set; }
        public EditEntryBillForm editEntryBillForm { get; set; }
        public AddProductForm addProductForm { get; set; }

        // trường dữ liêu lưu trữ số lượng nhập thêm
        public int quantityAdd { get; set; }


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

        //  đối tượng entryBill để lưu trữ
        private EntryBill _entryBill { get; set; }
        public EntryBill entryBill
        {
            get
            {
                return _entryBill;
            }
            set
            {
                _entryBill = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<EntryBill> _entryBills { get; set; }
        public ObservableCollection<EntryBill> entryBills
        {
            get
            {
                return _entryBills;
            }
            set
            {
                _entryBills = value;
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

        // selected item trong view 
        private EntryBill _selectedItemInView { get; set; }
        public EntryBill selectedItemInView
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

        // tìm kiếm 
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
      

        public ICommand OpenAddEntryBillCommand { get; set; }
        public ICommand OpenAddProductFormCommand { get; set; }

        public ICommand OpenEditFormCommand { get; set; }
        public ICommand AddProductIntoListBillCom { get; set; }
        public ICommand deleteProductOuttoListBillCom { get; set; }

        public ICommand AddEntryBillCom { get; set; }
        public ICommand EditEntryBillCom { get; set; }
        public ICommand DeleteEntryBillCom { get; set; }
        public ICommand SearchEntryBillCom { get; set; }
        public ICommand FilterEntryBillCom { get; set; }
        public ICommand ClearCom { get; set; }
        public ICommand ArrangeTransactionDateDownCom { get; set; }
        public ICommand ArrangeTransactionDateUpCom { get; set; }
        
        public ICommand OpenPrintFormCom { get; set; }
        public ICommand ReloadCom { get; set; }
        public EntryBillViewModel()

        {
            returnObsProduct();

            getAllUser();
            returnObsEntryBill();




            listProductsInBill = new ObservableCollection<Product>();

            OpenAddEntryBillCommand = new RelayCommand(OpenAddEntryBillForm);

            AddProductIntoListBillCom = new RelayCommand(addProductIntoListBill);

            deleteProductOuttoListBillCom = new RelayCommand(deleteProductOuttoListBill);

            AddEntryBillCom = new RelayCommand(addEntryBill);

            EditEntryBillCom = new RelayCommand(editEntryBill);

            OpenEditFormCommand = new RelayCommand(openEditForm);

            DeleteEntryBillCom = new RelayCommand(deleteEntryBill);

            SearchEntryBillCom = new RelayCommand(SearchEntryBills);

            FilterEntryBillCom = new RelayCommand(filterEntryBill);

            ClearCom = new RelayCommand(clear);

            ArrangeTransactionDateDownCom = new RelayCommand(arrangeTransactionDateDown);

            ArrangeTransactionDateUpCom = new RelayCommand(arrangeTransactionDateUp);

            OpenPrintFormCom = new RelayCommand(openPrintForm);
            ReloadCom = new RelayCommand(reload);
        }

        // mở form thêm entry bill
        public void OpenAddEntryBillForm(object obj)
        {
            entryBill = new EntryBill();
            addEntryBillForm = new AddEntryBillForm();
            addEntryBillForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addEntryBillForm.ShowDialog();
        }

        // lấy lên toàn bộ product

        public ObservableCollection<Product> returnObsProduct()
        {

            List<Product> listProducts = (from p in _db.Products select p).Include(p => p.Category)
                                                                                 .Include(p => p.Suplier)

                                                                                 .ToList();

            products = new ObservableCollection<Product>(listProducts);
            return products;
        }


        // thêm sản phẩm vào list product của phiếu nhập


        public void addProductIntoListBill(object obj)
        {

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

        // xóa sản phẩm từ list sản phẩm trong bill 
        public void deleteProductOuttoListBill(object obj)
        {
            listProductsInBill.Remove(selectedItemInBill);
            returnTotalPrice();
            returnCountProduct();
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
        // lấy lên danh sách user
        public ObservableCollection<User> getAllUser()
        {
            List<User> listUsers = new List<User>();
            listUsers = _db.Users.ToList();
            users = new ObservableCollection<User>(listUsers);
            return users;
        }


        // lưu phiếu nhập xuống 
        public void addEntryBill(object obj)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Hãy nhập thông tin người tạo", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            EntryBill newEntryBill = new EntryBill()
            {
                User = selectedUser,
                TransactionDate = DateTime.Now,
                CountProduct = countProductInList,
                EntryBillPrice = totalPrice,
                EntryBillProducts = new List<EntryBillProduct>()
            };



            foreach (var productEbl in listProductsInBill)
            {
                // tìm sản phẩm nào trong listinbill trùng với trong list db
                var productdb = _db.Products.FirstOrDefault(p => p.ProductId == productEbl.ProductId);
                if (productdb != null)
                {
                    productdb.Quantity += (int)productEbl.QuantityAddInBill;
                    productdb.UpdateDay = DateTime.Now;

                    var entryBillProduct = new EntryBillProduct()
                    {
                        Product = productdb,
                        QuantityAddLast = (int)productEbl.QuantityAddInBill

                    };
                    newEntryBill.EntryBillProducts.Add(entryBillProduct);

                }
            }

            entryBills.Add(newEntryBill);

            _db.EntryBills.Add(newEntryBill);
            _db.SaveChanges();

            MessageBox.Show("Bạn đã thêm phiếu nhập thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        // lấy lên toàn bộ entrybill

        public ObservableCollection<EntryBill> returnObsEntryBill()
        {
            List<EntryBill> listEntryBill = (from e in _db.EntryBills select e).Include(e => e.User).Include(e => e.EntryBillProducts).ToList();
            entryBills = new ObservableCollection<EntryBill>(listEntryBill);
            return entryBills;
        }


        // mở form edit
        public void openEditForm(object obj)
        {
            editEntryBillForm = new EditEntryBillForm();

            if (selectedItemInView == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập hợp lệ.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            entryBill = selectedItemInView;
            selectedUser = entryBill.User;

            listProductsInBill = new ObservableCollection<Product>(entryBill.EntryBillProducts.Select(ebp =>
            {
                ebp.Product.QuantityAddInBill = ebp.QuantityAddLast;
                return ebp.Product;
            }));




            returnCountProduct();
            returnTotalPrice();

            editEntryBillForm.ShowDialog();

        }

        //chỉnh sửa phiếu nhập
        public void editEntryBill(object obj)
        {
            EntryBill entryEdit = selectedItemInView;
            entryEdit.TransactionDate = DateTime.Now;
            entryEdit.CountProduct = countProductInList;
            entryEdit.User = selectedUser;
            entryEdit.EntryBillPrice = totalPrice;
            var EntryBillProducts = new List<EntryBillProduct>();

            var oldEntryBillProducts = entryBill.EntryBillProducts.ToList();
            foreach (var item in oldEntryBillProducts)
            {
                var productdb = _db.Products.FirstOrDefault(p => p.ProductId == item.Product.ProductId);
                if (productdb != null)
                {
                    productdb.Quantity -= item.QuantityAddLast; // Trừ số lượng cũ
                }
            }


            foreach (var productebl in listProductsInBill)
            {

                var productdb = _db.Products.FirstOrDefault(p => p.ProductId == productebl.ProductId);
                if (productdb != null)
                {
                    productdb.Quantity += (int)productebl.QuantityAddInBill;
                    productdb.UpdateDay = DateTime.Now;

                    var entryBillProduct = new EntryBillProduct()
                    {
                        Product = productdb,
                        QuantityAddLast = (int)productebl.QuantityAddInBill

                    };
                    EntryBillProducts.Add(entryBillProduct);


                }


            }
            entryEdit.EntryBillProducts = EntryBillProducts;


            _db.SaveChanges();
            MessageBox.Show("Bạn đã chỉnh sửa phiếu nhập thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);




        }


        /// xóa entryBills 
        public void deleteEntryBill(object obj)
        {
            if (selectedItemInView != null)
            {
                _db.EntryBills.Remove(selectedItemInView);
                entryBills.Remove(selectedItemInView);
                _db.SaveChanges();
                MessageBox.Show("Bạn đã xóa phiếu nhập thành công thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                MessageBox.Show("Phiếu nhập chưa được chọn", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;



            }
        }


        // tìm kiếm theo mã 
        public List<EntryBill> getListEntryBillById()
        {

            List<EntryBill> listEntryBillAfterSearch = new List<EntryBill>();

           
            if (!keySearch.HasValue)
            {
                List<EntryBill> listEntryBillSearch = (from e in _db.EntryBills select e).ToList();
                listEntryBillAfterSearch = listEntryBillSearch;
                return listEntryBillAfterSearch;

            }
            else
            {
                List<EntryBill> listEntryBillSearch = (from e in _db.EntryBills
                                                       where e.EntryBillId == keySearch
                                                       select e).ToList();
                listEntryBillAfterSearch = listEntryBillSearch;
                return listEntryBillAfterSearch;

                



            }
        }
        // phương thức tìm kiếm 
        public void SearchEntryBills(object obj)
        {
            entryBills = new ObservableCollection<EntryBill>(getListEntryBillById());
        }



        // phương thức lọc
        public void filterEntryBill(object obj)
        {
            if (selectedUser != null)
            {
                List<EntryBill> entryBillFilter = _db.EntryBills.Where(eb => eb.User.UserName == selectedUser.UserName).ToList();
                entryBills = new ObservableCollection<EntryBill>(entryBillFilter);
            }
            else
            {
                entryBills = new ObservableCollection<EntryBill>(_db.EntryBills.ToList());
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
            var sortedEntryBill = _db.EntryBills.OrderByDescending(eb => eb.TransactionDate).ToList();
            entryBills = new ObservableCollection<EntryBill>(sortedEntryBill);
        }
        // sắp xếp ngày tạo tăng
        public void arrangeTransactionDateUp(object obj)
        {
            var sortedEntryBill = _db.EntryBills.OrderBy(eb => eb.TransactionDate).ToList();
            entryBills = new ObservableCollection<EntryBill>(sortedEntryBill);
        }


        // mở form xem chi tiết và in phiếu
        public void openPrintForm(object obj)
        {
            var printEntryBillForm = new PrintEntryBillForm();

            if (selectedItemInView == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập hợp lệ.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            entryBill = selectedItemInView;
            selectedUser = entryBill.User;

            listProductsInBill = new ObservableCollection<Product>(entryBill.EntryBillProducts.Select(ebp =>
            {
                ebp.Product.QuantityAddInBill = ebp.QuantityAddLast;
                return ebp.Product;
            }));




            returnCountProduct();
            returnTotalPrice();

            printEntryBillForm.ShowDialog();
        }

        // relaod 
        public void reload(object obj)
        {
            entryBills = returnObsEntryBill();
        }
        


    }

    
}