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
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        string maKH = "";

        private Boolean isDangThem, isDangSua = false;

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOSOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tHITN);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            tHITN.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.tHITN.GIAOVIEN);


            dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
            cmbMaKhoa.DataSource = dt;
            cmbMaKhoa.DisplayMember = "TENKH";
            cmbMaKhoa.ValueMember = "MAKH";
            cmbMaKhoa.SelectedIndex = 0;

            maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
            this.gIAOVIENBindingSource.Filter = "MAKH = '" + maKH + "'";


            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TEN_SERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            gcThongTin.Enabled = false;

            if (gIAOVIENBindingSource.Count == 0)
                btnXoa.Enabled = false;

        }

        private void gcKhoa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {

                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.tHITN.GIAOVIEN);

                dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
                cmbMaKhoa.DataSource = dt;
                cmbMaKhoa.DisplayMember = "TENKH";
                cmbMaKhoa.ValueMember = "MAKH";
                cmbMaKhoa.SelectedIndex = 0;

                maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
                this.gIAOVIENBindingSource.Filter = "MAKH = '" + maKH + "'";

            }
        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
            this.gIAOVIENBindingSource.Filter = "MAKH = '" + maKH + "'";

            btnXoa.Enabled = false;
            if (gIAOVIENBindingSource.Count != 0)
                btnXoa.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIENBindingSource.RemoveCurrent();
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.tHITN.GIAOVIEN);
            gcThongTin.Enabled = false;
            cmbMaKhoa.Enabled = true;


            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            btnPhucHoi.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIENBindingSource.AddNew();

            txtMaKH.Text = cmbMaKhoa.SelectedValue.ToString();
            txtMaKH.Enabled = false;

            gcThongTin.Enabled = true;
            txtMaGV.Focus();

            isDangThem = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = true;
            cmbMaKhoa.Enabled = false;
        }
    }
}