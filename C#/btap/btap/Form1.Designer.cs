namespace btap
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMKH = new System.Windows.Forms.Label();
            this.lbHTKH = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbTienGui = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.txtHTKH = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTienGui = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbThuong = new System.Windows.Forms.RadioButton();
            this.rbPl = new System.Windows.Forms.RadioButton();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrTGG = new System.Windows.Forms.NumericUpDown();
            this.lsbDSKH = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTGG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrTGG);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtNgayGui);
            this.groupBox1.Controls.Add(this.txtTienGui);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtHTKH);
            this.groupBox1.Controls.Add(this.txtMKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbTienGui);
            this.groupBox1.Controls.Add(this.lbDC);
            this.groupBox1.Controls.Add(this.lbHTKH);
            this.groupBox1.Controls.Add(this.lbMKH);
            this.groupBox1.Location = new System.Drawing.Point(26, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbDSKH);
            this.groupBox2.Location = new System.Drawing.Point(364, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách khách hàng";
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Location = new System.Drawing.Point(20, 19);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(39, 13);
            this.lbMKH.TabIndex = 0;
            this.lbMKH.Text = "mã KH";
            // 
            // lbHTKH
            // 
            this.lbHTKH.AutoSize = true;
            this.lbHTKH.Location = new System.Drawing.Point(20, 49);
            this.lbHTKH.Name = "lbHTKH";
            this.lbHTKH.Size = new System.Drawing.Size(55, 13);
            this.lbHTKH.TabIndex = 1;
            this.lbHTKH.Text = "họ tên KH";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Location = new System.Drawing.Point(20, 74);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(39, 13);
            this.lbDC.TabIndex = 2;
            this.lbDC.Text = "địa chỉ";
            // 
            // lbTienGui
            // 
            this.lbTienGui.AutoSize = true;
            this.lbTienGui.Location = new System.Drawing.Point(20, 113);
            this.lbTienGui.Name = "lbTienGui";
            this.lbTienGui.Size = new System.Drawing.Size(55, 13);
            this.lbTienGui.TabIndex = 3;
            this.lbTienGui.Text = "số tiền gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ngày gửi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "thời gian gửi";
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(101, 16);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(152, 20);
            this.txtMKH.TabIndex = 6;
            this.txtMKH.TextChanged += new System.EventHandler(this.txtMKH_TextChanged);
            this.txtMKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKH_KeyPress);
            // 
            // txtHTKH
            // 
            this.txtHTKH.Location = new System.Drawing.Point(101, 42);
            this.txtHTKH.Name = "txtHTKH";
            this.txtHTKH.Size = new System.Drawing.Size(152, 20);
            this.txtHTKH.TabIndex = 7;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(101, 74);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(152, 20);
            this.txtDC.TabIndex = 8;
            // 
            // txtTienGui
            // 
            this.txtTienGui.Location = new System.Drawing.Point(101, 110);
            this.txtTienGui.Name = "txtTienGui";
            this.txtTienGui.Size = new System.Drawing.Size(97, 20);
            this.txtTienGui.TabIndex = 9;
            this.txtTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienGui_KeyPress);
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Location = new System.Drawing.Point(101, 147);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(152, 20);
            this.txtNgayGui.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPl);
            this.groupBox3.Controls.Add(this.rbThuong);
            this.groupBox3.Location = new System.Drawing.Point(23, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 48);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "loại tiết kiệm";
            // 
            // rbThuong
            // 
            this.rbThuong.AutoSize = true;
            this.rbThuong.Location = new System.Drawing.Point(24, 18);
            this.rbThuong.Name = "rbThuong";
            this.rbThuong.Size = new System.Drawing.Size(61, 17);
            this.rbThuong.TabIndex = 0;
            this.rbThuong.TabStop = true;
            this.rbThuong.Text = "thường ";
            this.rbThuong.UseVisualStyleBackColor = true;
            // 
            // rbPl
            // 
            this.rbPl.AutoSize = true;
            this.rbPl.Location = new System.Drawing.Point(138, 17);
            this.rbPl.Name = "rbPl";
            this.rbPl.Size = new System.Drawing.Size(63, 17);
            this.rbPl.TabIndex = 1;
            this.rbPl.TabStop = true;
            this.rbPl.Text = "phát lộc";
            this.rbPl.UseVisualStyleBackColor = true;
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(28, 266);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(104, 22);
            this.btnThemVaoDS.TabIndex = 13;
            this.btnThemVaoDS.Text = "thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(170, 266);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(104, 22);
            this.btnThemMoi.TabIndex = 14;
            this.btnThemMoi.Text = "thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 22);
            this.button3.TabIndex = 15;
            this.button3.Text = "tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 22);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(tháng)";
            // 
            // nmrTGG
            // 
            this.nmrTGG.Location = new System.Drawing.Point(103, 189);
            this.nmrTGG.Name = "nmrTGG";
            this.nmrTGG.Size = new System.Drawing.Size(104, 20);
            this.nmrTGG.TabIndex = 17;
            // 
            // lsbDSKH
            // 
            this.lsbDSKH.FormattingEnabled = true;
            this.lsbDSKH.Location = new System.Drawing.Point(10, 24);
            this.lsbDSKH.Name = "lsbDSKH";
            this.lsbDSKH.Size = new System.Drawing.Size(399, 212);
            this.lsbDSKH.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(819, 315);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "tính lãi suất tiền gửi tiết kiệm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTGG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrTGG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPl;
        private System.Windows.Forms.RadioButton rbThuong;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.TextBox txtTienGui;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtHTKH;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTienGui;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbHTKH;
        private System.Windows.Forms.Label lbMKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lsbDSKH;
    }
}

