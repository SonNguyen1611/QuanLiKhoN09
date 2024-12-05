using Microsoft.Identity.Client;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View;
using QuanLyKhoPJ.View.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace QuanLyKhoPJ.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        public string oldPass { get; set; }
        public string newPass { get; set; }
        public ChangePasswordView changePasswordView { get; set; }
        private User _user { get; set; }
        public User user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }
        private bool _isEnabled;
        public bool isEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
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
        public ICommand LogoutCom { get; set; }
        public ICommand EditUserCom { get; set; }
        public ICommand LoadAnhCom { get; set; }
        public ICommand OpenChangePassWCom { get; set; }
        public ICommand ChangePassCom{ get; set; }
        public UserViewModel()
        {
            // tạo bản sao tránh tham chiếu trực tiếp
            // việc tham chiếu trực tiếp dẫn đến việc dữ liệu khi user bị thay đổi tránh việc CurrentUser cũng bị thay đổi theo dấn đến việc k lấy ra được user cũ
            user = new User
            {
                UserName = UserSeesion.CurrentUser.UserName,
                Email = UserSeesion.CurrentUser.Email,
                Address = UserSeesion.CurrentUser.Address,
                PhoneNumber = UserSeesion.CurrentUser.PhoneNumber,
                age = UserSeesion.CurrentUser.age,
                DisplayName = UserSeesion.CurrentUser.DisplayName,
                sex = UserSeesion.CurrentUser.sex,
                image = UserSeesion.CurrentUser.image,
                Role = UserSeesion.CurrentUser.Role,
            };
            imgSource = new Uri(user.image);
            LogoutCom = new RelayCommand(logout);
            EditUserCom = new RelayCommand(EditUser);
            LoadAnhCom = new RelayCommand(loadImage);
            OpenChangePassWCom = new RelayCommand(openChangePassW);
            ChangePassCom = new RelayCommand(changePass);

        }
        

        // đăng xuất 
        public void logout(object obj)
        {

            UserSeesion.Reset();
            user = null;
            imgSource = null;
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            foreach (Window window in System.Windows.Application.Current.Windows)
            {
                if (window is not LoginWindow)
                {
                    window.Close();
                }
            }
        }
        //dùng để gán lại user vì việc khi đăng xuất uservm không được hủy bỏ nên khi gọi cửa sổ mới dùng chung uservm
        //thì uservm không được khởi tạo lại dẫn đến hàm khỏi tạo không được gọi user không được gán lại
        // hàm này được sử dungjtrong code behind

        // phải tạo bản sao không tham chiếu trực tiếp bởi vì lần chạy đầu tiên cả hàm khởi tạo và hàm reload đều cùng được gọi
        public void reload()
        {
            user = new User
            {
                UserName = UserSeesion.CurrentUser.UserName,
                Email = UserSeesion.CurrentUser.Email,
                Address = UserSeesion.CurrentUser.Address,
                PhoneNumber = UserSeesion.CurrentUser.PhoneNumber,
                age = UserSeesion.CurrentUser.age,
                DisplayName = UserSeesion.CurrentUser.DisplayName,
                sex = UserSeesion.CurrentUser.sex,
                image = UserSeesion.CurrentUser.image,
                Role = UserSeesion.CurrentUser.Role,
            };
            imgSource = new(user.image);
        }

        // chỉnh sửa
        public void EditUser(object obj)
        {
            var userOld = _db.Users.Where(u => u.UserId == UserSeesion.CurrentUser.UserId).FirstOrDefault();
            // So sánh tất cả các thuộc tính xem có khác nhau hay không
            var hasChanges = typeof(User).GetProperties()
                .Any(prop => !Equals(prop.GetValue(user), prop.GetValue(userOld)));
            var sourceImgOld = user.image;
            if (hasChanges)
            {
                
                if (userOld.image != imgSource.ToString())
                {

                    string locateAfter = "C:\\Users\\Son\\source\\repos\\StorageImgQLK\\Nhân Viên\\" + fileName;
                    string locateBefore = imgSource.LocalPath.ToString();
                    System.IO.File.Copy(locateBefore, locateAfter, true);
                    userOld.image = locateAfter;
                }
                
            
                // thay đổi thông tin user
                userOld.UserName = user.UserName;
                userOld.Email = user.Email;
                userOld.Address = user.Address;
                userOld.PhoneNumber = user.PhoneNumber;
                userOld.age = user.age;
                userOld.DisplayName = user.DisplayName;
                userOld.sex = user.sex;
                _db.SaveChanges();
                System.Windows.MessageBox.Show("Bạn đã chỉnh sửa thông tin thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            


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
        // cửa sổ đổimật khẩu
        public void openChangePassW(object obj)
        {
            changePasswordView = new ChangePasswordView();
            changePasswordView.ShowDialog();
            
        }

        // đổi mật khẩu
        public void changePass(object obj)
        {
            if (oldPass == UserSeesion.CurrentUser.Password)
            {
                var userOld = _db.Users.Where(u => u.UserId == UserSeesion.CurrentUser.UserId).FirstOrDefault();
                userOld.Password = newPass;
                _db.SaveChanges();

                System.Windows.MessageBox.Show("lưu mật khẩu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                changePasswordView.Close();
                oldPass = null;
                newPass = null;
            }
            else {
                System.Windows.MessageBox.Show("Mật khẩu cũ không đồng khớp", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

        }
    }
}
