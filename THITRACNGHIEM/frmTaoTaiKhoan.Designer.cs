﻿
namespace THITRACNGHIEM
{
    partial class frmTaoTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.cbTenGV = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tHITN = new THITRACNGHIEM.THITN();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new THITRACNGHIEM.THITNTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.THITNTableAdapters.TableAdapterManager();
            this.dsGV = new THITRACNGHIEM.dsGV();
            this.v_DSGVChuaCoTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSGVChuaCoTaiKhoanTableAdapter = new THITRACNGHIEM.dsGVTableAdapters.V_DSGVChuaCoTaiKhoanTableAdapter();
            this.tableAdapterManager1 = new THITRACNGHIEM.dsGVTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).BeginInit();
            this.groupDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHITN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSGVChuaCoTaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDangNhap
            // 
            this.groupDangNhap.CausesValidation = false;
            this.groupDangNhap.Controls.Add(this.cbTenGV);
            this.groupDangNhap.Controls.Add(this.btnThoat);
            this.groupDangNhap.Controls.Add(this.btnTaoTK);
            this.groupDangNhap.Controls.Add(this.tbMatKhau);
            this.groupDangNhap.Controls.Add(this.tbTaiKhoan);
            this.groupDangNhap.Controls.Add(this.cbNhom);
            this.groupDangNhap.Controls.Add(this.label4);
            this.groupDangNhap.Controls.Add(this.label3);
            this.groupDangNhap.Controls.Add(this.label2);
            this.groupDangNhap.Controls.Add(this.label1);
            this.groupDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDangNhap.Location = new System.Drawing.Point(0, 0);
            this.groupDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupDangNhap.Name = "groupDangNhap";
            this.groupDangNhap.Size = new System.Drawing.Size(1222, 650);
            this.groupDangNhap.TabIndex = 3;
            // 
            // cbTenGV
            // 
            this.cbTenGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenGV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenGV.FormattingEnabled = true;
            this.cbTenGV.Location = new System.Drawing.Point(405, 462);
            this.cbTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenGV.Name = "cbTenGV";
            this.cbTenGV.Size = new System.Drawing.Size(470, 28);
            this.cbTenGV.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(710, 571);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 59);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.Location = new System.Drawing.Point(405, 571);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(166, 59);
            this.btnTaoTK.TabIndex = 5;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(405, 380);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(469, 29);
            this.tbMatKhau.TabIndex = 4;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaiKhoan.Location = new System.Drawing.Point(405, 306);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(469, 29);
            this.tbTaiKhoan.TabIndex = 4;
            // 
            // cbNhom
            // 
            this.cbNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhom.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(405, 219);
            this.cbNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(469, 29);
            this.cbNhom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhóm";
            // 
            // tHITN
            // 
            this.tHITN.DataSetName = "THITN";
            this.tHITN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.tHITN;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.THITNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dsGV
            // 
            this.dsGV.DataSetName = "dsGV";
            this.dsGV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSGVChuaCoTaiKhoanBindingSource
            // 
            this.v_DSGVChuaCoTaiKhoanBindingSource.DataMember = "V_DSGVChuaCoTaiKhoan";
            this.v_DSGVChuaCoTaiKhoanBindingSource.DataSource = this.dsGV;
            // 
            // v_DSGVChuaCoTaiKhoanTableAdapter
            // 
            this.v_DSGVChuaCoTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = THITRACNGHIEM.dsGVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 650);
            this.Controls.Add(this.groupDangNhap);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).EndInit();
            this.groupDangNhap.ResumeLayout(false);
            this.groupDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHITN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSGVChuaCoTaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupDangNhap;
        private System.Windows.Forms.ComboBox cbTenGV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private THITN tHITN;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private THITNTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private THITNTableAdapters.TableAdapterManager tableAdapterManager;
        private dsGV dsGV;
        private System.Windows.Forms.BindingSource v_DSGVChuaCoTaiKhoanBindingSource;
        private dsGVTableAdapters.V_DSGVChuaCoTaiKhoanTableAdapter v_DSGVChuaCoTaiKhoanTableAdapter;
        private dsGVTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}