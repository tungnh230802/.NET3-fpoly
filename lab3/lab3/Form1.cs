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
        SqlConnection conn;
        string query;
        SqlCommand cmd;
        SqlDataAdapter ada;
        DataSet db = new DataSet();
        public bai1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            query = "select * from hocsinh";
            conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");
            cmd = new SqlCommand(query, conn);

            ada = new SqlDataAdapter(cmd);
            ada.Fill(db,"hocsinh");

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
            txb_diachi.Text = "";
            cbo_lop.SelectedIndex = 0;
            txb_ma.Text = "";
            txb_ten.Text = "";
            nmud_gard.Value = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bai1_Load(object sender, EventArgs e)
        {
            query = ($"select * from lop");
            conn = new SqlConnection(@"data source=DESKTOP-2V5F3CA\TUNGNH230802; database=qlhocsinh; integrated security=SSPI");
            ada = new SqlDataAdapter(query, conn);
            db = new DataSet();
            ada.Fill(db,"lop");
            cbo_lop.DataSource = db.Tables["lop"];
            cbo_lop.DisplayMember = "tenlop";
            cbo_lop.ValueMember = "malop";
        }

        private void bai1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
