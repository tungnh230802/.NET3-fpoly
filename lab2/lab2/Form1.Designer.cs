
namespace lab2
{
    partial class bai1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_customer = new System.Windows.Forms.ComboBox();
            this.txb_old = new System.Windows.Forms.TextBox();
            this.txb_tieuthu = new System.Windows.Forms.TextBox();
            this.txb_new = new System.Windows.Forms.TextBox();
            this.txb_tongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_trongmuc = new System.Windows.Forms.TextBox();
            this.txb_ngoaimuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txb_kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng tính tiền điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "chỉ số cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền phải trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số kw tiêu thụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "chỉ số  mới:";
            // 
            // cbb_customer
            // 
            this.cbb_customer.FormattingEnabled = true;
            this.cbb_customer.Location = new System.Drawing.Point(194, 68);
            this.cbb_customer.Name = "cbb_customer";
            this.cbb_customer.Size = new System.Drawing.Size(311, 32);
            this.cbb_customer.TabIndex = 6;
            // 
            // txb_old
            // 
            this.txb_old.Location = new System.Drawing.Point(150, 111);
            this.txb_old.Name = "txb_old";
            this.txb_old.Size = new System.Drawing.Size(63, 29);
            this.txb_old.TabIndex = 7;
            this.txb_old.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_old_KeyUp);
            // 
            // txb_tieuthu
            // 
            this.txb_tieuthu.Enabled = false;
            this.txb_tieuthu.Location = new System.Drawing.Point(150, 192);
            this.txb_tieuthu.Name = "txb_tieuthu";
            this.txb_tieuthu.Size = new System.Drawing.Size(63, 29);
            this.txb_tieuthu.TabIndex = 8;
            // 
            // txb_new
            // 
            this.txb_new.Location = new System.Drawing.Point(150, 150);
            this.txb_new.Name = "txb_new";
            this.txb_new.Size = new System.Drawing.Size(63, 29);
            this.txb_new.TabIndex = 9;
            this.txb_new.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_new_KeyUp);
            // 
            // txb_tongtien
            // 
            this.txb_tongtien.Location = new System.Drawing.Point(17, 269);
            this.txb_tongtien.Name = "txb_tongtien";
            this.txb_tongtien.Size = new System.Drawing.Size(196, 29);
            this.txb_tongtien.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số kw trong đinh mức:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số kw ngoài đinh mức:";
            // 
            // txb_trongmuc
            // 
            this.txb_trongmuc.Enabled = false;
            this.txb_trongmuc.Location = new System.Drawing.Point(442, 116);
            this.txb_trongmuc.Name = "txb_trongmuc";
            this.txb_trongmuc.Size = new System.Drawing.Size(63, 29);
            this.txb_trongmuc.TabIndex = 14;
            // 
            // txb_ngoaimuc
            // 
            this.txb_ngoaimuc.Enabled = false;
            this.txb_ngoaimuc.Location = new System.Drawing.Point(442, 155);
            this.txb_ngoaimuc.Name = "txb_ngoaimuc";
            this.txb_ngoaimuc.Size = new System.Drawing.Size(63, 29);
            this.txb_ngoaimuc.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Định mức là 50kw";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Trong định mức là 500đ/kw ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ngoài định mức là 1000đ/kw ";
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(17, 313);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(89, 36);
            this.btn_tinh.TabIndex = 19;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(123, 313);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(90, 36);
            this.btn_In.TabIndex = 20;
            this.btn_In.Text = "In";
            this.btn_In.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(65, 364);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(90, 36);
            this.btn_thoat.TabIndex = 21;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // txb_kq
            // 
            this.txb_kq.Location = new System.Drawing.Point(241, 313);
            this.txb_kq.Multiline = true;
            this.txb_kq.Name = "txb_kq";
            this.txb_kq.Size = new System.Drawing.Size(264, 87);
            this.txb_kq.TabIndex = 22;
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 419);
            this.Controls.Add(this.txb_kq);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_ngoaimuc);
            this.Controls.Add(this.txb_trongmuc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_tongtien);
            this.Controls.Add(this.txb_new);
            this.Controls.Add(this.txb_tieuthu);
            this.Controls.Add(this.txb_old);
            this.Controls.Add(this.cbb_customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_customer;
        private System.Windows.Forms.TextBox txb_old;
        private System.Windows.Forms.TextBox txb_tieuthu;
        private System.Windows.Forms.TextBox txb_new;
        private System.Windows.Forms.TextBox txb_tongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_trongmuc;
        private System.Windows.Forms.TextBox txb_ngoaimuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txb_kq;
    }
}

