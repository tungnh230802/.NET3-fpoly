
namespace ASM
{
    partial class GiangVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_find = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_ma = new System.Windows.Forms.TextBox();
            this.txb_gdtc = new System.Windows.Forms.TextBox();
            this.txb_tienganh = new System.Windows.Forms.TextBox();
            this.txb_tinhoc = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.lb_diemtb = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txb_find);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(540, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(441, 28);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(76, 31);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_find
            // 
            this.txb_find.Location = new System.Drawing.Point(148, 29);
            this.txb_find.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_find.Name = "txb_find";
            this.txb_find.Size = new System.Drawing.Size(285, 29);
            this.txb_find.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên sv:";
            // 
            // txb_name
            // 
            this.txb_name.Enabled = false;
            this.txb_name.Location = new System.Drawing.Point(166, 164);
            this.txb_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(235, 29);
            this.txb_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã sv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiếng anh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tin học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giáo dục TC:";
            // 
            // txb_ma
            // 
            this.txb_ma.Location = new System.Drawing.Point(166, 204);
            this.txb_ma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_ma.Name = "txb_ma";
            this.txb_ma.Size = new System.Drawing.Size(235, 29);
            this.txb_ma.TabIndex = 1;
            // 
            // txb_gdtc
            // 
            this.txb_gdtc.Location = new System.Drawing.Point(166, 317);
            this.txb_gdtc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_gdtc.Name = "txb_gdtc";
            this.txb_gdtc.Size = new System.Drawing.Size(235, 29);
            this.txb_gdtc.TabIndex = 4;
            // 
            // txb_tienganh
            // 
            this.txb_tienganh.Location = new System.Drawing.Point(166, 241);
            this.txb_tienganh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_tienganh.Name = "txb_tienganh";
            this.txb_tienganh.Size = new System.Drawing.Size(235, 29);
            this.txb_tienganh.TabIndex = 2;
            // 
            // txb_tinhoc
            // 
            this.txb_tinhoc.Location = new System.Drawing.Point(166, 281);
            this.txb_tinhoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txb_tinhoc.Name = "txb_tinhoc";
            this.txb_tinhoc.Size = new System.Drawing.Size(235, 29);
            this.txb_tinhoc.TabIndex = 3;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.ForeColor = System.Drawing.Color.Fuchsia;
            this.lab.Location = new System.Drawing.Point(434, 241);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(73, 23);
            this.lab.TabIndex = 11;
            this.lab.Text = "Điểm TB:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(401, 305);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 42);
            this.label9.TabIndex = 12;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(536, 161);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(76, 35);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(536, 207);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 35);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(536, 260);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 35);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(536, 312);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 35);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(130, 363);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(60, 38);
            this.btn_first.TabIndex = 17;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(211, 363);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(60, 38);
            this.btn_previous.TabIndex = 18;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(292, 363);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(60, 38);
            this.btn_next.TabIndex = 19;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(372, 363);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(60, 38);
            this.btn_last.TabIndex = 20;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(12, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "3 sinh viên có điểm cao nhất";
            // 
            // dgv_sinhvien
            // 
            this.dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhvien.Location = new System.Drawing.Point(15, 445);
            this.dgv_sinhvien.Name = "dgv_sinhvien";
            this.dgv_sinhvien.Size = new System.Drawing.Size(648, 111);
            this.dgv_sinhvien.TabIndex = 22;
            this.dgv_sinhvien.CurrentCellChanged += new System.EventHandler(this.dgv_sinhvien_CurrentCellChanged);
            // 
            // lb_diemtb
            // 
            this.lb_diemtb.AutoSize = true;
            this.lb_diemtb.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diemtb.ForeColor = System.Drawing.Color.Blue;
            this.lb_diemtb.Location = new System.Drawing.Point(453, 298);
            this.lb_diemtb.Name = "lb_diemtb";
            this.lb_diemtb.Size = new System.Drawing.Size(34, 42);
            this.lb_diemtb.TabIndex = 23;
            this.lb_diemtb.Text = "0";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(54, 9);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(31, 29);
            this.txb_id.TabIndex = 24;
            this.txb_id.Visible = false;
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 563);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.lb_diemtb);
            this.Controls.Add(this.dgv_sinhvien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txb_tinhoc);
            this.Controls.Add(this.txb_tienganh);
            this.Controls.Add(this.txb_gdtc);
            this.Controls.Add(this.txb_ma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_ma;
        private System.Windows.Forms.TextBox txb_gdtc;
        private System.Windows.Forms.TextBox txb_tienganh;
        private System.Windows.Forms.TextBox txb_tinhoc;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_sinhvien;
        private System.Windows.Forms.Label lb_diemtb;
        private System.Windows.Forms.TextBox txb_id;
    }
}