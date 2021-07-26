using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class GiangVien : Form
    {

        fpl_daotaoEntities1 db = new fpl_daotaoEntities1();
        public GiangVien()
        {
            InitializeComponent();
            fillData();
            dgv_sinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // load 3 sinh viên có điểm cao nhất vào datagridview
        private void fillData()
        {
            dgv_sinhvien.DataSource = db.grades.Select(x => new
            {
                id = x.id,
                MaSV = x.masv,
                HoTen = x.student.hoten,
                TiengAnh = x.tienganh,
                TinHoc = x.tinhoc,
                GDTC = x.GDTC,
                DiemTB = (x.GDTC + x.tinhoc + x.tienganh) / 3,
            }).OrderByDescending(x => x.DiemTB).Take(3).ToList();
        }

        // thông báo kết quả khi thực hiện 1 thao tác
        private void ShowStatus(bool result, string str)
        {
            if (result)
            {
                MessageBox.Show(str + " Successfully!"
               , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillData();
            }
            else
            {
                MessageBox.Show(str + " some went wrong!..please try again!..", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // xóa trống các textbox
        private void ClearField()
        {
            txb_ma.Text = "";
            txb_name.Text = "";
            txb_tienganh.Text = "";
            txb_tinhoc.Text = "";
            txb_gdtc.Text = "";
        }

        // sự kiện click btn new
        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        // save điểm
        private bool SaveGradeDetail(grade gr)
        {
            bool result = false;
            try
            {
                gr.masv = txb_ma.Text;
                gr.tienganh = int.Parse(txb_tienganh.Text);
                gr.GDTC = int.Parse(txb_gdtc.Text);
                gr.tinhoc = int.Parse(txb_tinhoc.Text);
                db.grades.Add(gr);
                db.SaveChanges();
                result = true;
            }
            catch 
            {
                db.grades.Remove(gr);   
            }

            return result;
        }

        //sự kiện click btn save
        private void btn_save_Click(object sender, EventArgs e)
        {
            bool result = false;

            grade gr = new grade();
            result = SaveGradeDetail(gr);

            ShowStatus(result, "Save");
        }
        // xóa điểm
        private bool deleteGradeDetail(grade gr)
        {
            bool result = false;
            try
            {
                db.grades.Remove(gr);
                db.SaveChanges();
                result = true;
            }
            catch { }
            return result;
        }

        // sự kiện btn delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool result = false;
            int idDelete = int.Parse(txb_id.Text);

            grade grDelete =  db.grades.Find(idDelete);

            result = deleteGradeDetail(grDelete);
            ShowStatus(result, "delete");
        }

        private void CheckDataNull(object obj, TextBox txb)
        {
            // kiểm tra cell trong dataview, nếu null thì hiển thị "rỗng"
            // nếu không null sẽ hiện thì lên dataview
            if (obj is null)
            {
                txb.Text = "";
            }
            else
            {
                txb.Text = obj.ToString();
            }
        }

        // lấy dữ liệu trong dataview đổ lên các textbox, label,.. tương ứng
        private void BidingData()
        {
            try
            {
                CheckDataNull(dgv_sinhvien.SelectedCells[0].OwningRow.Cells["id"].Value, txb_id);
                CheckDataNull(dgv_sinhvien.SelectedCells[0].OwningRow.Cells["masv"].Value, txb_ma);
                CheckDataNull(dgv_sinhvien.SelectedCells[0].OwningRow.Cells["hoten"].Value, txb_name);
                CheckDataNull(dgv_sinhvien.SelectedCells[0].OwningRow.Cells["tienganh"].Value, txb_tienganh);
                CheckDataNull(dgv_sinhvien.SelectedCells[0].OwningRow.Cells["tinhoc"].Value, txb_tinhoc);
                CheckDataNull(dgv_sinhvien.SelectedCells[0].OwningRow.Cells["GDTC"].Value, txb_gdtc);
                lb_diemtb.Text = dgv_sinhvien.SelectedCells[0].OwningRow.Cells["DiemTB"].Value.ToString();
            }
            catch { }
        }

        // sự kiện cellchange trong dataview
        private void dgv_sinhvien_CurrentCellChanged(object sender, EventArgs e)
        {
            BidingData();
        }

        // update điểm
        private bool updataGradeDetail(grade gr)
        {
            bool result = false;
            try
            {
                gr.masv = txb_ma.Text;
                gr.tienganh = int.Parse(txb_tienganh.Text);
                gr.GDTC = int.Parse(txb_gdtc.Text);
                gr.tinhoc = int.Parse(txb_tinhoc.Text);
                db.SaveChanges();
                result = true;
            }
            catch { }

            return result;
        }

        // sự kiện click btn update
        private void btn_update_Click(object sender, EventArgs e)
        {
            bool result = false;

            grade grUpdate = db.grades.Find(int.Parse(txb_id.Text));

            result = updataGradeDetail(grUpdate);
            ShowStatus(result, "Update");
        }

        // tìm sinh viên theo mã sv
        private void btn_search_Click(object sender, EventArgs e)
        {
            var gradeFind = db.grades.Where(x => x.masv == txb_find.Text).Select(x => new
            {
                id = x.id,
                MaSV = x.masv,
                HoTen = x.student.hoten,
                TiengAnh = x.tienganh,
                TinHoc = x.tinhoc,
                GDTC = x.GDTC,
                DiemTB = (x.GDTC + x.tinhoc + x.tienganh) / 3
            }).ToList();
            
            if(gradeFind.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên hợp lệ!");
            }
            else
            {
                dgv_sinhvien.DataSource = gradeFind;
            }
        }

        // sự kiện click btn "<<"
        // chọn sinh viên cuối cùng trong dataview
        private void btn_first_Click(object sender, EventArgs e)
        {
            int first = 0;
            dgv_sinhvien.Rows[first].Selected = true;
            dgv_sinhvien.CurrentCell = dgv_sinhvien.Rows[first].Cells[0];
        }


        // sự kiện click btn "<"
        // chọn sinh viên ở phía trước trong dataview
        private void btn_previous_Click(object sender, EventArgs e)
        {
            int pre = dgv_sinhvien.CurrentRow.Index - 1;
            if(pre >= 0)
            {
                dgv_sinhvien.Rows[pre].Selected = true;
                dgv_sinhvien.CurrentCell = dgv_sinhvien.Rows[pre].Cells[0];
            }
        }

        // sự kiện click btn ">"
        // chọn sinh viên ở phía sau trong dataview
        private void btn_next_Click(object sender, EventArgs e)
        {
            int next = dgv_sinhvien.CurrentRow.Index + 1;
            if(next <= dgv_sinhvien.Rows.Count - 1)
            {
                dgv_sinhvien.Rows[next].Selected = true;
                dgv_sinhvien.CurrentCell = dgv_sinhvien.Rows[next].Cells[0];
            }
        }

        // sự kiện click btn ">>"
        // chọn sinh viên cuối cùng trước trong dataview
        private void btn_last_Click(object sender, EventArgs e)
        {
            int last = dgv_sinhvien.Rows.Count - 1;
            dgv_sinhvien.Rows[last].Selected = true;
            dgv_sinhvien.CurrentCell = dgv_sinhvien.Rows[last].Cells[0];
        }
    }
}
