using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// xử lý checkedchange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // txb_3(số C) sẽ enabled khi radiobtn tính pt bậc 2 được checked và ngược lại!
            txb3.Enabled = !txb3.Enabled;
            txb3.Text = "";
        }

        /// <summary>
        /// xử lý even click btn_giai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_giai_Click(object sender, EventArgs e)
        {
            foreach(RadioButton item in grb1.Controls)
            {
                if(item != null)
                {
                    if(item.Checked)
                    {
                        // radiobtn checked và name = rdo_bac1 sẽ tiến hành tính theo pt bậc 1 nếu ko thì tình pt bậc 2
                       if(item.Name == "rdo_bac1")
                        {
                            double so1 = 0;
                            double so2 = 0;
                            double kq = 0;

                            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2))
                            {
                                if (so1 == 0)
                                {
                                    txb_kq.Text = "a phải khác 0";
                                }
                                else
                                {
                                    kq = -so2 / so1;
                                    txb_kq.Text = ($"{so1}x + {so2} = 0 \r\n=> x = {Math.Round(kq, 3)}").ToString();
                                }
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
                            double so3 = 0;
                            double kq = 0;
                            double delta = 0;

                            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2) && double.TryParse(txb3.Text, out so3))
                            {
                                delta = so2 * so2 - 4 * so1 * so3;
                                if (delta > 0)
                                {
                                    txb_kq.Text = "Phương trình có 2 nghiệm: \r\n";
                                    txb_kq.Text += ($"X1 = {Math.Round(((-so2 - Math.Sqrt(delta)) / 2 * so1), 2)}\r\n").ToString();
                                    txb_kq.Text += ($"X2 = {Math.Round(((-so2 + Math.Sqrt(delta)) / 2 * so1), 2)}").ToString();
                                }
                                else if (delta == 0)
                                {
                                    txb_kq.Text = "Phương trình có 2 nghiệm kép";
                                    txb_kq.Text += ($"X1 = X2 {Math.Round(-so2 / 2 * so1)}");
                                }
                                else if (delta < 0)
                                {
                                    txb_kq.Text = "Phương trình vô nghiệm";
                                }
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
        /// clear text_box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txb_kq.Text = "";
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
        }

        /// <summary>
        /// thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
