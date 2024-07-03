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
    public partial class FormChamDiem : Form
    {

        InPhieuDiem_CN PD_CN = new InPhieuDiem_CN();

        private string _magiaovien;
        public string MaGiaoVien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        private string _mamonhoc;
        public string MaMonHoc
        {
            get { return _mamonhoc; }
            set { _mamonhoc = value; }
        }
        private string _mathisinh;
        public string MaThiSinh
        {
            get { return _mathisinh; }
            set { _mathisinh = value; }
        }
        private string _madethi;
        public string MaDeThi
        {
            get { return _madethi; }
            set { _madethi = value; }
        }
        public FormChamDiem()
        {
            InitializeComponent();
        }

        ThiSinh_CN TS_CN = new ThiSinh_CN();
        void getThiSinh()
        {
            ThiSinh ts = TS_CN.load_thisinh_id(this.MaThiSinh);
            txtMaTS.Text = ts.MATS;
            txtTenTS.Text = ts.TENTHISINH;
        }

        MonHoc_CN MH_CN = new MonHoc_CN();
        void getMonHoc()
        {
            MonHoc mh = MH_CN.load_monhoc_id(this.MaMonHoc);
            txtMonThi.Text = mh.TENMONHOC;
        }

        DSNopBai_CN DSNB_CN = new DSNopBai_CN();
        void getPhieuDiem()
        {
            DSNopBai dsnb = DSNB_CN.load_NopBai_TS(this.MaThiSinh, this.MaDeThi);
            if(dsnb != null)
            {
                txtSoCauDung.Text = dsnb.SOCAUDUNG.ToString();
                txtSoCauSai.Text = dsnb.SOCAUSAI.ToString();
            }
            else
            {
                txtSoCauDung.Text = "0";
                txtSoCauSai.Text = "0";
            }
        }


        CauHoi_CN CH_CN = new CauHoi_CN();
        void loadDataGridView()
        {
            CauHoi ch = new CauHoi();
            ch.MADETHI = this.MaDeThi;
            dgvDSCHDaLam.DataSource = CH_CN.load_cauhoi_DeThi(this.MaDeThi);
            txtSoCauHoi.Text = CH_CN.TongCauHoi(this.MaDeThi).ToString();
            getPhieuDiem();
            getMonHoc();
            getThiSinh();
            txtDiemTong.Text = "0";
        }
        private float TongDiem()
        {
            char laststr = txtDiemMoiCau.Text[txtDiemMoiCau.Text.Length - 1];
            if (double.TryParse(txtDiemMoiCau.Text.Replace(',', '.'), out double diem))
            {
                if(laststr != '.')
                {
                    int soCauDung = int.Parse(txtSoCauDung.Text);
                    float diemMoiCau = float.Parse(txtDiemMoiCau.Text);
                    return soCauDung * diemMoiCau;
                }    
            }
            return 0;
        }
        
        private void FormChamDiem_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadDataGridView();
        }

        private void dgvDSCHDaLam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnInDiem_Click(object sender, EventArgs e)
        {
            InPhieuDiem inpd = new InPhieuDiem();
            inpd.Monthi = txtMonThi.Text;
            inpd.Madethi = this.MaDeThi;
            inpd.MATS = this.MaThiSinh;
            inpd.MAGV = this.MaGiaoVien;
            inpd.Tongdiem = float.Parse(txtDiemTong.Text);
            inpd.Socaudung = int.Parse(txtSoCauDung.Text);
            inpd.Socausai = int.Parse(txtSoCauSai.Text);
            inpd.Tongsocau = int.Parse(txtSoCauHoi.Text);

            PD_CN.insert_PhieuDiem(inpd);
            lbtrangthai.ForeColor = Color.Green;
            lbtrangthai.Text = "Thêm thành công!";
            delay();
        }



        private void txtDiemMoiCau_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có khác rỗng hoặc chỉ chứa khoảng trắng không
            if (!string.IsNullOrWhiteSpace(txtDiemMoiCau.Text))
            {
                // Thay thế dấu phẩy bằng dấu chấm để xử lý cả hai loại dấu thập phân
                string cleanedInput = txtDiemMoiCau.Text.Replace(',', '.');

                // Kiểm tra xem dữ liệu sau khi làm sạch có phải là một số thực hợp lệ không
                if (double.TryParse(cleanedInput, out double diem))
                {
                    txtDiemTong.Text = TongDiem().ToString();
                }
                //else
                //{
                //    // Xử lý trường hợp dữ liệu không phải là số thực hợp lệ
                //    txtDiemTong.Text = "0";
                //}
            }
            else
            {
                // Xử lý trường hợp TextBox rỗng
                txtDiemTong.Text = "0";
            }
        }


        private bool hasDecimalPoint = false;

        private void txtDiemMoiCau_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép chữ số, dấu thập phân và các phím điều khiển (ví dụ: backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;  // Tắt sự kiện khi nhấn các phím khác
            }

            // Kiểm tra xem đã có dấu thập phân chưa
            if ((e.KeyChar == '.') && hasDecimalPoint)
            {
                e.Handled = true;  // Tắt sự kiện khi có nhiều hơn một dấu thập phân
            }
        }

    }
}
