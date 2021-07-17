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

        SqlConnection con = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");
        SqlDataAdapter ada;
        DataSet db = new DataSet();
        public bai2()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bai2_Load(object sender, EventArgs e)
        {
            string queryHocSinh = "select * from hocsinh";
            ada = new SqlDataAdapter(queryHocSinh, con);
            ada.Fill(db, "hocsinh");

            dataGridView1.DataSource = db.Tables["hocsinh"];

            string queryLop = "select * from Lop";
            ada = new SqlDataAdapter(queryLop, con);
            ada.Fill(db, "lop");
            cbo_lop.DataSource = db.Tables["lop"];
            cbo_lop.DisplayMember = "tenlop";
            cbo_lop.ValueMember = "malop";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = "select * from hocsinh";
            ada = new SqlDataAdapter(query, con);


            DataRow row = db.Tables["hocsinh"].NewRow();
            row["mahocsinh"] = txb_ma.Text;
            row["tenhs"] = txb_ten.Text;
            row["ngaysinh"] = dtp_Birthdate.Value.ToString("yyyy/MM/dd");
            row["diachi"] = txb_diachi.Text;
            row["dtb"] = nmud_gard.Value.ToString();
            row["malop"] = cbo_lop.SelectedValue.ToString();
            try
            {
                db.Tables["hocsinh"].Rows.Add(row);
                SqlCommandBuilder builder = new SqlCommandBuilder(ada);
                ada.Update(db.Tables["hocsinh"]);

                MessageBox.Show("Save success!");
            }
            catch
            {
                MessageBox.Show("Save Error!");
                db.Tables["hocsinh"].Rows.Remove(row);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            string query = "select * from hocsinh";
            ada = new SqlDataAdapter(query, con);

            db.Tables["hocsinh"].Rows.RemoveAt(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            ada.Update(db.Tables["hocsinh"]);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txb_ma.Text = row.Cells[0].Value.ToString();
            txb_ten.Text = row.Cells[1].Value.ToString();
            dtp_Birthdate.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            txb_diachi.Text = row.Cells[3].Value.ToString();
            cbo_lop.SelectedItem = row.Cells[4].Value.ToString();
        }
    }
}
