namespace BTNV
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
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.bt_kqua = new System.Windows.Forms.Button();
            this.bt_llai = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(338, 86);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(224, 20);
            this.txt_thang.TabIndex = 0;
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(338, 138);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(224, 20);
            this.txt_nam.TabIndex = 1;
            // 
            // bt_kqua
            // 
            this.bt_kqua.Location = new System.Drawing.Point(200, 235);
            this.bt_kqua.Name = "bt_kqua";
            this.bt_kqua.Size = new System.Drawing.Size(115, 48);
            this.bt_kqua.TabIndex = 2;
            this.bt_kqua.Text = "Kết quả";
            this.bt_kqua.UseVisualStyleBackColor = true;
            this.bt_kqua.Click += new System.EventHandler(this.bt_kqua_Click);
            // 
            // bt_llai
            // 
            this.bt_llai.Location = new System.Drawing.Point(379, 235);
            this.bt_llai.Name = "bt_llai";
            this.bt_llai.Size = new System.Drawing.Size(107, 48);
            this.bt_llai.TabIndex = 3;
            this.bt_llai.Text = "Làm lại";
            this.bt_llai.UseVisualStyleBackColor = true;
            this.bt_llai.Click += new System.EventHandler(this.bt_llai_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(551, 235);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(107, 48);
            this.bt_thoat.TabIndex = 4;
            this.bt_thoat.Text = "Thát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(190, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 13);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "nhập tháng :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(190, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(65, 13);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "nhập năm :";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Yellow;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(162, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 13);
            this.textBox5.TabIndex = 7;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(187, 199);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 8;
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(670, 312);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_llai);
            this.Controls.Add(this.bt_kqua);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.txt_thang);
            this.Name = "Form1";
            this.Text = "Chương trình tính số ngày trong tháng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Button bt_kqua;
        private System.Windows.Forms.Button bt_llai;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbResult;
    }
}

