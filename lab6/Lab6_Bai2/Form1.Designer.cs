
namespace Lab6_Bai2
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
            this.txb_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.txb_soluong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_cate = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // txb_ma
            // 
            this.txb_ma.Location = new System.Drawing.Point(96, 105);
            this.txb_ma.Name = "txb_ma";
            this.txb_ma.Size = new System.Drawing.Size(137, 26);
            this.txb_ma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề:";
            // 
            // txb_title
            // 
            this.txb_title.Location = new System.Drawing.Point(96, 151);
            this.txb_title.Name = "txb_title";
            this.txb_title.Size = new System.Drawing.Size(267, 26);
            this.txb_title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng:";
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(523, 108);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(137, 26);
            this.txb_price.TabIndex = 6;
            // 
            // txb_soluong
            // 
            this.txb_soluong.Location = new System.Drawing.Point(523, 151);
            this.txb_soluong.Name = "txb_soluong";
            this.txb_soluong.Size = new System.Drawing.Size(137, 26);
            this.txb_soluong.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 218);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Location = new System.Drawing.Point(19, 455);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(117, 28);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Location = new System.Drawing.Point(296, 455);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(117, 28);
            this.btn_luu.TabIndex = 10;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Location = new System.Drawing.Point(435, 455);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 28);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_boqua.Location = new System.Drawing.Point(585, 455);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(117, 28);
            this.btn_boqua.TabIndex = 12;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại sách:";
            // 
            // cbx_cate
            // 
            this.cbx_cate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cate.FormattingEnabled = true;
            this.cbx_cate.Location = new System.Drawing.Point(96, 33);
            this.cbx_cate.Name = "cbx_cate";
            this.cbx_cate.Size = new System.Drawing.Size(137, 28);
            this.cbx_cate.TabIndex = 14;
            // 
            // btn_sua
            // 
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Location = new System.Drawing.Point(155, 455);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 28);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 494);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.cbx_cate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_soluong);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_ma);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "thông tin sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.TextBox txb_soluong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_cate;
        private System.Windows.Forms.Button btn_sua;
    }
}

