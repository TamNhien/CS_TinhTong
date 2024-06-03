namespace CS_TinhTong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTinhHieu = new System.Windows.Forms.Button();
            this.btnTinhTich = new System.Windows.Forms.Button();
            this.btnTinhThuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(393, 24);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 21);
            this.txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(393, 66);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 21);
            this.txtSo2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số 2";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(393, 110);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 21);
            this.txtKQ.TabIndex = 4;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(134, 161);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTong.TabIndex = 5;
            this.btnTinhTong.Text = "Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTinhHieu
            // 
            this.btnTinhHieu.Location = new System.Drawing.Point(234, 161);
            this.btnTinhHieu.Name = "btnTinhHieu";
            this.btnTinhHieu.Size = new System.Drawing.Size(75, 23);
            this.btnTinhHieu.TabIndex = 6;
            this.btnTinhHieu.Text = "Hiệu";
            this.btnTinhHieu.UseVisualStyleBackColor = true;
            this.btnTinhHieu.Click += new System.EventHandler(this.btnTinhHieu_Click);
            // 
            // btnTinhTich
            // 
            this.btnTinhTich.Location = new System.Drawing.Point(345, 161);
            this.btnTinhTich.Name = "btnTinhTich";
            this.btnTinhTich.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTich.TabIndex = 7;
            this.btnTinhTich.Text = "Tích";
            this.btnTinhTich.UseVisualStyleBackColor = true;
            this.btnTinhTich.Click += new System.EventHandler(this.btnTinhTich_Click);
            // 
            // btnTinhThuong
            // 
            this.btnTinhThuong.Location = new System.Drawing.Point(445, 161);
            this.btnTinhThuong.Name = "btnTinhThuong";
            this.btnTinhThuong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhThuong.TabIndex = 8;
            this.btnTinhThuong.Text = "Thương";
            this.btnTinhThuong.UseVisualStyleBackColor = true;
            this.btnTinhThuong.Click += new System.EventHandler(this.btnTinhThuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhThuong);
            this.Controls.Add(this.btnTinhTich);
            this.Controls.Add(this.btnTinhHieu);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH TÍNH TỔNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTinhHieu;
        private System.Windows.Forms.Button btnTinhTich;
        private System.Windows.Forms.Button btnTinhThuong;
    }
}

