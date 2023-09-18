namespace ktra1201
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.lsbDSKH = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtNgayChot = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtHTKH = new System.Windows.Forms.TextBox();
            this.txtMKH = new System.Windows.Forms.TextBox();
            this.lbSTT = new System.Windows.Forms.Label();
            this.lbNgayChot = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbHTKH = new System.Windows.Forms.Label();
            this.lbMKH = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSTN = new System.Windows.Forms.TextBox();
            this.lbSTN = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(647, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 22);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // lsbDSKH
            // 
            this.lsbDSKH.FormattingEnabled = true;
            this.lsbDSKH.Location = new System.Drawing.Point(10, 24);
            this.lsbDSKH.Name = "lsbDSKH";
            this.lsbDSKH.Size = new System.Drawing.Size(399, 212);
            this.lsbDSKH.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbDSKH);
            this.groupBox2.Location = new System.Drawing.Point(350, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 246);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách khách hàng";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(101, 147);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(97, 20);
            this.txtSTT.TabIndex = 10;
            this.txtSTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTT_KeyPress);
            // 
            // txtNgayChot
            // 
            this.txtNgayChot.Location = new System.Drawing.Point(101, 110);
            this.txtNgayChot.Name = "txtNgayChot";
            this.txtNgayChot.Size = new System.Drawing.Size(97, 20);
            this.txtNgayChot.TabIndex = 9;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(101, 74);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(200, 20);
            this.txtDC.TabIndex = 8;
            // 
            // txtHTKH
            // 
            this.txtHTKH.Location = new System.Drawing.Point(101, 42);
            this.txtHTKH.Name = "txtHTKH";
            this.txtHTKH.Size = new System.Drawing.Size(213, 20);
            this.txtHTKH.TabIndex = 7;
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(101, 16);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(78, 20);
            this.txtMKH.TabIndex = 6;
            this.txtMKH.TextChanged += new System.EventHandler(this.txtMKH_TextChanged);
            this.txtMKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKH_KeyPress);
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Location = new System.Drawing.Point(20, 154);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(77, 13);
            this.lbSTT.TabIndex = 4;
            this.lbSTT.Text = "Số tháng trước";
            // 
            // lbNgayChot
            // 
            this.lbNgayChot.AutoSize = true;
            this.lbNgayChot.Location = new System.Drawing.Point(20, 113);
            this.lbNgayChot.Name = "lbNgayChot";
            this.lbNgayChot.Size = new System.Drawing.Size(70, 13);
            this.lbNgayChot.TabIndex = 3;
            this.lbNgayChot.Text = "Ngày chốt sổ";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Location = new System.Drawing.Point(20, 74);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(40, 13);
            this.lbDC.TabIndex = 2;
            this.lbDC.Text = "Địa chỉ";
            // 
            // lbHTKH
            // 
            this.lbHTKH.AutoSize = true;
            this.lbHTKH.Location = new System.Drawing.Point(20, 49);
            this.lbHTKH.Name = "lbHTKH";
            this.lbHTKH.Size = new System.Drawing.Size(57, 13);
            this.lbHTKH.TabIndex = 1;
            this.lbHTKH.Text = "Họ tên KH";
            // 
            // lbMKH
            // 
            this.lbMKH.AutoSize = true;
            this.lbMKH.Location = new System.Drawing.Point(20, 19);
            this.lbMKH.Name = "lbMKH";
            this.lbMKH.Size = new System.Drawing.Size(40, 13);
            this.lbMKH.TabIndex = 0;
            this.lbMKH.Text = "Mã KH";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 22);
            this.button3.TabIndex = 19;
            this.button3.Text = "tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSTN);
            this.groupBox1.Controls.Add(this.lbSTN);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.txtSTT);
            this.groupBox1.Controls.Add(this.txtNgayChot);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtHTKH);
            this.groupBox1.Controls.Add(this.txtMKH);
            this.groupBox1.Controls.Add(this.lbSTT);
            this.groupBox1.Controls.Add(this.lbNgayChot);
            this.groupBox1.Controls.Add(this.lbDC);
            this.groupBox1.Controls.Add(this.lbHTKH);
            this.groupBox1.Controls.Add(this.lbMKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 303);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // txtSTN
            // 
            this.txtSTN.Location = new System.Drawing.Point(101, 183);
            this.txtSTN.Name = "txtSTN";
            this.txtSTN.Size = new System.Drawing.Size(97, 20);
            this.txtSTN.TabIndex = 16;
            this.txtSTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTN_KeyPress);
            // 
            // lbSTN
            // 
            this.lbSTN.AutoSize = true;
            this.lbSTN.Location = new System.Drawing.Point(20, 190);
            this.lbSTN.Name = "lbSTN";
            this.lbSTN.Size = new System.Drawing.Size(70, 13);
            this.lbSTN.TabIndex = 15;
            this.lbSTN.Text = "Số tháng này";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "tính lãi suất gửi tiết kiệm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.ListBox lsbDSKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtNgayChot;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtHTKH;
        private System.Windows.Forms.TextBox txtMKH;
        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.Label lbNgayChot;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbHTKH;
        private System.Windows.Forms.Label lbMKH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSTN;
        private System.Windows.Forms.Label lbSTN;
    }
}

