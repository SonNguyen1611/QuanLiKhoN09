using QuanLyKhoPJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ
{
    // tạo lớp chứa dữ liệu user trong phiên làm việc
    public static  class UserSeesion
    {
        public static User CurrentUser { get; set; }
        public static void Reset()
        {
            // reset lại
            CurrentUser = null;
            
        }
    }
}
