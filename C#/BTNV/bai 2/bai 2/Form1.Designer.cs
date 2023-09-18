namespace bai_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ldKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(246, 50);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(155, 20);
            this.txtSoA.TabIndex = 3;
            this.txtSoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(246, 98);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(155, 20);
            this.txtSoB.TabIndex = 4;
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(111, 213);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(80, 50);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLlai
            // 
            this.btnLlai.Location = new System.Drawing.Point(256, 213);
            this.btnLlai.Name = "btnLlai";
            this.btnLlai.Size = new System.Drawing.Size(80, 50);
            this.btnLlai.TabIndex = 6;
            this.btnLlai.Text = "làm lại";
            this.btnLlai.UseVisualStyleBackColor = true;
            this.btnLlai.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(396, 213);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(583, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "nhập số nguyên";
            // 
            // ldKQ
            // 
            this.ldKQ.AutoSize = true;
            this.ldKQ.Location = new System.Drawing.Point(108, 159);
            this.ldKQ.Name = "ldKQ";
            this.ldKQ.Size = new System.Drawing.Size(68, 13);
            this.ldKQ.TabIndex = 9;
            this.ldKQ.Text = "jnfejnfjefnwej";
            this.ldKQ.Click += new System.EventHandler(this.ldKQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 329);
            this.Controls.Add(this.ldKQ);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLlai);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "chương trình tính tổng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label ldKQ;
    }
}

