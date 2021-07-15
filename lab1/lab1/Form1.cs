using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class lab1 : Form
    {
        public lab1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// xử lý click btn phép cộng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cong_Click(object sender, EventArgs e)
        {
            double so1 = 0;
            double so2 = 0;
            double kq = 0;

            // kiểm tra nếu là số thì xuất ra kết quả còn không thì thông báo lỗi !!!
            if(double.TryParse(txb1.Text,out so1) && double.TryParse(txb2.Text, out so2))
            {
                kq = so1 + so2;
                txb_kq.Text = kq.ToString();
            }
            else
            {
                txb_kq.Text = " Vui lòng nhập số";
            }

        }

        /// <summary>
        /// xử lý click btn phép trừ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tru_Click(object sender, EventArgs e)
        {
            double so1 = 0;
            double so2 = 0;
            double kq = 0;

            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2))
            {
                kq = so1 - so2;
                txb_kq.Text = kq.ToString();
            }
            else
            {
                txb_kq.Text = " Vui lòng nhập số";
            }
        }

        /// <summary>
        /// nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nhan_Click(object sender, EventArgs e)
        {
            double so1 = 0;
            double so2 = 0;
            double kq = 0;

            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2))
            {
                kq = so1 * so2;
                txb_kq.Text = kq.ToString();
            }
            else
            {
                txb_kq.Text = " Vui lòng nhập số";
            }
        }

        /// <summary>
        /// chia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chia_Click(object sender, EventArgs e)
        {
            double so1 = 0;
            double so2 = 0;
            double kq = 0;

            if (double.TryParse(txb1.Text, out so1) && double.TryParse(txb2.Text, out so2))
            {
                kq = so1 / so2;
                txb_kq.Text = kq.ToString();
            }
            else
            {
                txb_kq.Text = " Vui lòng nhập số";
            }
        }

        /// <summary>
        /// clear các textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txb_kq.Text = "";
            txb1.Text = "";
            txb2.Text = "";
        }

        /// <summary>
        /// thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
