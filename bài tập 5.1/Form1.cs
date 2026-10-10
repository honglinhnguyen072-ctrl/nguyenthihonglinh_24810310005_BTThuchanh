using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            // 1. Xóa toàn bộ biểu tượng lỗi cũ
            epcheck.Clear();
            bool isvalid = true;

            // 2. Kiểm tra Tên đăng nhập không được để trống
            if (string.IsNullOrWhiteSpace(txtTendangnhap.Text))
            {
                epcheck.SetError(txtTendangnhap, "Tên đăng nhập không được để trống!");
                isvalid = false;
            }

            // 3. Kiểm tra Mật khẩu không được để trống
            if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
            {
                epcheck.SetError(txtmatkhau, "Mật khẩu không được để trống!");
                isvalid = false;
            }

            // 4. Kiểm tra Mật khẩu xác nhận phải trùng với Mật khẩu
            if (txtmatkhau.Text != txtxacnhanmk.Text)
            {
                epcheck.SetError(txtxacnhanmk, "Mật khẩu xác nhận không khớp!");
                isvalid = false;
            }

            // 5. Kiểm tra độ tuổi (phải từ 18 tuổi trở lên)
            int age = DateTime.Today.Year - dtpngaysinh.Value.Year;
            if (dtpngaysinh.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                epcheck.SetError(dtpngaysinh, "Bạn phải từ 18 tuổi trở lên mới được đăng ký!");
                isvalid = false;
            }

            // 6. Kiểm tra đã tích đồng ý điều khoản dịch vụ chưa
            if (!chkDieukhoan.Checked)
            {
                epcheck.SetError(chkDieukhoan, "Bạn phải đồng ý với điều khoản dịch vụ!");
                isvalid = false;
            }

            // 7. Thông báo khi tất cả thông tin hợp lệ
            if (isvalid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong các ô nhập liệu
            txtTendangnhap.Clear();
            txtmatkhau.Clear();
            txtxacnhanmk.Clear();

            // Khôi phục ngày sinh về ngày hiện tại
            dtpngaysinh.Value = DateTime.Today;

            // Bỏ chọn điều khoản và xóa các cờ báo lỗi
            chkDieukhoan.Checked = false;
            epcheck.Clear();

            // Đưa con trỏ quay lại ô Tên đăng nhập
            txtTendangnhap.Focus();
        }
    }
}