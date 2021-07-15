using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public class Customer
    {
        public string Name { get; set; }
        public int So_moi { get; set; }
        public int So_cu { get; set; }
    }
    public partial class bai1 : Form
    {
        List<Customer> customer;

        int sokw = 0;
        int old = 0;
        int _new = 0;
        int ngoai_dm = 0;
        int trong_dm = 0;

        public bai1()
        {
            InitializeComponent();

            load_customer();
        }

        void load_customer()
        {
            customer = new List<Customer>()
            {
                new Customer(){Name = "nguyễn hoàng tùng"},
                new Customer(){Name = "nguyễn Trung Nhân"},
            };

            cbb_customer.DataSource = customer;
            cbb_customer.DisplayMember = "Name";

            addClassBinding();
        }

        void addClassBinding()
        {
            txb_new.DataBindings.Add(new Binding("Text", cbb_customer.DataSource, "So_moi"));
            txb_old.DataBindings.Add(new Binding("Text", cbb_customer.DataSource, "So_moi"));
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {

        }

        private void txb_new_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txb = sender as TextBox;

            check_num(txb);
        }

        void check_num(TextBox txb)
        {
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
                        txb_trongmuc.Text = "";
                        txb_ngoaimuc.Text = "";
                        txb_tieuthu.Text = "";
                    }
                }
            }
            else
            {
                txb.Text = "";
                MessageBox.Show("vui lòng nhập số!");
            }
        }

        private void txb_old_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txb = sender as TextBox;

            check_num(txb);
        }

        private void Cbb_customer_SelectedIndexChanged1(object sender, EventArgs e)
        {
            MessageBox.Show("change");
        }
    }
}
