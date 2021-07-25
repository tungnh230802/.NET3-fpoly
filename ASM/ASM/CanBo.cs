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
    public partial class CanBo : Form
    {
        fpl_daotaoEntities1 db = new fpl_daotaoEntities1();
        public CanBo()
        {
            InitializeComponent();
            FillData();
            dgv_students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillData()
        {
            dgv_students.DataSource = db.students.Select(x => new
            {
                MaSV = x.masv,
                HoTen = x.hoten,
                GioiTinh = x.gioitinh,
                Email = x.email,
                SoDT = x.sodt,
                DiaChi = x.diachi,
                Hinh = x.hinh,
            }).ToList();
            loadImg(null);
        }

        private void ShowStatus(bool result, string str)
        {
            if (result)
            {
                MessageBox.Show(str + " Successfully!"
               , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData();
            }
            else
            {
                MessageBox.Show(str + " some went wrong!..please try again!..", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearField()
        {
            txb_id.Text = "";
            txb_name.Text = "";
            txb_address.Text = "";
            txb_phone.Text = "";
            txb_email.Text = "";
            rdo_nam.Checked = true;
            txb_img.Text = "";
            loadImg(null);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private bool SaveStudentDetail(student st)
        {
            bool result = false;
            try
            {
                st.masv = txb_id.Text;
                st.hoten = txb_name.Text;
                st.email = txb_email.Text;
                st.sodt = txb_phone.Text;
                st.diachi = txb_address.Text;
                st.gioitinh = rdo_nam.Checked;
                st.hinh = txb_img.Text;
                db.students.Add(st);
                db.SaveChanges();
                result = true;
            }
            catch { }

            return result;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool result = false;
            student st = new student();
            result = SaveStudentDetail(st);

            ShowStatus(result, "Save");
        }

        private bool DeleteStudentDetail(student st)
        {
            bool result = false;
            try
            {
                db.students.Remove(st);
                db.SaveChanges();
                result = true;
            }
            catch { }

            return result;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool result = false;
            student st = db.students.Find(txb_id.Text);
            result = DeleteStudentDetail(st);
            ShowStatus(result, "Delete");
        }

        private void CheckDataNull(object obj, TextBox txb)
        {
            // fix lỗi column trong dataview nếu bị bị null
            if(obj is null)
            {
                txb.Text = "";
            }
            else
            {
                txb.Text = obj.ToString();
            }
        }

        private void ConverGender(bool Gender)
        {
            // nếu true thì radio "nam" sẽ được checked và ngược lại
            if(Gender == true)
            {
                rdo_nam.Checked = true;
            }
            else
            {
                rdo_nu.Checked = true;
            }
        }

        private void loadImg(object obj)
        {
            //load img
            // nếu stundent có ảnh thì load lên picturebox, nếu không thì sẽ có ảnh mặc định
            if(obj!=null)
            {
                try
                {
                    ptb_img.Image = new Bitmap(Application.StartupPath + $"\\Image\\{obj.ToString()}");

                }
                catch 
                {
                    ptb_img.Image = new Bitmap(Application.StartupPath + $"\\Image\\default.jpg");
                }
            }
            else
            {
                ptb_img.Image = new Bitmap(Application.StartupPath + $"\\Image\\default.jpg");
            }
        }

        private void BidingData()
        {
            try
            {
                txb_id.Text = dgv_students.SelectedCells[0].OwningRow.Cells["masv"].Value.ToString();
                ConverGender(bool.Parse(dgv_students.SelectedCells[0].OwningRow.Cells["gioitinh"].Value.ToString()));
                CheckDataNull(dgv_students.SelectedCells[0].OwningRow.Cells["hoten"].Value, txb_name);
                CheckDataNull(dgv_students.SelectedCells[0].OwningRow.Cells["email"].Value, txb_email);
                CheckDataNull(dgv_students.SelectedCells[0].OwningRow.Cells["sodt"].Value, txb_phone);
                CheckDataNull(dgv_students.SelectedCells[0].OwningRow.Cells["diachi"].Value, txb_address);
                CheckDataNull(dgv_students.SelectedCells[0].OwningRow.Cells["hinh"].Value, txb_img);
                loadImg(dgv_students.SelectedCells[0].OwningRow.Cells["hinh"].Value);
            }
            catch { }

        }

        private void dgv_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BidingData();
        }

        private bool UpdateStudentDetail(student st)
        {
            bool result = false;
            try
            {
                st.masv = txb_id.Text;
                st.hoten = txb_name.Text;
                st.email = txb_email.Text;
                st.sodt = txb_phone.Text;
                st.gioitinh = rdo_nam.Checked;
                st.diachi = txb_address.Text;
                st.hinh = txb_img.Text;
                db.SaveChanges();
                result = true;
            }
            catch { }
            return result;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            bool result = false;
            student st = db.students.Find(txb_id.Text);
            result = UpdateStudentDetail(st);

            ShowStatus(result, "Update");
        }
    }
}
