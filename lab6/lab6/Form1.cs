using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Company objCompany = new Company();
            objCompany.Id = txb_id.Text;
            objCompany.Name = txb_name.Text;


            CodeFirstContext objContext = new CodeFirstContext();
            objContext.Companies.Add(objCompany);
            objContext.SaveChanges();
            MessageBox.Show("success");
        }
    }
}   
