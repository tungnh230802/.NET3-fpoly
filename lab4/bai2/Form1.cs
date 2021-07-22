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
        DataSet set;
        DataView dv;
        SqlDataAdapter dataAdapter;
        SqlConnection con = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");
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
            set = GetData();

            DataTable usersTable = set.Tables["users"];
            DataTable groupsTable = set.Tables["groups"];


            DataRelation relation = new DataRelation("group_user",
                groupsTable.Columns["groupid"],
                usersTable.Columns["groupid"]);

            set.Relations.Add(relation);

            dv = set.Tables["users"].DefaultView;
            dataGridView1.DataSource = dv;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// hàm lấy data từ database
        /// </summary>
        /// <returns>dataset</returns>
        private DataSet GetData()
        {
            con.Open();

            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);
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
            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);

            dv.AllowNew = true;
            DataRowView newRow = dv.AddNew();
            newRow.BeginEdit();
            newRow["userName"] = txb_Name.Text;
            try
            {
                newRow["groupId"] = Convert.ToInt32(txb_groupid.Text);
                newRow.EndEdit();
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(set.Tables["users"]);
            }
            catch
            {
                newRow.Delete();
            }
            finally
            {
                LoadData();
            }
        }

        /// <summary>
        /// xóa row đang chọn trên gridviewdata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            dv.AllowDelete = true;
            dv.Table.Rows[row].Delete();

            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(set.Tables["users"]);
        }

        /// <summary>
        /// hàm sử lý khi click vào một cell trên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txb_Name.Text = row.Cells[1].Value.ToString();
            txb_groupid.Text = row.Cells[2].Value.ToString();
        }

        /// <summary>
        /// cập nhật user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);

            dv.AllowEdit = true;
            dv[row].BeginEdit();
            dv[row]["userName"] = txb_Name.Text;
            try
            {
                dv[row]["groupId"] = Convert.ToInt32(txb_groupid.Text);
                dv[row].EndEdit();
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(set.Tables["users"]);
            }
            catch
            {
            }
            finally
            {
                LoadData();
            }
        }
    }
}
