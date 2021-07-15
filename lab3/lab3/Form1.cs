using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab3
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string query = ($"insert into hocsinh" +
            $" values('{txb_ma.Text}','{txb_ten.Text}','{dtp_Birthdate.Text}','{txb_diachi.Text}',{int.Parse(nmud_gard.Value.ToString())}, '{txb_lop.Text}')");
            conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("đã thêm thành công học sinh");
            }catch
            {
                MessageBox.Show($"không thể thêm học sinh! vui lòng kiểm tra lại dữ liệu","lỗi");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txb_diachi.Text = "";
            txb_lop.Text = "";
            txb_ma.Text = "";
            txb_ten.Text = "";
            nmud_gard.Value = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
