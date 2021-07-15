using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// hàm đổ data vào gridviewdata
        /// </summary>
        void LoadData()
        {
            DataSet set = GetData();

            DataTable usersTable = set.Tables["users"];
            DataTable groupsTable = set.Tables["groups"];


            DataRelation relation = new DataRelation("group_user",
                groupsTable.Columns["groupid"],
                usersTable.Columns["groupid"]);

            set.Relations.Add(relation);

            DataView dv = set.Tables["users"].DefaultView;
            dataGridView1.DataSource = dv;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// hàm lấy data từ database
        /// </summary>
        /// <returns>dataset</returns>
        private static DataSet GetData()
        {
            var con = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");

            con.Open();

            var cmd = "select * from users";
            var dataAdapter = new SqlDataAdapter(cmd, con);
            var dataset = new DataSet();

            dataAdapter.Fill(dataset, "users");

            dataAdapter.SelectCommand.CommandText = "select * from groups";
            dataAdapter.Fill(dataset, "groups");

            con.Close();

            return dataset;
        }

        /// <summary>
        /// sắp xếp giảm dần theo userName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sort_Click(object sender, EventArgs e)
        {
            DataSet set = GetData();
            DataView dv = set.Tables["users"].DefaultView;
            dv.Sort = "UserName ASC";
            dataGridView1.DataSource = dv;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// hàm thêm một user mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");
            string query = ($"insert into users" +
                $" values('{txb_Name.Text}',{int.Parse(txb_groupid.Text)})");
            SqlCommand cmd = new SqlCommand(query,conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("đã thêm dữ liệu thành công!");
                LoadData();
            }
            catch
            {
                MessageBox.Show("thêm không thành công! vui lòng kiểm tra lại dữ liệu");
            }
            finally
            {
                conn.Close();
            }


        }

        /// <summary>
        /// xóa row đang chọn trên gridviewdata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // lấy ra userid đang chọn
            int userid = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["userid"].Value.ToString());

            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");
            string query = ($"delete from users where userid = @userid");

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter param = new SqlParameter() { ParameterName = "@userid", Value = userid };

            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("đã xóa thành công");
                LoadData();
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// hàm sử lý khi click vào một cell trên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dùng để đổ dữ liệu cell đang chọn vào textbox username và groupid

            int userID = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["userid"].Value.ToString());

            SqlConnection conn =  new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");

            string query = ($"select * from users " +
                $"where userid = @userid");
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlParameter param = new SqlParameter()
            {
                ParameterName = "@userid",
                Value = userID,
            };
            cmd.Parameters.Add(param);
       
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    txb_Name.Text = sdr["username"].ToString();
                    txb_groupid.Text = sdr["groupid"].ToString();
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// cập nhật user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["userid"].Value.ToString());

            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");

            string query = ($"update users " +
                $"set username = @username, " +
                $"groupid = @groupid " +
                $"where userid = @userid");

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter paramUserName = new SqlParameter() { ParameterName = "@username", Value = txb_Name.Text };
            SqlParameter paramGroupId = new SqlParameter() { ParameterName = "@groupid", Value = int.Parse(txb_groupid.Text) };
            SqlParameter paramUserID = new SqlParameter() { ParameterName = "@userid", Value = userID };

            cmd.Parameters.Add(paramUserName);
            cmd.Parameters.Add(paramUserID);
            cmd.Parameters.Add(paramGroupId);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("đã cập nhật thành công");
                LoadData();
            }
            catch { MessageBox.Show("không thể cập nhật"); }
            finally
            {
                conn.Close();
            }
        }
    }
}
