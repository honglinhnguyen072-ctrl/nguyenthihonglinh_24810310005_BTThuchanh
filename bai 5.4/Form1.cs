using System;
using System.Windows.Forms;

namespace TH_baitap5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            tvDepartments.AfterSelect += new TreeViewEventHandler(tvDepartments_AfterSelect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvEmployees.View = View.Details;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;

            lsvEmployees.Columns.Clear();
            lsvEmployees.Columns.Add("Mã NV", 90, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Họ Tên", 150, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Chức vụ", 130, HorizontalAlignment.Left);
            lsvEmployees.Columns.Add("Ngày vào làm", 110, HorizontalAlignment.Center);

            KhoiTaoCayPhanCap();
        }

        private void KhoiTaoCayPhanCap()
        {
            tvDepartments.Nodes.Clear();

            TreeNode rootNode = new TreeNode("Tập đoàn Công nghệ Alpha");
            rootNode.Tag = "COMPANY";

            TreeNode kyThuat = new TreeNode("Phòng Kỹ thuật");
            kyThuat.Tag = "DEPT_TECH";
            kyThuat.Nodes.Add(new TreeNode("Nhóm Phát triển phần mềm") { Tag = "TEAM_DEV" });
            kyThuat.Nodes.Add(new TreeNode("Nhóm An toàn thông tin") { Tag = "TEAM_SEC" });

            TreeNode kinhDoanh = new TreeNode("Phòng Kinh doanh");
            kinhDoanh.Tag = "DEPT_SALES";
            kinhDoanh.Nodes.Add(new TreeNode("Nhóm Thị trường nội địa") { Tag = "TEAM_DOM" });
            kinhDoanh.Nodes.Add(new TreeNode("Nhóm Xuất nhập khẩu") { Tag = "TEAM_IMP" });

            rootNode.Nodes.Add(kyThuat);
            rootNode.Nodes.Add(kinhDoanh);

            tvDepartments.Nodes.Add(rootNode);
            tvDepartments.ExpandAll();
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsvEmployees.Items.Clear();
            string tagNode = e.Node.Tag?.ToString() ?? "";

            if (tagNode == "TEAM_DEV")
            {
                ThemNhanVien("NV001", "Nguyễn Văn An", "Lập trình viên C#", "12/05/2023");
                ThemNhanVien("NV002", "Trần Thị Bình", "Tester", "18/09/2024");
            }
            else if (tagNode == "TEAM_SEC")
            {
                ThemNhanVien("NV003", "Lê Hoàng Cường", "Chuyên gia bảo mật", "01/03/2022");
                ThemNhanVien("NV004", "Phạm Quỳnh Mai", "Kiểm toán hệ thống", "20/11/2025");
            }
            else if (tagNode == "TEAM_DOM")
            {
                ThemNhanVien("NV005", "Hoàng Văn Dũng", "Nhân viên Sales", "10/07/2023");
            }
            else if (tagNode == "TEAM_IMP")
            {
                ThemNhanVien("NV006", "Vũ Thu Hương", "Quản lý logistics", "05/01/2021");
            }
        }

        private void ThemNhanVien(string ma, string hoten, string chucvu, string ngayvao)
        {
            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(hoten);
            item.SubItems.Add(chucvu);
            item.SubItems.Add(ngayvao);
            lsvEmployees.Items.Add(item);
        }
    }
}