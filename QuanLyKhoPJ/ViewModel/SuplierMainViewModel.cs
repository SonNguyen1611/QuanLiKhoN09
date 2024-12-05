using Microsoft.EntityFrameworkCore;
using Microsoft.Web.WebView2.Core;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View;
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
    public class SuplierMainViewModel : BaseViewModel
    {
        public Suplier suplier { get; set; }
        // khai báo đối tượng chứa cửa sổ add
        public AddSuplierForm suplierFormWindow { get; set; }

        public EditSuplierForm suplierEditWindow { get; set; }



        private ObservableCollection<Suplier> _Supliers;

        public ObservableCollection<Suplier> Supliers
        {
            get { return _Supliers; }
            set
            {
                _Supliers = value;
                OnPropertyChanged();
            }
        }
        // biến chứa giá trị đang chọn trên view
        private Suplier _SelectedItem { get; set; }
        public Suplier SelectedItem
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


        public ICommand CAddSuplier { get; set; }
        public ICommand CEditSuplier { get; set; }
        public ICommand CDeleteSuplier { get; set; }
        public ICommand CSearchSuplier { get; set; }
        public ICommand CloseWindowAddSuplier { get; set; }
        public ICommand OpenWindowAddSuplier { get; set; }
        public ICommand CloseWindowEditSuplier { get; set; }
        public ICommand OpenWindowEditSuplier { get; set; }


        public SuplierMainViewModel()
        {
            suplier = new Suplier();
            Supliers = new ObservableCollection<Suplier>(GetAllSuplier());
            
            CAddSuplier = new RelayCommand(AddSuplier);
            CEditSuplier = new RelayCommand(EditSuplier);
            CDeleteSuplier = new RelayCommand(DeleteSuplier);
            CSearchSuplier = new RelayCommand(SearchSuplier);


            OpenWindowAddSuplier = new RelayCommand(OpenAddSuplier);
            CloseWindowAddSuplier = new RelayCommand(CloseAddSuplier);
            OpenWindowEditSuplier = new RelayCommand(OpenEditSuplier);
            CloseWindowEditSuplier = new RelayCommand(CloseEditSuplier);

        }

        // mở cửa sổ add suplier
        public void OpenAddSuplier(object obj)
        {
            suplier = new Suplier();
            suplierFormWindow = new AddSuplierForm();
            suplierFormWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            suplierFormWindow.ShowDialog();

        }
        // đóng cửa sổ  bằng nút cancel
        public void CloseAddSuplier(object obj)
        {

            suplierFormWindow.Close();

        }
        // mở cửa sổ edit
        public void OpenEditSuplier(object obj)
        {
            suplier = SelectedItem;
            suplierEditWindow = new EditSuplierForm();
            suplierEditWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            suplierEditWindow.ShowDialog();

        }
        // đóng cửa sổ edit bằng cancel
        public void CloseEditSuplier(object obj)
        {

            suplierEditWindow.Close();

        }





        // lấy toàn bộ danh sách từ cở sở dữ liệu
        public List<Suplier> GetAllSuplier()
        {
            using var dbcontext = new QuanLiKhoDbContext();
            var listSupliers = (from s in dbcontext.Supliers select s).ToList();

            return listSupliers;

        }

        // hàm lưu suplier mới
        public void AddSuplier(object obj)
        {

            using var dbcontext = new QuanLiKhoDbContext();
            var newSuplier = new Suplier
            {
                SuplierName = suplier.SuplierName,
                SuplierAddress = suplier.SuplierAddress,
                SuplierPhoneNumber = suplier.SuplierPhoneNumber,
                SuplierEmail = suplier.SuplierEmail

            };
            Supliers.Add(newSuplier);
            dbcontext.Supliers.Add(newSuplier);
            dbcontext.SaveChanges();

            MessageBox.Show("Bạn đã thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // chỉnh sửa suplier
        public void EditSuplier(object obj)
        {
            using var dbcontext = new QuanLiKhoDbContext();
            Suplier suplierEdit = SelectedItem;
            if (suplierEdit == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            suplierEdit.SuplierName = suplier.SuplierName;
            suplierEdit.SuplierPhoneNumber = suplier.SuplierPhoneNumber;
            suplierEdit.SuplierAddress = suplier.SuplierAddress;
            suplierEdit.SuplierEmail = suplier.SuplierEmail;
            dbcontext.SaveChanges();
            MessageBox.Show("Bạn đã chỉnh sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        //phương thức lấy ra danh sách tìm kiếm
        public List<Suplier> getListSuplierByName()
        {
            using var dbcontext = new QuanLiKhoDbContext();
            List<Suplier> listSuplierAfterSearch = new List<Suplier>();
            if (keySearch != null)
            {
                List<Suplier> listSuplierSearch = (from s in dbcontext.Supliers
                                     where s.SuplierName.Contains(keySearch)
                                     select s).ToList();
                listSuplierAfterSearch = listSuplierSearch;
                return listSuplierAfterSearch;

            }
            else
            {
                return listSuplierAfterSearch = GetAllSuplier();
                MessageBox.Show("Bạn đã chỉnh sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);


            }
        }
        // phương thức tìm kiếm 
        public void SearchSuplier(object obj)
        {
            Supliers = new ObservableCollection<Suplier>(getListSuplierByName());
        }


        // phương thức xóa
        public void DeleteSuplier(object obj)
        {
            using var dbcontext = new QuanLiKhoDbContext();
            if(SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            Suplier suplierDel = (from s in dbcontext.Supliers where s.SuplierId == SelectedItem.SuplierId select s).FirstOrDefault();
            dbcontext.Supliers.Remove(suplierDel);
            Supliers.Remove(SelectedItem);
            dbcontext.SaveChanges();
            MessageBox.Show("Bạn đã xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);


        }
    }
}
