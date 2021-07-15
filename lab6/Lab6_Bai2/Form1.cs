using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Bai2
{
    public partial class Form1 : Form
    {
        BookContext db = new BookContext();
        public Form1()
        {
            InitializeComponent();
            CreateDataBase();
            LoadDataBase();
        }
        /// <summary>
        /// tạo database
        /// </summary>
        void CreateDataBase()
        {

                db.Database.CreateIfNotExists();
        }

        /// <summary>
        /// hiển thị dữ liệu lên grid view
        /// </summary>
        void LoadDataBase()
        {
            var ListBook = from x in db.Books
                           select new
                           {
                               MaSach = x.Ma_Sach,
                               TieuDe = x.Tieu_De,
                               Gia = x.Gia,
                               SoLuong = x.So_Luong,
                               LoaiSach = x.Category.CategoryName,
                           };
                dataGridView1.DataSource = ListBook.ToList();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                btn_xoa.Enabled = false;
                btn_luu.Enabled = false;
                btn_boqua.Enabled = false;
                btn_sua.Enabled = false;

                txb_Enable(false);

                LoadCateGory();
        }

        /// <summary>
        /// load category
        /// </summary>
        void LoadCateGory()
        {
             //AddCategory();

             cbx_cate.DataSource = db.Category.ToList();
             cbx_cate.DisplayMember = "CategoryName";
        }

        /// <summary>
        /// add category
        /// </summary>
        void AddCategory()
        {
                var categories = new List<Category>()
                {
                    new Category() {CategoryName = "Programming", CategoryId = 1},
                    new Category() {CategoryName = "DataBase", CategoryId = 2},
                    new Category() {CategoryName = "Wed Design", CategoryId = 3},
                    new Category() {CategoryName = "Graphic", CategoryId = 4},
                    new Category() {CategoryName = "Children", CategoryId = 5},

                };

                foreach (Category cate in categories)
                {
                    db.Category.Add(cate);
                    db.SaveChanges();
                }

                cbx_cate.DataSource = db.Category.ToList();
                cbx_cate.DisplayMember = "CategoryName";
        }

        /// <summary>
        /// enable các txbox
        /// </summary>
        /// <param name="isEnable"></param>
        void txb_Enable(bool isEnable)
        {
            txb_ma.Enabled = isEnable;
            txb_price.Enabled = isEnable;
            txb_soluong.Enabled = isEnable;
            txb_title.Enabled = isEnable;
            cbx_cate.Enabled = isEnable;
        }

        /// <summary>
        /// clear texbox
        /// </summary>
        void clear_txb()
        {
            txb_ma.Text = "";
            txb_price.Text = "";
            txb_soluong.Text = "";
            txb_title.Text = "";
            cbx_cate.SelectedIndex = 0;
        }

        /// <summary>
        /// when click 1 cell trên gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_ma.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
            txb_title.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["TieuDe"].Value.ToString();
            txb_price.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["Gia"].Value.ToString();
            txb_soluong.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString();

            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            txb_Enable(true);
        }

        /// <summary>
        /// when click btn thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_them_Click(object sender, EventArgs e)
        {
            clear_txb();
            txb_Enable(true);
            btn_luu.Enabled = true;
            btn_boqua.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        /// <summary>
        /// kiểm tra dữ liệu
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(txb_ma.Text) ||
                string.IsNullOrEmpty(txb_title.Text) ||
                string.IsNullOrEmpty(txb_soluong.Text) ||
                string.IsNullOrEmpty(txb_price.Text))
            {
                MessageBox.Show("vui lòng nhập đầy đủ dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsNumeric(txb_ma.Text) ||
                   !IsNumeric(txb_soluong.Text) ||
                   !IsNumeric(txb_price.Text))
            {
                MessageBox.Show("vui lòng nhập đúng dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsNumeric(string text)
        {
            return double.TryParse(text, out double test);
        }

        /// <summary>
        /// kiểm tra trùng mã sách
        /// </summary>
        /// <returns></returns>
        bool isDuplicateId()
        {
            if (IsNumeric(txb_ma.Text))
            {
                int ma = Convert.ToInt32(txb_ma.Text);
                var result = db.Books.FirstOrDefault(x => x.Ma_Sach == ma);
                if(result == null)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("mã sách này đã tồn tại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return false;
        }

        /// <summary>
        /// thêm sách
        /// </summary>
        bool AddBook()
        {
            if (CheckInput() && isDuplicateId()) 
            {
                try
                {
                    Category cate = cbx_cate.SelectedItem as Category;
                    var book = new Book()
                    {
                        Ma_Sach = int.Parse(txb_ma.Text),
                        Tieu_De = txb_title.Text,
                        Gia = float.Parse(txb_price.Text),
                        So_Luong = int.Parse(txb_soluong.Text),
                        CategoryId = cate.CategoryId,
                    };

                    db.Books.Add(book);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
            
        }

       
       
        /// <summary>
        /// thong báo
        /// </summary>
        /// <param name="result"></param>
        /// <param name="str"></param>
        void Notify(bool result,string str)
        {
            if (result)
            {
                MessageBox.Show(str + " successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataBase();
                clear_txb();
            }
            else
            {
                MessageBox.Show(str + " error!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// when click btn_boqua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_boqua_Click(object sender, EventArgs e)
        {
            clear_txb();
        }

        /// <summary>
        /// when click btn_luu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_luu_Click(object sender, EventArgs e)
        {
            bool result = AddBook();
            Notify(result, "Add Book");
        }

        /// <summary>
        /// when click btn xóa book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool result = RemoveBook();
            Notify(result, "Remove Book");
        }

        /// <summary>
        /// xóa book
        /// </summary>
        /// <returns></returns>
        bool RemoveBook()
        {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa không?", "notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        int masach = int.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString());

                        Book book = db.Books.Where(x => x.Ma_Sach == masach).SingleOrDefault();
                        db.Books.Remove(book);
                        db.SaveChanges();
                        return true;
                    }
                    catch { return false; }
                }
                return false;
            
        }

        /// <summary>
        /// when click sua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool result = update();
            Notify(result, "update");
        }

        /// <summary>
        /// update book
        /// </summary>
        /// <returns></returns>
        bool update()
        {
            if (CheckInput())
            {
                try
                {
                    int ma =
                    int.Parse(txb_ma.Text = dataGridView1.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString());

                    var bookupdate = db.Books.First(x => x.Ma_Sach == ma);

                    Category cate = cbx_cate.SelectedItem as Category;

                    bookupdate.Ma_Sach = int.Parse(txb_ma.Text);
                    bookupdate.Tieu_De = txb_title.Text;
                    bookupdate.Gia = float.Parse(txb_price.Text);
                    bookupdate.So_Luong = int.Parse(txb_soluong.Text);
                    bookupdate.CategoryId = cate.CategoryId;

                    db.SaveChanges();
                    btn_them.Enabled = true;
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
    }
}
