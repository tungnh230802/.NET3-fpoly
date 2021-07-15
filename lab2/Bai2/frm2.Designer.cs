
namespace Bai2
{
    partial class bai2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_time1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_time2 = new System.Windows.Forms.TextBox();
            this.cbo_Name = new System.Windows.Forms.ComboBox();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.lbx_selected = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_next_all = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre_all = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_kq = new System.Windows.Forms.TextBox();
            this.btn_lose = new System.Windows.Forms.Button();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách thể thao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách các môn:";
            // 
            // txb_time1
            // 
            this.txb_time1.Enabled = false;
            this.txb_time1.Location = new System.Drawing.Point(75, 120);
            this.txb_time1.Name = "txb_time1";
            this.txb_time1.Size = new System.Drawing.Size(128, 29);
            this.txb_time1.TabIndex = 5;
            this.txb_time1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(243, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time:";
            // 
            // txb_time2
            // 
            this.txb_time2.Enabled = false;
            this.txb_time2.Location = new System.Drawing.Point(321, 120);
            this.txb_time2.Name = "txb_time2";
            this.txb_time2.Size = new System.Drawing.Size(128, 29);
            this.txb_time2.TabIndex = 7;
            this.txb_time2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_Name
            // 
            this.cbo_Name.FormattingEnabled = true;
            this.cbo_Name.Location = new System.Drawing.Point(160, 73);
            this.cbo_Name.Name = "cbo_Name";
            this.cbo_Name.Size = new System.Drawing.Size(289, 30);
            this.cbo_Name.TabIndex = 8;
            this.cbo_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Name_SelectedIndexChanged);
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 22;
            this.lbx_list.Items.AddRange(new object[] {
            "Bóng đá",
            "Bóng bàn",
            "Nhảy dù",
            "Thổi kèn",
            "Bập bên"});
            this.lbx_list.Location = new System.Drawing.Point(16, 189);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(167, 158);
            this.lbx_list.TabIndex = 9;
            // 
            // lbx_selected
            // 
            this.lbx_selected.FormattingEnabled = true;
            this.lbx_selected.ItemHeight = 22;
            this.lbx_selected.Location = new System.Drawing.Point(282, 189);
            this.lbx_selected.Name = "lbx_selected";
            this.lbx_selected.Size = new System.Drawing.Size(167, 158);
            this.lbx_selected.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(273, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Danh sách đã chọn:";
            // 
            // btn_next_all
            // 
            this.btn_next_all.Location = new System.Drawing.Point(201, 189);
            this.btn_next_all.Name = "btn_next_all";
            this.btn_next_all.Size = new System.Drawing.Size(63, 31);
            this.btn_next_all.TabIndex = 12;
            this.btn_next_all.Text = ">>";
            this.btn_next_all.UseVisualStyleBackColor = true;
            this.btn_next_all.Click += new System.EventHandler(this.btn_next_all_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(201, 226);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(63, 31);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre_all
            // 
            this.btn_pre_all.Location = new System.Drawing.Point(201, 279);
            this.btn_pre_all.Name = "btn_pre_all";
            this.btn_pre_all.Size = new System.Drawing.Size(63, 31);
            this.btn_pre_all.TabIndex = 14;
            this.btn_pre_all.Text = "<<";
            this.btn_pre_all.UseVisualStyleBackColor = true;
            this.btn_pre_all.Click += new System.EventHandler(this.btn_pre_all_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(201, 316);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(63, 31);
            this.btn_pre.TabIndex = 15;
            this.btn_pre.Text = "<";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kết quả:";
            // 
            // txb_kq
            // 
            this.txb_kq.Location = new System.Drawing.Point(16, 391);
            this.txb_kq.Multiline = true;
            this.txb_kq.Name = "txb_kq";
            this.txb_kq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_kq.Size = new System.Drawing.Size(310, 141);
            this.txb_kq.TabIndex = 17;
            // 
            // btn_lose
            // 
            this.btn_lose.Location = new System.Drawing.Point(354, 489);
            this.btn_lose.Name = "btn_lose";
            this.btn_lose.Size = new System.Drawing.Size(95, 43);
            this.btn_lose.TabIndex = 20;
            this.btn_lose.Text = "Thoát";
            this.btn_lose.UseVisualStyleBackColor = true;
            this.btn_lose.Click += new System.EventHandler(this.btn_lose_Click);
            // 
            // btn_nhap
            // 
            this.btn_nhap.Location = new System.Drawing.Point(354, 391);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(95, 43);
            this.btn_nhap.TabIndex = 21;
            this.btn_nhap.Text = "Nhập";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(354, 440);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(95, 43);
            this.btn_reset.TabIndex = 22;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 544);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.btn_lose);
            this.Controls.Add(this.txb_kq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_pre_all);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_next_all);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbx_selected);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.cbo_Name);
            this.Controls.Add(this.txb_time2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_time1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_time1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_time2;
        private System.Windows.Forms.ComboBox cbo_Name;
        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.ListBox lbx_selected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_next_all;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre_all;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_kq;
        private System.Windows.Forms.Button btn_lose;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Timer timer1;
    }
}

