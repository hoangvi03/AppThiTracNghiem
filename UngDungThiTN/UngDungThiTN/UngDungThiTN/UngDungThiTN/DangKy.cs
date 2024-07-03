using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChucNang;
using Classes;

namespace UngDungThiTN
{
    public partial class DangKy : Form
    {
        GiaoVien_CN GV_cn = new GiaoVien_CN();
        ThiSinh_CN TS_cn = new ThiSinh_CN();
        TaiKhoan_CN TK_cn = new TaiKhoan_CN();
        public DangKy()
        {
            InitializeComponent();
        }
        private void set_tabindex()
        {
            txtTaiKhoan.TabIndex = 0;
            txtMK.TabIndex = 1;
            txtReMK.TabIndex = 2;
            txtMa.TabIndex = 3;
            txtHoTen.TabIndex = 4;
            CboGioiTinh.TabIndex = 5;
            dtpNgaySinh.TabIndex = 6;
            RdoGV.TabIndex = 7;
            RdoTS.TabIndex = 8;
        }
        private void reset_values()
        {
            txtHoTen.Clear();
            txtMa.Clear();
            txtTaiKhoan.Clear();
            txtMK.Clear();
            CboGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today;
            RdoGV.Checked = false;
            RdoTS.Checked = false;
            CboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void LoadComBoBox()
        {
            CboGioiTinh.Items.Add("Nam");
            CboGioiTinh.Items.Add("Nữ");
        }
        private void DangKy_Load(object sender, EventArgs e)
        {
            LoadComBoBox();
            set_tabindex();
        }


        

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtHoTen.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền họ tên.";
            }
            else if (txtTaiKhoan.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền tên tài khoản.";
            }
            else if(txtMK.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền mật khẩu.";
            }
            else if (txtReMK.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền lại mật khẩu.";
            }
            else if(txtMK.Text != txtReMK.Text)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Mật khẩu không trùng khớp.";
            }
            else if(txtMa.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền mã người dùng..";
            }
            else if(CboGioiTinh.SelectedItem.ToString() == "")
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn giới tính.";
            }
            else
            {
                if(RdoGV.Checked == true)
                {
                    try
                    {
                        GiaoVien gv = new GiaoVien();
                        gv.MAGV = txtMa.Text;
                        gv.TENGV = txtHoTen.Text;
                        gv.GIOITINH = CboGioiTinh.SelectedItem.ToString();
                        gv.NGAYSINH = DateTime.Parse(dtpNgaySinh.Value.ToString("MM-dd-yyyy"));
                        GV_cn.insert_giaovien(gv);

                        TaiKhoan tk = new TaiKhoan();
                        tk.TENTK = txtTaiKhoan.Text;
                        tk.MATKHAU = txtMK.Text;
                        tk.IDTAIKHOAN = txtMa.Text;
                        tk.QUYEN = "GV";
                        TK_cn.insert_taikhoan(tk, tk.QUYEN);
                        lbtrangthai.ForeColor = Color.Green;
                        lbtrangthai.Text = "Đăng ký tài khoản GV thành công.";
                        reset_values();
                        this.Close();
                    }
                    catch (SqlException sql)
                    {
                        if (sql.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'. Cannot insert duplicate key in object 'dbo.taikhoan'"))
                        {
                            lbtrangthai.ForeColor = Color.Red;
                            lbtrangthai.Text = "Tên tài khoản bị trùng.";
                        }
                        else
                        {
                            lbtrangthai.ForeColor = Color.Red;
                            lbtrangthai.Text = "Mã giáo viên bị trùng.";
                        }
                    }
                }
                else
                {
                    try
                    {
                        ThiSinh ts = new ThiSinh();
                        ts.MATS = txtMa.Text;
                        ts.TENTHISINH = txtHoTen.Text;
                        ts.GIOITINH = CboGioiTinh.SelectedItem.ToString();
                        ts.NGAYSINH = DateTime.Parse(dtpNgaySinh.Value.ToString("MM-dd-yyyy"));
                        TS_cn.insert_thisinh(ts);

                        TaiKhoan tk = new TaiKhoan();
                        tk.TENTK = txtTaiKhoan.Text;
                        tk.MATKHAU = txtMK.Text;
                        tk.IDTAIKHOAN = txtMa.Text;
                        tk.QUYEN = "TS";
                        TK_cn.insert_taikhoan(tk, tk.QUYEN);
                        lbtrangthai.ForeColor = Color.Green;
                        lbtrangthai.Text = "Đăng ký tài khoản thí sinh thành công.";
                        reset_values();
                        this.Close();
                    }
                    catch(SqlException sql)
                    {
                        if (sql.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'. Cannot insert duplicate key in object 'dbo.taikhoan'"))
                        {
                            lbtrangthai.ForeColor = Color.Red;
                            lbtrangthai.Text = "Tên tài khoản bị trùng.";
                        }
                        else
                        {
                            lbtrangthai.ForeColor = Color.Red;
                            lbtrangthai.Text = "Mã bị trùng.";
                        }
                    }
                }
            }    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
