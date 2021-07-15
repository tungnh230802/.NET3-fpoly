using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// load data vào gridview
        /// </summary>
        void LoadData()
        {
            cbo_gender.Items.Add("Male");
            cbo_gender.Items.Add("Female");
            Display();
        }

        /// <summary>
        /// hiển thị data
        /// </summary>
        void Display()
        {
            using (studentInfomationEntities _entity = new studentInfomationEntities())
            {
                List<StudentInfromation> _studentList = new List<StudentInfromation>();

                _studentList = _entity.studentdetails.Select(x => new StudentInfromation
                {
                    id = x.id,
                    name = x.name,
                    age = x.age,
                    city = x.city,
                    gender = x.gender
                }).ToList();

                dataGridView1.DataSource = _studentList;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        /// <summary>
        /// sử lý khi ấn save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            bool result = false;
            try
            {
                if (check_input())
                {
                    studentdetail stu = new studentdetail();

                    stu.name = txb_name.Text;
                    stu.age = Convert.ToInt32(txb_age.Text);
                    stu.city = txb_city.Text;
                    stu.gender = cbo_gender.SelectedItem.ToString();

                    result = SaveStudentDetails(stu);
                }
            }catch { result = false; }
            ShowStatus(result, "save");

        }

        /// <summary>
        /// kiểm tra rỗng 
        /// </summary>
        /// <returns></returns>
        private bool check_input()
        {
            if (string.IsNullOrEmpty(txb_name.Text) ||
              string.IsNullOrEmpty(txb_age.Text) ||
              string.IsNullOrEmpty(txb_city.Text) ||
              string.IsNullOrEmpty(cbo_gender.SelectedItem.ToString()))
            {
                MessageBox.Show("vui lòng điền đẩy đủ thông tin");
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// xử lý khi lưu user mới
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        bool SaveStudentDetails(studentdetail stu)
        {
            bool result = false;
            using(studentInfomationEntities _entity = new studentInfomationEntities())
            {
                _entity.studentdetails.Add(stu);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        /// <summary>
        /// thông báo
        /// </summary>
        /// <param name="result"></param>
        /// <param name="str"></param>
        void ShowStatus(bool result, string str)
        {
            if (result) MessageBox.Show(str + " Successfully!"
                ,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(str + " some went wrong!..please try again!..", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Display();
            ClearFiels();
        }

        /// <summary>
        /// clear fiels
        /// </summary>
        void ClearFiels()
        {
            txb_age.Text = "";
            txb_name.Text = "";
            txb_city.Text = "";
            cbo_gender.SelectedIndex = -1;
        }

        /// <summary>
        /// xử lý khi click cell trong gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txb_name.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["name"].Value.ToString();
            txb_id.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            txb_age.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["age"].Value.ToString();
            txb_city.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["city"].Value.ToString();
            cbo_gender.SelectedItem = dataGridView1.SelectedCells[0].OwningRow.Cells["gender"].Value.ToString();
        }

        /// <summary>
        /// xử lý khi ấn update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            bool result;
            try
            {
                if (check_input())
                {
                    studentdetail stu = new studentdetail()
                    {
                        name = txb_name.Text,
                        id = Convert.ToInt32(txb_id.Text),
                        age = Convert.ToInt32(txb_age.Text),
                        city = txb_city.Text,
                        gender = cbo_gender.SelectedItem.ToString(),
                    };
                    result = UpdateStudentDetails(stu);

                }
                else result = false;

            }
            catch { result = false; }
            
            ShowStatus(result, "update");
        }

        /// <summary>
        /// xử lý cập nhật
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        private bool UpdateStudentDetails(studentdetail stu)
        {
            bool result = false;
            using(studentInfomationEntities _entity = new studentInfomationEntities())
            {
                studentdetail studentdetail = _entity.studentdetails.Where(x => x.id == stu.id).
                    Select(x => x).FirstOrDefault();
                studentdetail.name = stu.name;
                studentdetail.age = stu.age;
                studentdetail.city = stu.city;
                studentdetail.gender = stu.gender;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        /// <summary>
        /// xử lý khi ấn delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool result;
            try
            {
                studentdetail stu = new studentdetail()
                {
                    id = Convert.ToInt32(txb_id.Text),
                };
                result = DeleteStudentDetails(stu);
            }
            catch { result = false; }
            
            ShowStatus(result, "delete");
        }

        /// <summary>
        /// xử lý delete student
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        bool DeleteStudentDetails(studentdetail stu)
        {
            bool result = false;
            using(studentInfomationEntities _entity = new studentInfomationEntities())
            {
                studentdetail _student = _entity.studentdetails.Where(x => x.id == stu.id).Select(x => x).FirstOrDefault();
                    _entity.studentdetails.Remove(_student);
                    _entity.SaveChanges();
                    result = true;
                
            }
            return result;
        }
    }   
   
}
