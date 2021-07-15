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
    public partial class frm_1 : Form
    {
        List<Customer> customer;

        public frm_1()
        {

            InitializeComponent();
            load_customer();
        }

        /// <summary>
        /// loand dữ liệu
        /// </summary>
        void load_customer()
        {
            customer = new List<Customer>()
            {
                new Customer(){Name = "Suzu ichinose"},
                new Customer(){Name = "Yua mikami"},
                new Customer(){Name = "Aizawa Minami"},
                new Customer(){Name = "Ameri Ichinose"},
                new Customer(){Name = "Ichikawa Masami"},
            };

            cbb_customer.DataSource = customer;
            cbb_customer.DisplayMember = "Name";

            addClassBinding();
        }


        /// <summary>
        /// liên kết với chỉ số cũ và chỉ số mới
        /// </summary>
        void addClassBinding()
        {
            txb_new.DataBindings.Add(new Binding("Text", cbb_customer.DataSource, "So_moi"));
            txb_old.DataBindings.Add(new Binding("Text", cbb_customer.DataSource, "So_cu"));
        }

        
        private void txb_old_KeyUp(object sender, KeyEventArgs e)
        { 
            // khi ấn phím sẽ kiểm tra dữ liệu và cập nhập dữ liệu sang các ô texbox
            TextBox txb = sender as TextBox;

            check_num(txb);
        }

        private void txb_new_KeyUp(object sender, KeyEventArgs e)
        {
            // khi ấn phím sẽ kiểm tra dữ liệu và cập nhập dữ liệu sang các ô texbox
            TextBox txb = sender as TextBox;

            check_num(txb);
        }

        /// <summary>
        /// kiểm tra dữ liệu và cập nhập 
        /// </summary>
        /// <param name="txb"></param>
        void check_num(TextBox txb)
        {
            int sokw = 0;
            int old = 0;
            int _new = 0;
            int ngoai_dm = 0;
            int trong_dm = 0;
            int value;
            if (int.TryParse(txb.Text, out value))
            {
                if (txb_old.Text != "" && txb_new.Text != "")
                {
                    if (int.TryParse(txb_old.Text, out old) && int.TryParse(txb_new.Text, out _new))
                    {
                        sokw = _new - old;
                        txb_tieuthu.Text = sokw.ToString();
                        if (sokw >= 50)
                        {
                            trong_dm = 50;
                            ngoai_dm = sokw - 50;

                            txb_ngoaimuc.Text = ngoai_dm.ToString();
                            txb_trongmuc.Text = trong_dm.ToString();
                        }
                        else
                        {
                            trong_dm = sokw;
                            txb_trongmuc.Text = trong_dm.ToString();
                            txb_ngoaimuc.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("vui lòng nhập số!", "thông báo");
                        txb.Text = "";
                        resttxb();
                    }
                }
            }
            else
            {
                txb.Text = "";
                MessageBox.Show("vui lòng nhập số!");
            }
        }

        /// <summary>
        /// reset các ô txbox
        /// </summary>
        void resttxb()
        {
            txb_trongmuc.Text = "";
            txb_ngoaimuc.Text = "";
            txb_tieuthu.Text = "";
            txb_tongtien.Text = "";
            txb_kq.Text = "";
        }

        /// <summary>
        /// sự kiện khi thay đổi họ tên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_customer_SelectedValueChanged(object sender, EventArgs e)
        {
            int sokw = 0;
            int trong_dm = 0;
            int ngoai_dm = 0;

            resttxb();

            ComboBox cbx = sender as ComboBox;

            if (cbx.SelectedValue != null)
            {
                Customer cus = cbx.SelectedValue as Customer;

                if (cus.So_moi != 0)
                {
                    sokw = cus.So_moi - cus.So_cu;
                    txb_tieuthu.Text = sokw.ToString();
                        if (sokw >= 50)
                        {
                            trong_dm = 50;
                            ngoai_dm = sokw - 50;

                            txb_ngoaimuc.Text = ngoai_dm.ToString();
                            txb_trongmuc.Text = trong_dm.ToString();
                        }
                        else
                        {
                            trong_dm = sokw;
                            txb_trongmuc.Text = trong_dm.ToString();
                            txb_ngoaimuc.Text = "";
                        }
                }
            }
        }

        /// <summary>
        /// khi ấn nút tính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int trong_dm = 0;
            int ngoai_dm = 0;
            int sokw = 0;
            if (cbb_customer.SelectedValue != null)
            {
                Customer cus = cbb_customer.SelectedValue as Customer;
                sokw = cus.So_moi - cus.So_cu;

                if (sokw >= 50)
                {
                    trong_dm = 50;
                    ngoai_dm = sokw - 50;

                    tongtien = (trong_dm * 500) + (ngoai_dm * 1000);
                    txb_tongtien.Text = ($"{tongtien.ToString()}đ");
                }
                else
                {
                    trong_dm = sokw;

                    tongtien = (trong_dm * 500);
                    txb_tongtien.Text = ($"{tongtien.ToString()}đ");
                }
            }
        }

        /// <summary>
        /// khi ấn in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_In_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            int trong_dm = 0;
            int ngoai_dm = 0;
            int sokw = 0;
            if (cbb_customer.SelectedValue != null)
            {
                Customer cus = cbb_customer.SelectedValue as Customer;
                sokw = cus.So_moi - cus.So_cu;

                if (sokw >= 50)
                {
                    trong_dm = 50;
                    ngoai_dm = sokw - 50;
                }
                else
                {
                    trong_dm = sokw;

                    tongtien = (trong_dm * 500);
                }

                txb_kq.Text = ($"khách hàng:{cus.Name}" +
                    $"\r\nSố kw tiêu thụ:{sokw}" +
                    $"\r\nTổng tiền:{tongtien}");
            }
        }

        /// <summary>
        /// rest lại txb_cu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_old_MouseClick(object sender, MouseEventArgs e)
        {
            var txb = sender as TextBox;
            if (txb.Text == "0")
                txb.Text = "";
        }

        /// <summary>
        /// reset txb_moi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_new_MouseClick(object sender, MouseEventArgs e)
        {
            var txb = sender as TextBox;
            if (txb.Text == "0")
                txb.Text = "";
        }
    
    }
    public class Customer
    {
        public string Name { get; set; }
        public int So_moi { get; set; }
        public int So_cu { get; set; }
    }
}
