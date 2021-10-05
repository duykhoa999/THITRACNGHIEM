using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class frmDN : DevExpress.XtraEditors.XtraForm
    {
        public frmDN()
        {
            InitializeComponent();
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPM.v_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.v_DSPM.v_DS_PHANMANH);

            string chuoiketnoi = "Data Source=DESKTOP-15RBEV5;Initial Catalog=TN_CSDLPT;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM v_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cbCS.DataSource = dt;
            cbCS.DisplayMember = "TENCN";
            cbCS.ValueMember = "TEN_SERVER";
            cbCS.SelectedIndex = 0;
            txtMatKhau.Enabled = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.mCoso = cbCS.SelectedIndex;
            string StrLenh = "";

            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0) return;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            StrLenh = "EXEC dbo.SP_THONGTINDANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(StrLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // đọc 1 dòng

            Program.username = Program.myReader.GetString(0);     // Lay user name

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            frmMain form = new frmMain();
            form.hienThiMenu();
            form.ShowDialog();
        }

        private void cbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbCS.SelectedValue.ToString();
            }
            catch (Exception)
            {
            };
        }
    }
}