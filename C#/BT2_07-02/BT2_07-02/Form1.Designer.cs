namespace BT2_07_02
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
            this.pcb = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntTho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb
            // 
            this.pcb.Location = new System.Drawing.Point(54, 56);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(131, 25);
            this.pcb.TabIndex = 0;
            this.pcb.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(356, 43);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(122, 38);
            this.btn.TabIndex = 1;
            this.btn.Text = "ấn vào đây";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 263);
            this.textBox1.TabIndex = 2;
            // 
            // bntTho
            // 
            this.bntTho.Location = new System.Drawing.Point(432, 326);
            this.bntTho.Name = "bntTho";
            this.bntTho.Size = new System.Drawing.Size(122, 38);
            this.bntTho.TabIndex = 3;
            this.bntTho.Text = "ấn vào chứ nhìn cc à";
            this.bntTho.UseVisualStyleBackColor = true;
            this.bntTho.Click += new System.EventHandler(this.bntTho_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntTho);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pcb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntTho;
    }
}

