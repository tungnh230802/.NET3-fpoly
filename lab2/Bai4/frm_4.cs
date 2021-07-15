using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frm_4 : Form
    {
        public frm_4()
        {
            InitializeComponent();
        }

        private void lab1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_1 frm = new frm_1();
            frm.Show();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_2 frm = new frm_2();
            frm.Show();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_3 frm = new frm_3();
            frm.Show();
        }
    }
}
