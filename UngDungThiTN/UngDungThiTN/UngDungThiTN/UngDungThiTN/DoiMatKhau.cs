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
    public partial class DoiMatKhau : Form
    {
        DoiMatKhau fmk;
        TaiKhoan_CN TK_cn = new TaiKhoan_CN();
        private string _magiaovien;

        public string Magiaovien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }

        public DoiMatKhau()
        {
            InitializeComponent();
        }


        void delay()
        {
            Thread t = new Thread(() =>
            {
                Thread.Sleep(1500);

                // Kiểm tra xem cửa sổ đã được tạo chưa
                if (this.IsHandleCreated)
                {
                    // Nếu cửa sổ đã được tạo, thực hiện cập nhật UI trên luồng chính
                    this.BeginInvoke(new Action(() =>
                    {
                        lbtrangthai.Text = "";
                    }));
                }
            });

            t.Start();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk = TK_cn.load_taikhoan_GV_id(this.Magiaovien);

            if(txtMKCu.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập mật khẩu cũ!";
                delay();
                txtMKCu.Focus();
            }
            else if(txtMKMoi.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập mật khẩu mới!";
                delay();
                txtMKMoi.Focus();
            }
            else if(txtMKCu.Text != tk.MATKHAU)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Mật khẩu cũ không khớp!";
                delay();
                txtMKCu.Focus();
            }
            else
            {
                try
                {
                    string quyen = "GV";
                    tk.MATKHAU = txtMKMoi.Text;
                    TK_cn.update_taikhoan(tk, quyen);
                    this.Invoke((MethodInvoker)delegate {
                        lbtrangthai.Text = "Đổi mật khẩu thành công!";
                        lbtrangthai.ForeColor = Color.Green;
                    });
                    delay();
                }
                catch (SqlException sql)
                {
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show("Lỗi SQL: " + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            } 
        }
    }
}
