using Demo3Layer.BUS;
using Demo3Layer.BUS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3Layer.GUI
{
    public partial class frmLogin : Form
    {
        private readonly UserBUS _userBUS;
        public frmLogin()
        {
            InitializeComponent();
            _userBUS = new UserBUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!_userBUS.Login(textBox1.Text,textBox2.Text))
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Utilities.User = _userBUS.GetUserByUserName(textBox1.Text);
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
