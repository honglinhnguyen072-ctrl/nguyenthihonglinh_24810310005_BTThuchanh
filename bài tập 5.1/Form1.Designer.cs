namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTendangnhap = new TextBox();
            label2 = new Label();
            txtmatkhau = new TextBox();
            txtxacnhanmk = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            dtpngaysinh = new DateTimePicker();
            radnam = new RadioButton();
            radnu = new RadioButton();
            chkDieukhoan = new CheckBox();
            epcheck = new ErrorProvider(components);
            btndangki = new Button();
            btnlammoi = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epcheck).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "tên đăng nhập";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(175, 24);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(150, 31);
            txtTendangnhap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "mật khẩu";
            label2.Click += label2_Click;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(183, 75);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(150, 31);
            txtmatkhau.TabIndex = 3;
            // 
            // txtxacnhanmk
            // 
            txtxacnhanmk.Location = new Point(186, 136);
            txtxacnhanmk.Name = "txtxacnhanmk";
            txtxacnhanmk.Size = new Size(150, 31);
            txtxacnhanmk.TabIndex = 4;
            txtxacnhanmk.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 138);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 5;
            label3.Text = "xac nhận mật khẩu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkDieukhoan);
            groupBox1.Controls.Add(radnu);
            groupBox1.Controls.Add(radnam);
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(373, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 159);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "thong tin bo sung";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 36);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 74);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 1;
            label5.Text = "giới tinh";
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(102, 38);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(300, 31);
            dtpngaysinh.TabIndex = 2;
            // 
            // radnam
            // 
            radnam.AutoSize = true;
            radnam.Location = new Point(119, 78);
            radnam.Name = "radnam";
            radnam.Size = new Size(72, 29);
            radnam.TabIndex = 3;
            radnam.TabStop = true;
            radnam.Text = "nam";
            radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            radnu.AutoSize = true;
            radnu.Location = new Point(212, 87);
            radnu.Name = "radnu";
            radnu.Size = new Size(58, 29);
            radnu.TabIndex = 7;
            radnu.TabStop = true;
            radnu.Text = "nữ";
            radnu.UseVisualStyleBackColor = true;
            // 
            // chkDieukhoan
            // 
            chkDieukhoan.AutoSize = true;
            chkDieukhoan.Location = new Point(30, 121);
            chkDieukhoan.Name = "chkDieukhoan";
            chkDieukhoan.Size = new Size(305, 29);
            chkDieukhoan.TabIndex = 8;
            chkDieukhoan.Text = "tôi đòng ý với điều khoản dịch vụ";
            chkDieukhoan.UseVisualStyleBackColor = true;
            // 
            // epcheck
            // 
            epcheck.ContainerControl = this;
            // 
            // btndangki
            // 
            btndangki.Location = new Point(45, 209);
            btndangki.Name = "btndangki";
            btndangki.Size = new Size(112, 34);
            btndangki.TabIndex = 7;
            btndangki.Text = "đăngkí";
            btndangki.UseVisualStyleBackColor = true;
            btndangki.Click += btndangki_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(210, 213);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(112, 34);
            btnlammoi.TabIndex = 8;
            btnlammoi.Text = "làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlammoi);
            Controls.Add(btndangki);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtxacnhanmk);
            Controls.Add(txtmatkhau);
            Controls.Add(label2);
            Controls.Add(txtTendangnhap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epcheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTendangnhap;
        private Label label2;
        private TextBox txtmatkhau;
        private TextBox txtxacnhanmk;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker dtpngaysinh;
        private Label label5;
        private Label label4;
        private CheckBox chkDieukhoan;
        private RadioButton radnu;
        private RadioButton radnam;
        private ErrorProvider epcheck;
        private Button btnlammoi;
        private Button btndangki;
    }
}
