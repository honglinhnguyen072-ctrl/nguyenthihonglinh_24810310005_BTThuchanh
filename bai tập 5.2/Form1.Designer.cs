namespace WinFormsApp2
{
    partial class lstSelectedServices
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
            label = new Label();
            cboCategory = new ComboBox();
            label1 = new Label();
            lsttrai = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            label2 = new Label();
            lstphai = new ListBox();
            label3 = new Label();
            lblTotal = new Label();
            label4 = new Label();
            txtDiscount = new TextBox();
            label5 = new Label();
            lblFinalTotal = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(111, 12);
            label.Name = "label";
            label.Size = new Size(217, 25);
            label.TabIndex = 1;
            label.Text = "quản lý dịch vụ chiết khấu";
            label.Click += label1_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(322, 40);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(182, 33);
            cboCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 87);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 3;
            label1.Text = "Danh sách dịch vụ có sẵn";
            // 
            // lsttrai
            // 
            lsttrai.FormattingEnabled = true;
            lsttrai.Location = new Point(36, 124);
            lsttrai.Name = "lsttrai";
            lsttrai.Size = new Size(180, 54);
            lsttrai.TabIndex = 4;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(402, 144);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(39, 34);
            btnSelect.TabIndex = 5;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(257, 144);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(38, 34);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(322, 144);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(63, 34);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 87);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 8;
            label2.Text = "Danh sách dịch vụ đã chọn";
            // 
            // lstphai
            // 
            lstphai.FormattingEnabled = true;
            lstphai.Location = new Point(493, 124);
            lstphai.Name = "lstphai";
            lstphai.Size = new Size(180, 54);
            lstphai.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 209);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 10;
            label3.Text = "Tổng tiền";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(359, 209);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "0VND";
            lblTotal.Click += lblTotal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 247);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 12;
            label4.Text = "chiết khấu (%)";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(359, 244);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(150, 31);
            txtDiscount.TabIndex = 13;
            txtDiscount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 288);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 14;
            label5.Text = "Thành tiền";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Location = new Point(363, 299);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(22, 25);
            lblFinalTotal.TabIndex = 15;
            lblFinalTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 49);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 16;
            label6.Text = "Loại dịch vụ";
            // 
            // lstSelectedServices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(lblFinalTotal);
            Controls.Add(label5);
            Controls.Add(txtDiscount);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(lstphai);
            Controls.Add(label2);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lsttrai);
            Controls.Add(label1);
            Controls.Add(cboCategory);
            Controls.Add(label);
            Name = "lstSelectedServices";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        private ComboBox cboCategory;
        private Label label1;
        private ListBox lsttrai;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label label2;
        private ListBox lstphai;
        private Label label3;
        private Label lblTotal;
        private Label label4;
        private TextBox txtDiscount;
        private Label label5;
        private Label lblFinalTotal;
        private Label label6;
    }
}
