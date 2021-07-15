
namespace Lab7_Contact
{
    partial class frmAddEditContact
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(33, 133);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(33, 37);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(115, 20);
            contactNameLabel.TabIndex = 3;
            contactNameLabel.Text = "Contact Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 69);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(33, 101);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(119, 20);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(Model_DB.contact);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(158, 130);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(261, 96);
            this.addressTextBox.TabIndex = 11;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "ContactName", true));
            this.contactNameTextBox.Location = new System.Drawing.Point(158, 34);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(261, 26);
            this.contactNameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(158, 66);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(261, 26);
            this.emailTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(158, 98);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(261, 26);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(344, 232);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frmAddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 277);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(contactNameLabel);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Contact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditContact_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button btn_save;
    }
}