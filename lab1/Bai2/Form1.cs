using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// xử lý click btn "tìm" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tim_Click(object sender, EventArgs e)
        {

            foreach(RadioButton item in gb2.Controls)
            {
                if(item != null)
                {
                    // tìm radio đã checked để xử lý
                    if (item.Checked)
                    {
                        if(item.Name == "rdo_uscln")
                        {
                            double so1 = 0;
                            double so2 = 0;
                            double j;
                            double uscln = 0;

                            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2))
                            {
                                j = (so1 < so2) ? so1 : so2;
                                for (int i = 1; i <= j; i++)
                                {
                                    if (so1 % i == 0 && so2 % i == 0)
                                    {
                                        uscln = i;
                                    }
                                }

                                txb_kq.Text = uscln.ToString();
                            }
                            else
                            {
                                txb_kq.Text = " Vui lòng nhập số";
                            }
                        }
                        else
                        {
                            double so1 = 0;
                            double so2 = 0;
                            double j;
                            double uscln = 0;
                            double bscnn = 0;

                            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2))
                            {
                                j = (so1 < so2) ? so1 : so2;
                                for (int i = 1; i <= j; i++)
                                {
                                    if (so1 % i == 0 && so2 % i == 0)
                                    {
                                        uscln = i;
                                    }
                                }

                                bscnn = (so1 * so2) / uscln;

                                txb_kq.Text = bscnn.ToString();
                            }
                            else
                            {
                                txb_kq.Text = " Vui lòng nhập số";
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// clear textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_boqua_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            txb_kq.Text = "";
        }

        /// <summary>
        /// thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
