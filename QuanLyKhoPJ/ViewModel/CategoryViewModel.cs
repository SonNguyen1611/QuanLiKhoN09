using Microsoft.EntityFrameworkCore;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View.Category;
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
    public class CategoryViewModel : BaseViewModel
    {
        private AddCategoryForm addCategoryForm {  get; set; }  
        private EditCategoryForm editCategoryForm { get; set; }
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
        private Category _category;

        public Category category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }
        // biến chứa giá trị đang chọn trên view
        private Category _SelectedItem { get; set; }
        public Category SelectedItem
        {
            get
            {
                return _SelectedItem;
            }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();

            }
        }
        public string keySearch { get; set; }
        public ICommand OpenAddFormCom { get; set; }
        public ICommand OpenEditFormCom { get; set; }
        public ICommand CloseAddFormCom { get; set; }
        public ICommand CloseEditFormCom { get; set; }
        public ICommand AddCategoryCom { get; set; }
        public ICommand EditCategoryCom { get; set; }
        public ICommand DelCategoryCom { get; set; }
        public ICommand SearchCateCom { get; set; }
        public CategoryViewModel()
        {
            getAllCategory();
            OpenAddFormCom = new RelayCommand (openAddForm);
            OpenEditFormCom = new RelayCommand(openEditForm);
            CloseAddFormCom = new RelayCommand(closeAddForm); 
            CloseEditFormCom = new RelayCommand(closeEditForm);
            AddCategoryCom = new RelayCommand(addCategory);
            EditCategoryCom = new RelayCommand(editCategory);
            DelCategoryCom = new RelayCommand(deleteCate);
            SearchCateCom = new RelayCommand(searchCate);


        }

        // lấy lên toàn bộ categories
        public void getAllCategory()
        {
           
            categories = new ObservableCollection<Category>(_db.Categories.ToList());
        }
        // Mở form add category
        public void openAddForm(object obj)
        {
            category = new Category();
            addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
        }
        // mở form chỉnh sửa
        public void openEditForm(object obj) {
            category = SelectedItem;
            editCategoryForm = new EditCategoryForm();
            editCategoryForm.ShowDialog();
        }
        //đóng form add
        public void closeAddForm(object obj)
        {
            addCategoryForm.Close();
        }
        public void closeEditForm(object obj)
        {
            editCategoryForm.Close();
        }
        // thêm category 
        public void addCategory(object obj)
        {

            var newCate = new Category
            {
                CategoryName = category.CategoryName,

            };
            categories.Add(newCate);
            _db.Categories.Add(newCate);
            _db.SaveChanges();

            MessageBox.Show("Bạn đã thêm thể loại thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        //chỉnh sửa 
        public void editCategory(object obj)
        {
            Category categoryEdit = SelectedItem;
            categoryEdit.CategoryName = category.CategoryName;
            _db.SaveChanges();
            MessageBox.Show("Bạn đã chỉnh sửa thể loại thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        // xóa cate
        public void deleteCate(object obj)
        {
            _db.Remove(SelectedItem);
            categories.Remove(SelectedItem);
            _db.SaveChanges();
            MessageBox.Show("Bạn đã xóa thể loại thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        public void searchCate(object obj)
        {
            if(keySearch != null)
            {
                categories = new ObservableCollection<Category>(_db.Categories.Where(c => c.CategoryName.Contains(keySearch)).ToList());
            }
            else
            getAllCategory();
        }

    }
}
