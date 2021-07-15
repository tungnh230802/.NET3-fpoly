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
    public partial class frm_3 : Form
    {
        public frm_3()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            frm_3_send frm2 = new frm_3_send(textBox1.Text);
            frm2.Show();
        }
    }
}
