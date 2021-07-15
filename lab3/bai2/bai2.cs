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

namespace bai2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            using(SqlConnection con = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from hocsinh", con);
                DataSet set = new DataSet();
                adapter.Fill(set);
                dataGridView1.DataSource = set.Tables[0].DefaultView;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string mahocsinh = txb_ma.Text;
            bool isExist = false;

            SqlConnection conn = null;
            string query = ($"select * from hocsinh where mahocsinh = {mahocsinh}");
            conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    isExist = true;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            if (isExist == false)
            {
                string query_insert = ($"insert into hocsinh" +
                $" values(N'{txb_ma.Text}'," +
                $"N'{txb_ten.Text}',N'{dtp_Birthdate.Text}'," +
                $"N'{txb_diachi.Text}',{int.Parse(nmud_gard.Value.ToString())}, " +
                $"N'{txb_lop.Text}')");
                conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");
                SqlCommand cmd_insert = new SqlCommand(query_insert, conn);

                try
                {
                    conn.Open();
                    cmd_insert.ExecuteNonQuery();
                    MessageBox.Show("đã thêm thành công học sinh");
                    loadData();
                }
                catch
                {
                    MessageBox.Show($"không thể thêm học sinh! vui lòng kiểm tra lại dữ liệu", "lỗi");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                string query_update = ($"update hocsinh " +
                $"set mahocsinh = N'{txb_ma.Text}'," +
                $"tenhs = N'{txb_ten.Text}'," +
                $"ngaysinh = N'{dtp_Birthdate.Text}'," +
                $"diachi = N'{txb_diachi.Text}'," +
                $"dtb = {int.Parse(nmud_gard.Value.ToString())}," +
                $"malop = N'{txb_lop.Text}' " +
                $"where mahocsinh = N'{mahocsinh}'");
                conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");
                SqlCommand cmd_update = new SqlCommand(query_update, conn);

                try
                {
                    conn.Open();
                    cmd_update.ExecuteNonQuery();
                    MessageBox.Show("đã cập nhập thành công học sinh");
                    loadData();
                }
                catch
                {
                    MessageBox.Show($"không thể cập nhật học sinh! vui lòng kiểm tra lại dữ liệu", "lỗi");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string mahs = dataGridView1.SelectedCells[0].OwningRow.Cells["mahocsinh"].Value.ToString();

            SqlConnection conn = null;
            string query = ($"delete from hocsinh where mahocsinh = '{mahs}'");
            conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("đã xóa thành công học viên");
                loadData();
            }
            catch
            {
                MessageBox.Show("lỗi không thể xóa!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahs = dataGridView1.SelectedCells[0].OwningRow.Cells["mahocsinh"].Value.ToString();
            
            SqlConnection conn = null;
            string query = ($"select * from hocsinh where mahocsinh = {mahs.ToString()}");
            conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");

            SqlCommand cmd = new SqlCommand(query,conn);

            try
            {
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txb_ten.Text = sdr["tenhs"].ToString();
                    txb_ma.Text = sdr["mahocsinh"].ToString();
                    txb_lop.Text = sdr["malop"].ToString();
                    txb_diachi.Text = sdr["diachi"].ToString();
                    nmud_gard.Value = Convert.ToDecimal(sdr["dtb"].ToString());
                    dtp_Birthdate.Value = Convert.ToDateTime(sdr["ngaysinh"].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
