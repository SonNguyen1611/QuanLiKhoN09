using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using QuanLyKhoPJ.Model;
using QuanLyKhoPJ.View.Manage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace QuanLyKhoPJ.ViewModel
{
    public class AdminManageViewModel : BaseViewModel
    {
        public AddUser addUser { get; set; }    
        public Uri  _imgSource { get; set; }
        public Uri imgSource
        {
            get { return _imgSource; }
            set
            {
                _imgSource = value;
                OnPropertyChanged();
            }
        }
        public string _selectedSex { get; set; }
        public string selectedSex
        {
            get { return _selectedSex; }
            set
            {
                _selectedSex = value;
                OnPropertyChanged();
            }
        }
        public Role _selectedRole { get; set; }
        public Role selectedRole
        {
            get { return _selectedRole; }
            set
            {
                _selectedRole = value;
                OnPropertyChanged();
            }
        }
        public User _selectedUser { get; set; }
        public User selectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<User> _users;

        public ObservableCollection<User> users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }
        private User _user;

        public User user
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Role> _roles;

        public ObservableCollection<Role> roles
        {
            get { return _roles; }
            set
            {
                _roles = value;
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
        private string _keySearch;

        public string keySearch
        {
            get { return _keySearch; }
            set
            {
                _keySearch = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoadImageCom { get; set; }
        public ICommand OpenAddUserCom { get; set; }
        public ICommand CloseAddUserCom { get; set; }
        public ICommand SaveUserCom { get; set; }
        public ICommand DelUserCom { get; set; }
        public ICommand SearchUserByNameCom { get; set; }

        public AdminManageViewModel()
        {
            returnObsUser();
            LoadImageCom = new RelayCommand(loadImage);
            OpenAddUserCom = new RelayCommand(openAddUser);
            SaveUserCom = new RelayCommand(saveUser);
            DelUserCom = new RelayCommand(deleteUser);
            CloseAddUserCom = new RelayCommand(closeAddUser);
            SearchUserByNameCom = new RelayCommand(searchUserByName);
        }

        //lấy toàn bộ users
        public void returnObsUser()
        {
            var listUser = _db.Users.Include(u => u.Role).ToList();
            users = new ObservableCollection<User>(listUser);
        }
        // laod ảnh lên
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
        
        // mở form add 
        public void openAddUser(object obj)
        {
            addUser = new AddUser();
            user = new User();
            returnObsRole();
            addUser.ShowDialog(); 

                    
        }
        // Nút cancel trong form
        public void closeAddUser(object obj)
        {
            addUser.Close();

        }
        // lấy lên toàn bộ role
        public void returnObsRole()
        {
            var listRole = _db.Roles.ToList();
            roles = new ObservableCollection<Role>(listRole);
        }
        // lưu tài khoản
        public void saveUser(object obj)
        {
            //vị trí đích
            string locateAfter = "C:\\Users\\Son\\source\\repos\\StorageImgQLK\\Nhân Viên\\" + fileName;

            // vị trí ban đầu
            string locateBefore = imgSource.LocalPath.ToString();
            //copy file từ vị trí ban đầu vào vị trí mới( chức năng lưu ảnh)
            System.IO.File.Copy(locateBefore, locateAfter,true);

            var newUser = new User
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                age = user.age,
                UserName = user.UserName,
                Password = user.Password,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                sex = selectedSex,
                Role = selectedRole,
                image = locateAfter,
                 
            };
            users.Add(newUser);
            _db.Users.Add(newUser);
            _db.SaveChanges();
            System.Windows.MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        // xóa tài khoản 
        public void deleteUser(object obj)
        {
            var userDel = new User();
            userDel = selectedUser;
            users.Remove(userDel);
            _db.Users.Remove(userDel);
            _db.SaveChanges();
            System.Windows.MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information); 
        }
        // tìm kiếm 
        public void searchUserByName(object obj)
        {
           
            if (keySearch != null)
            {
                List<User> listUserSearch = (from s in _db.Users
                                                   where s.DisplayName.Contains(keySearch)
                                                   select s).ToList();
               
                users = new ObservableCollection<User>(listUserSearch);
            }
            else
            {
                List<User> listUserSearch = _db.Users.ToList();
                users = new ObservableCollection<User>(listUserSearch);
            }
        }
        

    }
}
