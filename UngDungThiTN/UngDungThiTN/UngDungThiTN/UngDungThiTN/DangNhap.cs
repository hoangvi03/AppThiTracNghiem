using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class DangNhap : Form
    {
        TaiKhoan_CN TK_cn = new TaiKhoan_CN();

        DangKy dk {  get; set; }
        DangNhap dn { get; set; }
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dn = new DangNhap();
            dk= new DangKy();
            dn.Close();
            dk.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        void delay()
        {
            Thread t = new Thread(() =>
            {
                Thread.Sleep(1500);

                // Sau 1.5 giây, cập nhật UI trên luồng chính
                this.Invoke(new Action(() =>
                {
                    lbtrangthai.Text = "";
                }));
            });

            t.Start();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền tên tài khoản.";
                delay();
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền mật khẩu.";
                delay();
                txtMatKhau.Focus();
            }
            else
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TENTK = txtTaiKhoan.Text;
                tk.MATKHAU = txtMatKhau.Text;
                int trangthaitaikhoan_TS = 0;
                string quyentaikhoan_TS = "";
                trangthaitaikhoan_TS = TK_cn.check_dangnhap_TS(tk);

                int trangthaitaikhoan_GV = 0;
                string quyentaikhoan_GV = "";
                trangthaitaikhoan_GV = TK_cn.check_dangnhap_GV(tk);

                if (trangthaitaikhoan_TS == 1)
                {
                    quyentaikhoan_TS = TK_cn.check_quyentaikhoan_TS(tk);
                    MonThi monthi = new MonThi();
                    monthi.Mathisinh = TK_cn.get_IDTAIKHOAN_TS(tk);
                    if (quyentaikhoan_TS == "TS")
                    {
                        this.Hide();
                        monthi.ShowDialog();
                        Application.Exit();
                    }
                    
                }
                else if(trangthaitaikhoan_GV == 1)
                {
                    quyentaikhoan_GV = TK_cn.check_quyentaikhoan_GV(tk);
                    FormGiaoVien nch = new FormGiaoVien();
                    nch.Magiaovien = TK_cn.get_IDTAIKHOAN_GV(tk);
                    if (quyentaikhoan_GV == "GV")
                    {
                        this.Hide();
                        nch.ShowDialog();
                        Application.Exit();
                    }
                }
                else
                {
                    lbtrangthai.ForeColor = Color.Red;
                    lbtrangthai.Text = "Sai tên tài khoản hoặc mật khẩu.";
                    delay();
                    txtTaiKhoan.Focus();
                }    
            }    
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
