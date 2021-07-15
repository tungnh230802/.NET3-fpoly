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
        List<Members> list;
        public bai2()
        {
            InitializeComponent();

            load_Time();
            loadMenber();
        }

        /// <summary>
        /// load dữ liệu vào combobox
        /// </summary>
        void loadMenber()
        {
            list = new List<Members>()
            {
                new Members() {Name = "Yua mikami", listSelected = new List<string>()},
                new Members() {Name = "Ichikawa Masami", listSelected = new List<string>()},
                new Members() {Name = "Ameri Ichinose", listSelected = new List<string>()},
                new Members() {Name = "Aizawa Minami", listSelected = new List<string>()},
                new Members() {Name = "Yua mikami", listSelected = new List<string>()},
            };

            cbo_Name.DataSource = list;
            cbo_Name.DisplayMember = "Name";
        }

        /// <summary>
        /// load ngày tháng năm
        /// </summary>
        void load_Time()
        {
            txb_time1.Text = time1();
            timer1.Start();
        }

        /// <summary>
        /// chạy thời gian
        /// </summary>
        /// <returns></returns>
        string time1 ()
        {
            DateTime now = DateTime.Now;
            string[] time1 = now.GetDateTimeFormats('d');

            return time1[0].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txb_time2.Text = time2();
        }

        /// <summary>
        /// lấy ra ngày tháng hiện tại
        /// </summary>
        /// <returns></returns>
        string time2 ()
        {
            DateTime now = DateTime.Now;

            string[] time2 = now.GetDateTimeFormats('T');

            return time2[1].ToString();

        }

        /// <summary>
        /// chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_next_all_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < lbx_list.Items.Count; i++)
            {
                Members mem = cbo_Name.SelectedValue as Members;
                mem.listSelected.Add(lbx_list.Items[i].ToString());
                lbx_selected.Items.Add(lbx_list.Items[i].ToString());
            }
        }

        /// <summary>
        /// bỏ chọn tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pre_all_Click(object sender, EventArgs e)
        {
            lbx_selected.Items.Clear();
            Members mem = cbo_Name.SelectedValue as Members;
            mem.listSelected.Clear();
        }

        /// <summary>
        /// chọn 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_next_Click(object sender, EventArgs e)
        {
            if(lbx_list.SelectedIndex != -1)
            {
                lbx_selected.Items.Add(lbx_list.SelectedItem.ToString());
                Members mem = cbo_Name.SelectedValue as Members;
                mem.listSelected.Add(lbx_list.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// bỏ chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pre_Click(object sender, EventArgs e)
        {
            if(lbx_selected.SelectedIndex != -1)
            {
                Members mem = cbo_Name.SelectedValue as Members;
                mem.listSelected.RemoveAt(lbx_selected.SelectedIndex);
                lbx_selected.Items.RemoveAt(lbx_selected.SelectedIndex);
            }
        }

        /// <summary>
        /// even click btn nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nhap_Click(object sender, EventArgs e)
        {
            Members mem = cbo_Name.SelectedValue as Members;

            txb_kq.Text = ($"{mem.Name}\r\n" +
                $"{time1()} {time2()}\r\n" +
                $"Môn chọn:\r\n" +
                $"{list_Mon()}");
        }

        /// <summary>
        /// lấy ra danh sách các môn
        /// </summary>
        /// <returns></returns>
        string list_Mon()
        {
            string result = "";
            Members mem = cbo_Name.SelectedValue as Members;
            foreach(var item in mem.listSelected)
            {
                result += ($"{item.ToString()}, ");
            }
            return result;
        }

        /// <summary>
        /// clear text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            loadMenber();
            load_Time();
            txb_kq.Text = "";
            lbx_selected.Items.Clear();
        }

        /// <summary>
        /// even click btn thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// even combobox change index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            // mỗi khi combobox change thì sẽ lưu dữ liệu vào class member
            lbx_selected.Items.Clear();
            Members mem = cbo_Name.SelectedValue as Members;
            if (mem.listSelected.Count != 0)
            {
                foreach (var item in mem.listSelected)
                {
                    lbx_selected.Items.Add(item.ToString());
                }
            }
        }
    }

    /// <summary>
    /// class member dùng để lưu trữ dữ liệu
    /// </summary>
    class Members
    {
        public string Name { get; set; }
        public List<string> listSelected { get; set; }
    }
}
