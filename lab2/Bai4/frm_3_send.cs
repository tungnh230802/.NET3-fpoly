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
    public partial class frm_3_send : Form
    {
        public frm_3_send(string strTextBox)
        {
            InitializeComponent();
            label1.Text = strTextBox;
        }
    }
}
