
namespace Bai5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Controls.Add(this.tp3);
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.button2);
            this.tp1.Controls.Add(this.button1);
            this.tp1.Location = new System.Drawing.Point(4, 33);
            this.tp1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tp1.Size = new System.Drawing.Size(644, 342);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Bai1";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.button3);
            this.tp2.Location = new System.Drawing.Point(4, 33);
            this.tp2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tp2.Size = new System.Drawing.Size(644, 342);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Bai2";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.btn3);
            this.tp3.Location = new System.Drawing.Point(4, 33);
            this.tp3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tp3.Name = "tp3";
            this.tp3.Size = new System.Drawing.Size(644, 342);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Bai3";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(442, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mở bài 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(497, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Mở bài 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(54, 156);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(517, 35);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "Mở bài 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 428);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.tp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn3;
    }
}

