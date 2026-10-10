using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class lstSelectedServices : Form
    {
        public lstSelectedServices()
        {
            InitializeComponent();

            // Đăng ký các sự kiện (có thể gán qua đây hoặc qua tab Events trong cửa sổ Properties)
            this.Load += lstSelectedServices_Load;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            btnSelect.Click += btnSelect_Click;
            lsttrai.DoubleClick += lsttrai_DoubleClick;
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Click += btnClearAll_Click;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
        }

        // 1. Khi Form khởi động
        private void lstSelectedServices_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Add("Khám bệnh");
            cboCategory.Items.Add("Xét nghiệm");
            cboCategory.Items.Add("Chụp X-Quang");
            cboCategory.Items.Add("Vắc-xin");

            cboCategory.SelectedIndex = 0;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // 2. Khi thay đổi mục chọn trên ComboBox
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsttrai.Items.Clear();
            if (cboCategory.SelectedItem == null) return;
            string selectedCategory = cboCategory.SelectedItem.ToString();

            if (selectedCategory == "Khám bệnh")
            {
                lsttrai.Items.Add(new ServiceItem { Name = "Khám tổng quát", Price = 200000 });
                lsttrai.Items.Add(new ServiceItem { Name = "Khám chuyên khoa", Price = 300000 });
            }
            else if (selectedCategory == "Xét nghiệm")
            {
                lsttrai.Items.Add(new ServiceItem { Name = "Xét nghiệm máu", Price = 150000 });
                lsttrai.Items.Add(new ServiceItem { Name = "Xét nghiệm nước tiểu", Price = 80000 });
            }
            else if (selectedCategory == "Chụp X-Quang")
            {
                lsttrai.Items.Add(new ServiceItem { Name = "X-Quang phổi", Price = 250000 });
                lsttrai.Items.Add(new ServiceItem { Name = "X-Quang cột sống", Price = 350000 });
            }
            else if (selectedCategory == "Vắc-xin")
            {
                lsttrai.Items.Add(new ServiceItem { Name = "Vắc-xin cúm", Price = 300000 });
                lsttrai.Items.Add(new ServiceItem { Name = "Vắc-xin viêm gan B", Price = 200000 });
            }
        }

        // Hàm hỗ trợ chuyển dịch vụ sang danh sách đã chọn
        private void MoveService()
        {
            if (lsttrai.SelectedItem != null)
            {
                var item = lsttrai.SelectedItem;
                lstphai.Items.Add(item);
                CalculateTotal();
            }
        }

        // 3. Nút chuyển qua phải (>)
        private void btnSelect_Click(object sender, EventArgs e)
        {
            MoveService();
        }

        // Double click vào danh sách bên trái
        private void lsttrai_DoubleClick(object sender, EventArgs e)
        {
            MoveService();
        }

        // 4. Nút xóa 1 mục khỏi danh sách đã chọn (<)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstphai.SelectedItem != null)
            {
                lstphai.Items.Remove(lstphai.SelectedItem);
                CalculateTotal();
            }
        }

        // 5. Nút xóa tất cả danh sách đã chọn (<<)
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstphai.Items.Clear();
            CalculateTotal();
        }

        // 6. Hàm tính tổng tiền và chiết khấu
        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in lstphai.Items)
            {
                if (item is ServiceItem service)
                {
                    total += service.Price;
                }
            }

            decimal discountPercent = 0;
            decimal.TryParse(txtDiscount.Text, out discountPercent);

            decimal finalTotal = total - (total * discountPercent / 100);

            lblTotal.Text = total.ToString("N0") + " VNĐ";
            lblFinalTotal.Text = finalTotal.ToString("N0") + " VNĐ";
        }

        // Sự kiện khi thay đổi % chiết khấu
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
    }

    // Lớp phụ trợ lưu tên và đơn giá dịch vụ
    public class ServiceItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:N0} VNĐ";
        }
    }
}