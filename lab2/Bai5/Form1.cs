using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_1 frm = new frm_1();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_2 frm = new frm_2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_3 frm = new frm_3();
            frm.Show();
        }
    }
}
