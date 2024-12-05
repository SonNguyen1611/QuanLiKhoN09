
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace QuanLyKhoPJ.ViewModel
{
    public class ProductViewModel : BaseViewModel
    {


        public AddProductForm addProductForm { get; set; }

        public EditProductForm editProductForm { get; set; }
        public Product product { get; set; }

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

        private ObservableCollection<Category> _categories;

        public ObservableCollection<Category> categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Suplier> _supliers;

        public ObservableCollection<Suplier> supliers
        {
            get { return _supliers; }
            set
            {
                _supliers = value;
                OnPropertyChanged();
            }
        }

        private Category _selectedCategory { get; set; }
        public Category selectedCategory
        {
            get
            {
                return _selectedCategory;
            }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged();

            }
        }
        private Suplier _selectedSuplier { get; set; }
        public Suplier selectedSuplier
        {
            get
            {
                return _selectedSuplier;
            }
            set
            {
                _selectedSuplier = value;
                OnPropertyChanged();

            }
        }

        private Product _selectedItem { get; set; }
        public Product selectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();

            }
        }
        private Category _selectedCateFilter { get; set; }
        public Category selectedCateFilter
        {
            get
            {
                return _selectedCateFilter;
            }
            set
            {
                _selectedCateFilter = value;
                OnPropertyChanged();

            }
        }
        private Suplier _selectedSupFilter { get; set; }
        public Suplier selectedSupFilter
        {
            get
            {
                return _selectedSupFilter;
            }
            set
            {
                _selectedSupFilter = value;
                OnPropertyChanged();

            }
        }



        private string _keySearch { get; set; }
        public string keySearch
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
        public Uri _imgSource { get; set; }
        public Uri imgSource
        {
            get { return _imgSource; }
            set
            {
                _imgSource = value;
                OnPropertyChanged();
            }
        }
        private string _fileName;

        public string fileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnPropertyChanged();
            }
        }



        public ICommand OpenWindowAddCom { get; set; }
        public ICommand CloseWindowAddCom { get; set; }
        public ICommand OpenWindowEditCom { get; set; }
        public ICommand CloseWindowEditCom { get; set; }

        public ICommand AddProductCom { get; set; }
        public ICommand EditProductCom { get; set; }

        public ICommand DeleteProductCom { get; set; }
        public ICommand SearchProductCom { get; set; }

        public ICommand FilterProductCom { get; set; }

        public ICommand ClearCom { get; set; }
        public ICommand ArrangeQuantityDownCom { get; set; }
        public ICommand ArrangeQuantityUpCom { get; set; }
        public ICommand ArrangeUpdateDayDownCom { get; set; }
        public ICommand ReloadCom { get; set; }
        public ICommand LoadImageCom { get; set; }



        public ProductViewModel()
        {


            returnObsCategory();
            returnObsSuplier();
            returnObsProduct();


            product = new Product();
            OpenWindowAddCom = new RelayCommand(OpenWindowAdd);
            CloseWindowAddCom = new RelayCommand(CloseWindowAdd);
            OpenWindowEditCom = new RelayCommand(OpenWindowEdit);
            CloseWindowEditCom = new RelayCommand(CloseWindowEdit);


            AddProductCom = new RelayCommand(addProduct);
            EditProductCom = new RelayCommand(EditProduct);
            DeleteProductCom = new RelayCommand(DeleteProduct);
            SearchProductCom = new RelayCommand(SearchProduct);
            FilterProductCom = new RelayCommand(filterProduct);
            ClearCom = new RelayCommand(Clear);
            ArrangeQuantityDownCom = new RelayCommand(arrangeQuantityDown);
            ArrangeQuantityUpCom = new RelayCommand(arrangeQuantityUp);
            ArrangeUpdateDayDownCom = new RelayCommand(arrangeUpdateDayDown);
            ReloadCom = new RelayCommand(reload);
            LoadImageCom = new RelayCommand(loadImage);

        }

        public void OpenWindowAdd(object obj)
        {
            product = new Product();
            addProductForm = new AddProductForm();
            addProductForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            addProductForm.ShowDialog();
        }
        //đóng cửa sổ add
        public void CloseWindowAdd(object obj)
        {
            addProductForm.Close();
        }


        // lấy toàn bộ danh sách sản phẩm

        public ObservableCollection<Product> returnObsProduct()
        {

            List<Product> listProducts = (from p in _db.Products select p).Include(p => p.Category)
                                                                                .Include(p => p.Suplier)
                                                                                .ToList();
            products = new ObservableCollection<Product>(listProducts);
            return products;
        }

        // lấy lên toàn bộ danh sách categories

        public ObservableCollection<Category> returnObsCategory()
        {

            List<Category> listCategory = (from c in _db.Categories select c).ToList();
            categories = new ObservableCollection<Category>(listCategory);
            return categories;
        }

        // lấy lên toàn bộ danh sách Suplier
        public ObservableCollection<Suplier> returnObsSuplier()
        {

            List<Suplier> listSuplier = (from s in _db.Supliers select s).ToList();
            supliers = new ObservableCollection<Suplier>(listSuplier);
            return supliers;
        }


        // thêm product
        public void addProduct(object obj)
        {
            //vị trí đích
            string locateAfter = "C:\\Users\\Son\\source\\repos\\StorageImgQLK\\Sản Phẩm\\" + fileName;

            // vị trí ban đầu
            string locateBefore = imgSource.LocalPath.ToString();
            //copy file từ vị trí ban đầu vào vị trí mới( chức năng lưu ảnh)
            System.IO.File.Copy(locateBefore, locateAfter, true);
            var newProduct = new Product
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                Quantity = product.Quantity,
                EnTryPrice = product.EnTryPrice,
                ExportPrice = product.ExportPrice,
                Profit = (product.ExportPrice - product.EnTryPrice),
                Category = selectedCategory,
                Suplier = selectedSuplier,
                UpdateDay = product.UpdateDay.Date.Add(DateTime.Now.TimeOfDay),
                image = locateAfter,


            };

            List<string> listProductId = (from p in _db.Products select p.ProductId).ToList();
            if (listProductId.Contains(newProduct.ProductId))
            {
                System.Windows.MessageBox.Show("Mã sản phẩm bị trùng lặp", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                products.Add(newProduct);
                _db.Products.Add(newProduct);
                _db.SaveChanges();
                System.Windows.MessageBox.Show("Bạn đã thêm sản phẩm!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
        // Mở form chỉnh sửa

        public void OpenWindowEdit(object obj)
        {

            editProductForm = new EditProductForm();
            product = selectedItem;
            if (selectedItem != null)
            {
                imgSource = new Uri(product.image);
                selectedCategory = product.Category;
                selectedSuplier = product.Suplier;
            }
            editProductForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            editProductForm.ShowDialog();
        }

        // đóng form chỉnh sửa
        public void CloseWindowEdit(object obj)
        {

            editProductForm.Close();
        }
        // chỉnh sửa
        public void EditProduct(object obj)
        {
            //vị trí đích
            string locateAfter = "C:\\Users\\Son\\source\\repos\\StorageImgQLK\\Sản Phẩm\\" + fileName;

            // vị trí ban đầu
            string locateBefore = imgSource.LocalPath.ToString();
            //copy file từ vị trí ban đầu vào vị trí mới( chức năng lưu ảnh)
            System.IO.File.Copy(locateBefore, locateAfter, true);
            Product productEdit = selectedItem;
            
            productEdit.ProductId = product.ProductId;
            productEdit.ProductName = product.ProductName;
            productEdit.ProductDescription = product.ProductDescription;
            productEdit.Quantity = product.Quantity;
            productEdit.EnTryPrice = product.EnTryPrice;
            productEdit.ExportPrice = product.ExportPrice;
            productEdit.Profit = (product.ExportPrice - product.EnTryPrice);
            productEdit.Category = selectedCategory;
            productEdit.Suplier = selectedSuplier;
            productEdit.UpdateDay = product.UpdateDay.Date.Add(DateTime.Now.TimeOfDay);
            productEdit.image = locateAfter;

            if (selectedItem.ProductId != product.ProductId)
            {
                System.Windows.MessageBox.Show("Không thể thay đổi mã sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                _db.SaveChanges();
                System.Windows.MessageBox.Show("Bạn đã chỉnh sửa sản phẩm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        // xóa sản phẩm
        public void DeleteProduct(object obj)
        {

            Product productDel = selectedItem;
            if (productDel == null)
            {
                System.Windows.MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            _db.Products.Remove(productDel);
            products.Remove(selectedItem);
            _db.SaveChanges();
            System.Windows.MessageBox.Show("Bạn đã xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);


        }

        // lấy danh sách theo mã sản phẩm


        public List<Product> getListProductById()
        {

            List<Product> listProductAfterSearch = new List<Product>();
            if (keySearch != null)
            {
                List<Product> listProductSearch = (from s in _db.Products
                                                   where s.ProductId.Contains(keySearch)
                                                   select s).ToList();
                listProductAfterSearch = listProductSearch;
                return listProductAfterSearch;

            }
            else
            {
                List<Product> listProducts = (from p in _db.Products select p).ToList();
                listProductAfterSearch = listProducts;
                return listProductAfterSearch;



            }
        }
        // phương thức tìm kiếm 
        public void SearchProduct(object obj)
        {
            products = new ObservableCollection<Product>(getListProductById());
        }


        // phương thức lọc
        public void filterProduct(object obj)
        {
            if (selectedCateFilter == null)
            {
                if (selectedSupFilter == null)
                {
                    List<Product> listProducts = (from p in _db.Products select p).ToList();
                    products = new ObservableCollection<Product>(listProducts);
                }
                else
                {
                    // linq sử dụng query syntax 
                    List<Product> listProducts = (from p in _db.Products where p.Suplier.SuplierId == selectedSupFilter.SuplierId select p)
                                                 .ToList();
                    products = new ObservableCollection<Product>(listProducts);
                }
            }
            else
            {
                if (selectedSupFilter == null)
                {
                    //linq sửu dụng method syntax
                    List<Product> listProducts = _db.Products
                                                 .Where(p => p.Category.CategoryId == selectedCateFilter.CategoryId)
                                                 .ToList();
                    products = new ObservableCollection<Product>(listProducts);
                }
                else
                {
                    List<Product> listProducts = _db.Products
                     .Where(p => p.Category.CategoryId == selectedCateFilter.CategoryId && p.Suplier.SuplierId == selectedSupFilter.SuplierId)
                     .ToList();
                    products = new ObservableCollection<Product>(listProducts);

                }
            };
        }


        // clear
        public void Clear(object obj)
        {
            selectedCateFilter = null;
            selectedSupFilter = null;
        }

        // sắp xếp theo tồn kho giảm 
        public void arrangeQuantityDown(object obj)
        {
            var sortedProduct = _db.Products.OrderByDescending(p => p.Quantity).ToList();
            products = new ObservableCollection<Product>(sortedProduct);
        }
        // sắp xếp tồn kho tăng dần
        public void arrangeQuantityUp(object obj)
        {
            var sortedProduct = _db.Products.OrderBy(p => p.Quantity).ToList();
            products = new ObservableCollection<Product>(sortedProduct);
        }

        // sắp xếp theo ngày cập nhật mới nhát
        public void arrangeUpdateDayDown(object obj)
        {
            var sortedProduct = _db.Products.OrderByDescending(p => p.UpdateDay).ToList();
            products = new ObservableCollection<Product>(sortedProduct);
        }

        // reload
        public void reload(object obj)
        {
            using var db = new QuanLiKhoDbContext();
            List<Product> listProducts = (from p in db.Products select p).Include(p => p.Category)
                                                                                .Include(p => p.Suplier)
                                                                                .ToList();
            products = new ObservableCollection<Product>(listProducts);
        }
        // load ảnh
        public void loadImage(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // hiển thị cửa sổ chọn file
            if (openFileDialog.ShowDialog() != null)
            {
                // lấy ra uri của file
                imgSource = new Uri(openFileDialog.FileName);

                // lấy phần mở rộng của file 
                var fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                // tạo tên file 1 cách ngẫu nhiên để lưu xuống csdl
                fileName = $"{Guid.NewGuid()}{fileExtension}";

            }


        }
        
    }
}
