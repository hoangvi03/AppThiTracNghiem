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
using UngDungThiTN.ChucNang;
using UngDungThiTN.UC_CauHoi;

namespace UngDungThiTN.UC
{
    public partial class UC_QLyCauHoi : UserControl
    {
        MonHoc_CN MH_cn = new MonHoc_CN();
        CauHoi_CN CH_cn = new CauHoi_CN();
        DeThi_CN DT_CN = new DeThi_CN();
        public UC_QLyCauHoi()
        {
            InitializeComponent();
        }

        private string _magiaovien;

        public string Magiaovien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        private string _ndcauhoi;
        public string NDCauHoi
        {
            get { return _ndcauhoi; }
            set { _ndcauhoi = value; }
        }

        void setnull(bool temp)
        {
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtCauHoi.Enabled = temp;
        }
        void setEmpty()
        {
            txtCauHoi.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text = "";
        }
        void LoadComboBox()
        {
            cboCauTraLoi.Items.Add("A");
            cboCauTraLoi.Items.Add("B");
            cboCauTraLoi.Items.Add("C");
            cboCauTraLoi.Items.Add("D");
            cboCauTraLoi.SelectedIndex = 0;


            CboMonHoc.DataSource = MH_cn.load_monhoc();
            CboMonHoc.DisplayMember = "TENMONHOC";
            CboMonHoc.ValueMember = "MAMONHOC";
        }
        private void UC_QLyCauHoi_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            setnull(false);
            txtCauHoi.Text = this.NDCauHoi;
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

        private void btnThemCH_Click(object sender, EventArgs e)
        {
            if (txtCauHoi.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập câu hỏi !";
                delay();
                txtCauHoi.Focus();
            }
            else if (txtA.TextLength == 0 || txtB.TextLength == 0 || txtC.TextLength == 0 || txtD.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập Đáp án !";
                delay();
                txtA.Focus();
            }
            else
            {
                try
                {
                    CauHoi ch = new CauHoi();
                    ch.NOIDUNG = txtCauHoi.Text;
                    ch.DA1 = txtA.Text;
                    ch.DA2 = txtB.Text;
                    ch.DA3 = txtC.Text;
                    ch.DA4 = txtD.Text;
                    ch.DAPAN = cboCauTraLoi.SelectedItem.ToString();
                    ch.MADETHI = txtMaDT.Text;
                    if(cboCauTraLoi.SelectedItem.ToString() == "A")
                    {
                        ch.DA = txtA.Text;
                    }
                    else if (cboCauTraLoi.SelectedItem.ToString() == "B")
                    {
                        ch.DA = txtB.Text;
                    }
                    else if (cboCauTraLoi.SelectedItem.ToString() == "C")
                    {
                        ch.DA = txtC.Text;
                    }
                    else
                    {
                        ch.DA = txtD.Text;
                    }

                    CH_cn.insert_cauhoi(ch);
                    lbtrangthai.ForeColor = Color.Green;
                    lbtrangthai.Text = "Thêm câu hỏi thành công!";
                    delay();
                }
                catch(SqlException sql)
                {
                    MessageBox.Show("Lỗi SQL: " + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemDTHI_Click(object sender, EventArgs e)
        {
            if(txtMaDT.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập mã đề thi muốn thêm!";
                delay();
                txtMaDT.Focus();
            }
            else if(CboMonHoc.SelectedIndex < 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn môn học!";
                delay();
                txtMaDT.Focus();
            }
            else
            {
                try
                {
                    int check = DT_CN.Check_deThi(txtMaDT.Text);
                    if (check > 0)
                    {
                        lbtrangthai.ForeColor = Color.Red;
                        lbtrangthai.Text = "Đề thi đã có!";
                        delay();
                    }
                    else
                    {
                        DeThi dt = new DeThi();
                        dt.MADT = txtMaDT.Text;
                        dt.MAMH = CboMonHoc.SelectedValue.ToString();
                        DT_CN.insert_DeThi(dt);
                        lbtrangthai.ForeColor = Color.Green;
                        lbtrangthai.Text = "Thêm mã đề " + dt.MADT + " thành công!";
                        delay();
                    }    
                    
                }
                catch (SqlException sql)
                {
                    MessageBox.Show("Lỗi SQL: " + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = DT_CN.get_MAMH(txtMaDT.Text);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                CboMonHoc.SelectedValue = row["MAMH"].ToString().Replace(" ", "");
            }
            if(DT_CN.Check_deThi(txtMaDT.Text) > 0)
            {
                setnull(true);
            }
            else
            {
                setnull(false);
            }    
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtCauHoi.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập câu hỏi !";
                delay();
                txtCauHoi.Focus();
            }
            else if (txtA.TextLength == 0 || txtB.TextLength == 0 || txtC.TextLength == 0 || txtD.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa nhập Đáp án !";
                delay();
                txtA.Focus();
            }
            else
            {
                try
                {
                    CauHoi ch = new CauHoi();
                    ch.NOIDUNG = txtCauHoi.Text;
                    ch.DA1 = txtA.Text;
                    ch.DA2 = txtB.Text;
                    ch.DA3 = txtC.Text;
                    ch.DA4 = txtD.Text;
                    ch.DAPAN = cboCauTraLoi.SelectedItem.ToString();
                    ch.MADETHI = txtMaDT.Text;
                    if (cboCauTraLoi.SelectedItem.ToString() == "A")
                    {
                        ch.DA = txtA.Text;
                    }
                    else if (cboCauTraLoi.SelectedItem.ToString() == "B")
                    {
                        ch.DA = txtB.Text;
                    }
                    else if (cboCauTraLoi.SelectedItem.ToString() == "C")
                    {
                        ch.DA = txtC.Text;
                    }
                    else
                    {
                        ch.DA = txtD.Text;
                    }

                    CH_cn.update_cauhoi(ch);
                    lbtrangthai.ForeColor = Color.Green;
                    lbtrangthai.Text = "Sửa câu hỏi thành công!";
                    delay();
                }
                catch (SqlException sql)
                {
                    MessageBox.Show("Lỗi SQL: " + sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCauHoi_TextChanged(object sender, EventArgs e)
        {
            int check = CH_cn.Check_CauHoi(this.NDCauHoi);
            if(check > 0)
            {
                DataTable dt = CH_cn.load_cauhoi_chitiet(this.NDCauHoi);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtCauHoi.Text = this.NDCauHoi;
                    txtA.Text = row["DA1"].ToString();
                    txtB.Text = row["DA2"].ToString();
                    txtC.Text = row["DA3"].ToString();
                    txtD.Text = row["DA4"].ToString();
                    cboCauTraLoi.SelectedItem = row["DA4"].ToString();
                    txtD.Text = row["DA4"].ToString();
                    txtMaDT.Text = row["MADT"].ToString();
                }
            }
        }
    }
}
