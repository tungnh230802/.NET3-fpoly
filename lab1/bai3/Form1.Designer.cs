
namespace bai3
{
    partial class bai3
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.rdo_bac2 = new System.Windows.Forms.RadioButton();
            this.rdo_bac1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_giai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_kq = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.rdo_bac2);
            this.grb1.Controls.Add(this.rdo_bac1);
            this.grb1.Location = new System.Drawing.Point(50, 105);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(350, 110);
            this.grb1.TabIndex = 1;
            this.grb1.TabStop = false;
            this.grb1.Text = "Bạn vui lòng chọn";
            // 
            // rdo_bac2
            // 
            this.rdo_bac2.AutoSize = true;
            this.rdo_bac2.Location = new System.Drawing.Point(16, 62);
            this.rdo_bac2.Name = "rdo_bac2";
            this.rdo_bac2.Size = new System.Drawing.Size(223, 28);
            this.rdo_bac2.TabIndex = 1;
            this.rdo_bac2.Tag = "2";
            this.rdo_bac2.Text = "Giải phương trình bậc 2";
            this.rdo_bac2.UseVisualStyleBackColor = true;
            this.rdo_bac2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdo_bac1
            // 
            this.rdo_bac1.AutoSize = true;
            this.rdo_bac1.Checked = true;
            this.rdo_bac1.Location = new System.Drawing.Point(16, 28);
            this.rdo_bac1.Name = "rdo_bac1";
            this.rdo_bac1.Size = new System.Drawing.Size(223, 28);
            this.rdo_bac1.TabIndex = 0;
            this.rdo_bac1.TabStop = true;
            this.rdo_bac1.Tag = "1";
            this.rdo_bac1.Text = "Giải phương trình bậc 1";
            this.rdo_bac1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c:";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(115, 246);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(174, 29);
            this.txb1.TabIndex = 5;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(115, 292);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(174, 29);
            this.txb2.TabIndex = 6;
            // 
            // txb3
            // 
            this.txb3.Enabled = false;
            this.txb3.Location = new System.Drawing.Point(115, 341);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(174, 29);
            this.txb3.TabIndex = 7;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(307, 332);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(105, 38);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_giai
            // 
            this.btn_giai.Location = new System.Drawing.Point(307, 246);
            this.btn_giai.Name = "btn_giai";
            this.btn_giai.Size = new System.Drawing.Size(105, 37);
            this.btn_giai.TabIndex = 9;
            this.btn_giai.Text = "Giải";
            this.btn_giai.UseVisualStyleBackColor = true;
            this.btn_giai.Click += new System.EventHandler(this.btn_giai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kết quả:";
            // 
            // txb_kq
            // 
            this.txb_kq.Enabled = false;
            this.txb_kq.Location = new System.Drawing.Point(115, 384);
            this.txb_kq.Multiline = true;
            this.txb_kq.Name = "txb_kq";
            this.txb_kq.Size = new System.Drawing.Size(297, 95);
            this.txb_kq.TabIndex = 11;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(307, 289);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(105, 37);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 503);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txb_kq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_giai);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "bai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bai3";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.RadioButton rdo_bac2;
        private System.Windows.Forms.RadioButton rdo_bac1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_giai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_kq;
        private System.Windows.Forms.Button btn_xoa;
    }
}

