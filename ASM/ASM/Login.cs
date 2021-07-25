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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using(fpl_daotaoEntities1 db = new fpl_daotaoEntities1())
            {
                users_Login user = db.users_Login
                    .Where(x => x.username == txb_userName.Text && x.passwork == txb_Passwork.Text)
                    .Select(x => x)
                    .FirstOrDefault();

                // sau khi kiểm tra tài khoản đúng thì sẽ kiểm tra role để mở form tương ứng
                if (user == null)
                {
                    MessageBox.Show("Sai tài khoản hoăc mật khẩu!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!");
                   if(user.role == "canbo"){
                        this.Hide();
                        CanBo frm_cb = new CanBo();
                        frm_cb.ShowDialog();
                        this.Show();
                   }
                    else if(user.role == "giangvien")
                   {
                        this.Hide();
                        GiangVien frm_gv = new GiangVien();
                        frm_gv.ShowDialog(this);
                        this.Show();
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
