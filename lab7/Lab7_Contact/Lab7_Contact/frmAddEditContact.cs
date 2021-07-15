using BusinessLayer;
using Model_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Contact
{
    public partial class frmAddEditContact : Form
    {
        bool IsNew;
        public frmAddEditContact(contact obj)
        {
            InitializeComponent();

            if (obj == null)
            {
                contactBindingSource.DataSource = new contact();
                IsNew = true;
            }
            else
            {
                contactBindingSource.DataSource = obj;
                IsNew = false;
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(contactNameTextBox.Text)) 
            {
                MessageBox.Show("please enter your contact name.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contactNameTextBox.Focus();
                return;
            }
            if (IsNew)
            {
                ContactServices.Insert(contactBindingSource.Current as contact);
                MessageBox.Show("save succsessfull!", "notity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contactBindingSource.Clear();
            }
            else
            {
                ContactServices.Update(contactBindingSource.Current as contact);
                MessageBox.Show("update succsessfull!", "notity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contactBindingSource.Clear();

            }
        }


        private void frmAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
