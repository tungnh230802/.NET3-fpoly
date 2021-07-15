
namespace lab1
{
    partial class lab1
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
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực Hiện Các Phép Tính Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số 2:";
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(166, 56);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(265, 30);
            this.txb1.TabIndex = 3;
            // 
            // txb2
            // 
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.Location = new System.Drawing.Point(166, 101);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(265, 30);
            this.txb2.TabIndex = 4;
            // 
            // btn_cong
            // 
            this.btn_cong.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cong.Location = new System.Drawing.Point(56, 198);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(61, 29);
            this.btn_cong.TabIndex = 5;
            this.btn_cong.Text = "+";
            this.btn_cong.UseVisualStyleBackColor = false;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.BackColor = System.Drawing.SystemColors.Control;
            this.btn_chia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chia.Location = new System.Drawing.Point(257, 198);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(61, 29);
            this.btn_chia.TabIndex = 6;
            this.btn_chia.Text = "/";
            this.btn_chia.UseVisualStyleBackColor = false;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_nhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhan.Location = new System.Drawing.Point(190, 198);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(61, 29);
            this.btn_nhan.TabIndex = 7;
            this.btn_nhan.Text = "*";
            this.btn_nhan.UseVisualStyleBackColor = false;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.BackColor = System.Drawing.SystemColors.Control;
            this.btn_tru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.Location = new System.Drawing.Point(123, 198);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(61, 29);
            this.btn_tru.TabIndex = 8;
            this.btn_tru.Text = "-";
            this.btn_tru.UseVisualStyleBackColor = false;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(324, 198);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(61, 29);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(391, 198);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(61, 29);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kết Quả:";
            // 
            // txb_kq
            // 
            this.txb_kq.BackColor = System.Drawing.Color.Salmon;
            this.txb_kq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_kq.Enabled = false;
            this.txb_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_kq.Location = new System.Drawing.Point(166, 148);
            this.txb_kq.Multiline = true;
            this.txb_kq.Name = "txb_kq";
            this.txb_kq.ReadOnly = true;
            this.txb_kq.Size = new System.Drawing.Size(265, 30);
            this.txb_kq.TabIndex = 12;
            // 
            // lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(527, 239);
            this.Controls.Add(this.txb_kq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "lab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinhToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_chia;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_kq;
    }
}

