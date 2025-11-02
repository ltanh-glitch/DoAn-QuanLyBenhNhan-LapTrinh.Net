using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBenhNhan.Common
{
    public static class UserSession
    {
        // Lưu trữ tên đăng nhập
        public static string TenDangNhap { get; private set; }

        // Lưu trữ Vai Trò: 0=Admin, 1=User
        public static int VaiTro { get; private set; }

        /// <summary>
        /// Thiết lập thông tin người dùng sau khi đăng nhập.
        /// </summary>
        public static void SetCurrentUser(string username, int role)
        {
            TenDangNhap = username;
            VaiTro = role;
        }

        /// <summary>
        /// Kiểm tra xem người dùng hiện tại có phải là Admin (VaiTro = 0) hay không.
        /// </summary>
        public static bool IsAdmin
        {
            get { return VaiTro == 0; }
        }

        /// <summary>
        /// Xóa thông tin khi đăng xuất.
        /// </summary>
        public static void Logout()
        {
            TenDangNhap = null;
            VaiTro = -1; // Đặt về giá trị không hợp lệ
        }
    }
}
