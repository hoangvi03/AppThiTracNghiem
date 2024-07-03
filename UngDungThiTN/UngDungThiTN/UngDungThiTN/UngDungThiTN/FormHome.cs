using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChucNang;
using Classes;
//using ChucNang;

namespace UngDungThiTN
{
    public partial class FormHome : Form
    {
        GiaoVien_CN GV_cn = new GiaoVien_CN();
        DoiMatKhau DoiMatKhau;
        DangNhap dn;
        FormGiaoVien gv;

        private string _magiaovien;

        public string Magiaovien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            GiaoVien gv = GV_cn.load_giaovien_id(this.Magiaovien);
            txtMaGV.Text = gv.MAGV;
            txtHoTenGV.Text = gv.TENGV;
            txtGioiTinh.Text = gv.GIOITINH;
            dtpNgaySinh.Text = gv.NGAYSINH.ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Ẩn cả hai form đang chạy
            FormGiaoVien frmGiaoVien = Application.OpenForms.OfType<FormGiaoVien>().FirstOrDefault();
            FormHome frmHome = Application.OpenForms.OfType<FormHome>().FirstOrDefault();

            if (frmGiaoVien != null)
            {
                frmGiaoVien.Hide();
            }

            if (frmHome != null)
            {
                frmHome.Hide();
            }

            // Tạo và hiển thị form đăng nhập mới
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau = new DoiMatKhau();
            GiaoVien gv = new GiaoVien();
            gv.MAGV = this.Magiaovien;
            DoiMatKhau.Magiaovien = GV_cn.get_MaGV_ID(gv);
            DoiMatKhau.FormClosed += DoiMatKhau_FormClosed;
            DoiMatKhau.Dock = DockStyle.Fill;
            DoiMatKhau.Show();
        }
        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoiMatKhau = null;
        }

    }
}
