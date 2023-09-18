namespace bai4
{
    partial class oooo
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnKQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbTru = new System.Windows.Forms.RadioButton();
            this.rbCong = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKQ);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.btnKQ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(210, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(129, 82);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(105, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(129, 52);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(105, 20);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSoB_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(129, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(105, 20);
            this.txtA.TabIndex = 3;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSoA_KeyPress);
            // 
            // btnKQ
            // 
            this.btnKQ.AutoSize = true;
            this.btnKQ.Location = new System.Drawing.Point(25, 89);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(43, 13);
            this.btnKQ.TabIndex = 2;
            this.btnKQ.Text = "kết quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbChia);
            this.groupBox2.Controls.Add(this.rbNhan);
            this.groupBox2.Controls.Add(this.rbTru);
            this.groupBox2.Controls.Add(this.rbCong);
            this.groupBox2.Location = new System.Drawing.Point(55, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "phép tính";
            // 
            // rbChia
            // 
            this.rbChia.AutoSize = true;
            this.rbChia.Location = new System.Drawing.Point(22, 95);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(45, 17);
            this.rbChia.TabIndex = 3;
            this.rbChia.TabStop = true;
            this.rbChia.Text = "chia";
            this.rbChia.UseVisualStyleBackColor = true;
            this.rbChia.CheckedChanged += new System.EventHandler(this.rbChia_CheckedChanged);
            // 
            // rbNhan
            // 
            this.rbNhan.AutoSize = true;
            this.rbNhan.Location = new System.Drawing.Point(22, 65);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(49, 17);
            this.rbNhan.TabIndex = 2;
            this.rbNhan.TabStop = true;
            this.rbNhan.Text = "nhân";
            this.rbNhan.UseVisualStyleBackColor = true;
            this.rbNhan.CheckedChanged += new System.EventHandler(this.rbNhan_CheckedChanged);
            // 
            // rbTru
            // 
            this.rbTru.AutoSize = true;
            this.rbTru.Location = new System.Drawing.Point(22, 42);
            this.rbTru.Name = "rbTru";
            this.rbTru.Size = new System.Drawing.Size(37, 17);
            this.rbTru.TabIndex = 1;
            this.rbTru.TabStop = true;
            this.rbTru.Text = "trừ";
            this.rbTru.UseVisualStyleBackColor = true;
            this.rbTru.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbCong
            // 
            this.rbCong.AutoSize = true;
            this.rbCong.Location = new System.Drawing.Point(22, 19);
            this.rbCong.Name = "rbCong";
            this.rbCong.Size = new System.Drawing.Size(49, 17);
            this.rbCong.TabIndex = 0;
            this.rbCong.TabStop = true;
            this.rbCong.Text = "cộng";
            this.rbCong.UseVisualStyleBackColor = true;
            this.rbCong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(404, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 118);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "so sánh";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "min";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "max";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // oooo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "oooo";
            this.Text = "chương trình tính toán";
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
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label btnKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbChia;
        private System.Windows.Forms.RadioButton rbNhan;
        private System.Windows.Forms.RadioButton rbTru;
        private System.Windows.Forms.RadioButton rbCong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

