using Demo3Layer.BUS.Helper;

namespace Demo3Layer.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilities.User = null;

            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void userInfo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tên: {Utilities.User?.UserName}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLopHoc frmLopHoc = new frmLopHoc();
            frmLopHoc.TopLevel = false;
            panel1.Controls.Add(frmLopHoc);
            frmLopHoc.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showDSLop_Click(object sender, EventArgs e)
        {
            frmLopHoc frmLopHoc = new frmLopHoc();
            frmLopHoc.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmLopHoc);
            frmLopHoc.Show();
        }

        private void dSSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            frmSinhVien.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmSinhVien);
            frmSinhVien.Show();
        }
    }
}
