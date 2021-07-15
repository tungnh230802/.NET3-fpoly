using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Model_DB;

namespace Lab7_Contact
{
    public partial class frm_Contact_Manager : Form
    {
        public frm_Contact_Manager()
        {
            InitializeComponent();
            contactDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frm_Contact_Manager_Load(object sender, EventArgs e)
        {
            contactBindingSource.DataSource = ContactServices.GetAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using(frmAddEditContact frm = new frmAddEditContact(null))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    contactBindingSource.DataSource = ContactServices.GetAll();
                }
            }
        }
        
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (contactBindingSource.Current == null)
                return;
            using(frmAddEditContact frm = new frmAddEditContact(contactBindingSource.Current as contact))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    contactBindingSource.DataSource = ContactServices.GetAll();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (contactBindingSource.Current == null)
                return;
            if(MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ContactServices.Delete(contactBindingSource.Current as contact);
                contactBindingSource.RemoveCurrent();
            }
        }
    }
}
