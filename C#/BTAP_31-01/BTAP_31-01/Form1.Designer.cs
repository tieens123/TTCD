namespace BTAP_31_01
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
            this.cboTenSach = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstSachDaMua = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTenSach);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.lbSL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTenSach);
            this.groupBox1.Location = new System.Drawing.Point(65, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn sách";
            // 
            // cboTenSach
            // 
            this.cboTenSach.FormattingEnabled = true;
            this.cboTenSach.Items.AddRange(new object[] {
            "tin đại cương",
            "tiếng anh f2",
            "giải tích f1",
            "đại số tuyến tính"});
            this.cboTenSach.Location = new System.Drawing.Point(87, 17);
            this.cboTenSach.Name = "cboTenSach";
            this.cboTenSach.Size = new System.Drawing.Size(112, 21);
            this.cboTenSach.TabIndex = 6;
            this.cboTenSach.SelectedIndexChanged += new System.EventHandler(this.cbbTenSach_SelectedIndexChanged);
            this.cboTenSach.TextChanged += new System.EventHandler(this.cboTenSach_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(87, 83);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(103, 20);
            this.txtSL.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(87, 52);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(103, 20);
            this.txtGia.TabIndex = 4;
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(16, 90);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(47, 13);
            this.lbSL.TabIndex = 2;
            this.lbSL.Text = "số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "giá";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Location = new System.Drawing.Point(16, 25);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(48, 13);
            this.lbTenSach.TabIndex = 0;
            this.lbTenSach.Text = "tên sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.txtSale);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(486, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "phương thức thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(133, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "thẻ ATM";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "tiền mặt";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtSale
            // 
            this.txtSale.Enabled = false;
            this.txtSale.Location = new System.Drawing.Point(115, 68);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(103, 20);
            this.txtSale.TabIndex = 6;
            this.txtSale.TextChanged += new System.EventHandler(this.txtSale_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "giản giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTT);
            this.groupBox3.Controls.Add(this.lstSachDaMua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnTT);
            this.groupBox3.Location = new System.Drawing.Point(188, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 125);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "sách đã mua";
            // 
            // lstSachDaMua
            // 
            this.lstSachDaMua.FormattingEnabled = true;
            this.lstSachDaMua.Location = new System.Drawing.Point(14, 16);
            this.lstSachDaMua.Name = "lstSachDaMua";
            this.lstSachDaMua.Size = new System.Drawing.Size(352, 56);
            this.lstSachDaMua.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 87);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(149, 87);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(102, 32);
            this.btnTT.TabIndex = 4;
            this.btnTT.Text = "tính tồng tiền";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(323, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(658, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTT
            // 
            this.txtTT.Enabled = false;
            this.txtTT.Location = new System.Drawing.Point(263, 87);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(103, 20);
            this.txtTT.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboTenSach;
        private System.Windows.Forms.ListBox lstSachDaMua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTT;
    }
}

