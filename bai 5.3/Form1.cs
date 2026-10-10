using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TH_baitap5._3
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }

    public partial class Form1 : Form
    {
        private List<Product> listProducts = new List<Product>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            btnThem.Click += new EventHandler(btnThem_Click);
            btnSua.Click += new EventHandler(btnSua_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnTimKiem.Click += new EventHandler(btnTimKiem_Click);
            dgvProducts.CellClick += new DataGridViewCellEventHandler(dgvProducts_CellClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDanhMuc.Items.Clear();
            cmbDanhMuc.Items.AddRange(new string[] { "Điện thoại", "Laptop", "Phụ kiện", "Khác" });
            cmbDanhMuc.SelectedIndex = 0;

            bindingSource.DataSource = listProducts;
            dgvProducts.DataSource = bindingSource;

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Mã SP và Tên SP không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listProducts.Any(p => p.ProductId == txtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product newProduct = new Product
            {
                ProductId = txtMaSP.Text,
                ProductName = txtTenSP.Text,
                UnitPrice = decimal.TryParse(txtDonGia.Text, out decimal price) ? price : 0,
                Quantity = int.TryParse(txtSoLuong.Text, out int qty) ? qty : 0,
                Category = cmbDanhMuc.SelectedItem?.ToString() ?? ""
            };

            listProducts.Add(newProduct);
            ResetBindings();
            ClearInputs();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listProducts.Count)
            {
                Product selectedProduct = (Product)bindingSource[e.RowIndex];

                txtMaSP.Text = selectedProduct.ProductId;
                txtTenSP.Text = selectedProduct.ProductName;
                txtDonGia.Text = selectedProduct.UnitPrice.ToString();
                txtSoLuong.Text = selectedProduct.Quantity.ToString();
                cmbDanhMuc.SelectedItem = selectedProduct.Category;

                txtMaSP.Enabled = false; // Khóa Mã SP không cho sửa
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product productToEdit = listProducts.FirstOrDefault(p => p.ProductId == txtMaSP.Text);
            if (productToEdit != null)
            {
                productToEdit.ProductName = txtTenSP.Text;
                productToEdit.UnitPrice = decimal.TryParse(txtDonGia.Text, out decimal price) ? price : 0;
                productToEdit.Quantity = int.TryParse(txtSoLuong.Text, out int qty) ? qty : 0;
                productToEdit.Category = cmbDanhMuc.SelectedItem?.ToString() ?? "";

                ResetBindings();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.Index >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Product selectedProduct = (Product)bindingSource[dgvProducts.CurrentRow.Index];
                    listProducts.Remove(selectedProduct);
                    ResetBindings();
                    ClearInputs();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                bindingSource.DataSource = listProducts;
            }
            else
            {
                var filteredList = listProducts.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                bindingSource.DataSource = filteredList;
            }
            bindingSource.ResetBindings(false);
        }

        private void ResetBindings()
        {
            bindingSource.DataSource = null;
            bindingSource.DataSource = listProducts;
        }

        private void ClearInputs()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            cmbDanhMuc.SelectedIndex = 0;
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
        }
    }
}