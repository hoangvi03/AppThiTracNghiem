using System;
using System.CodeDom.Compiler;
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
using UngDungThiTN.ChucNang;

namespace UngDungThiTN
{
    public partial class FormThiSinh : Form
    {

        ThiSinh_CN TS_cn = new ThiSinh_CN();
        MonHoc_CN MH_cn = new MonHoc_CN();
        CauHoi_CN CH_cn = new CauHoi_CN();
        DeThi_CN DT_CN = new DeThi_CN();
        private string _mathisinh;

        public string Mathisinh
        {
            get { return _mathisinh; }
            set { _mathisinh = value; }
        }

        private string _mamonhoc;

        public string Mamonhoc
        {
            get { return _mamonhoc; }
            set { _mamonhoc = value; }
        }
        private string _dethi;

        public string Dethi
        {
            get { return _dethi; }
            set { _dethi = value; }
        }

        void loadDSCauHoi()
        {
            dgvDSCauHoi.DataSource = TS_cn.loadCauHoiDeThi(this.Dethi);
        }


        public FormThiSinh()
        {
            InitializeComponent();
        }

        void loadThoiGianThi()
        {
            timer1.Tick += TimerCountdown_Tick;
        }
        private int countdownMinutes = 0;
        private bool isCounting = false;
        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            // Giảm giá trị đếm ngược mỗi giây
            countdownMinutes--;

            // Cập nhật hiển thị
            UpdateCountdownLabel();

            // Kiểm tra nếu đếm ngược đã kết thúc
            if (countdownMinutes <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Đếm ngược đã kết thúc!");
            }
        }
        private void UpdateCountdownLabel()
        {
            // Hiển thị đếm ngược dưới dạng mm:ss
            lblTime.Text = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(countdownMinutes));
        }
        private void StartCountdown()
        {
            // Bắt đầu đếm ngược
            if (!isCounting)
            {
                timer1.Start();
                isCounting = true;
            }
        }
        void setRadio()
        {
        }
        private void HienThiCauHoiHienTai()
        {
        }
        void loadData()
        {
            MonHoc mh = MH_cn.load_monhoc_id(this.Mamonhoc);
            ThiSinh ts = TS_cn.load_thisinh_id(this.Mathisinh);
            lblTenTS.Text = ts.TENTHISINH;
            lblMaTS.Text = ts.MATS;
            txtMonThi.Text = mh.TENMONHOC;
            lblMaDeThi.Text = this.Dethi;
            countdownMinutes = mh.TGTHI;
            timer1.Tick += TimerCountdown_Tick;
            timer1.Interval = 60000;
            UpdateCountdownLabel();
            StartCountdown();
        }


        private int soCauDung()
        {
            DataTable dt = new DataTable();
            int dung = 0;
            string dapan;
            for (int i = 0; i < lstDapAn.Count; i++)
            {
                dt = CH_cn.load_DapAn_CauHoi(lstDapAn[i].CauHoi);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        dapan = row["DAPAN"].ToString();
                        if (lstDapAn[i].DapAnDaChon == dapan)
                            dung++;
                    }
                }
            }
            return dung;
        }

        private int SoCauSai()
        {
            DataTable dt = new DataTable();
            int sai = 0;
            string dapan;
            for (int i = 0; i < lstDapAn.Count; i++)
            {
                dt = CH_cn.load_DapAn_CauHoi(lstDapAn[i].CauHoi);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dapan = row["DAPAN"].ToString();
                        if (lstDapAn[i].DapAnDaChon != dapan)
                            sai++;
                    }
                }
            }
            return sai;
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            DSNopBai dsnb = new DSNopBai();
            MonHoc mh = MH_cn.load_monhoc_id(this.Mamonhoc);

            dsnb.TENMONHOC = mh.TENMONHOC;
            dsnb.SOCAUDUNG = soCauDung();
            dsnb.SOCAUSAI = SoCauSai();
            dsnb.MADETHI = this.Dethi;
            dsnb.MATHISINH = this.Mathisinh;
            DSNopBai_CN DSNB_CN = new DSNopBai_CN();
            DSNB_CN.Insert_Dsnopbai(dsnb);

            DangNhap dn = new DangNhap();
            this.Hide();
            this.Close();
            dn.ShowDialog();
            Application.Exit();
        }

        private void FormThiSinh_Load(object sender, EventArgs e)
        {
            loadDSCauHoi();
            loadData();
            SetDapAn();
            dgvDSCauHoi.ReadOnly = true;
            loadCauHoi();
            lbSoCau.Text = "Câu " + (currentIndex + 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int currentIndex = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= dgvDSCauHoi.Rows.Count - 1)
            {
                currentIndex = 0;
            }
            dgvDSCauHoi.CurrentCell = dgvDSCauHoi.Rows[currentIndex].Cells[0];

            dgvDSCauHoi.FirstDisplayedScrollingRowIndex = currentIndex;

            loadCauHoi();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentIndex--;
             if (currentIndex < 0)
            {
                currentIndex = dgvDSCauHoi.Rows.Count - 2;
            }
            dgvDSCauHoi.CurrentCell = dgvDSCauHoi.Rows[currentIndex].Cells[0];

            dgvDSCauHoi.FirstDisplayedScrollingRowIndex = currentIndex;

            loadCauHoi();
        }

        DapAn temp = new DapAn();
        void setTS()
        {
            temp.MATS = this.Mathisinh;
            temp.MaDe = this.Dethi ;
        }


        private void dgvDSCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            if(currentIndex >= 0)
            {
                loadCauHoi();
            }
        }

        void loadCauHoi()
        {
            if (lstDapAn[currentIndex].MATS == null || lstDapAn[currentIndex].MaDe == null)
            {
                lstDapAn[currentIndex].MATS = this.Mathisinh;
                lstDapAn[currentIndex].MaDe = this.Dethi;
            }
            

            lbSoCau.Text = "Câu " + (currentIndex + 1);
            DataGridViewRow row = dgvDSCauHoi.Rows[currentIndex];
            txtCauHoi.Text = row.Cells["NOIDUNG"].Value.ToString();
            if (lstDapAn[currentIndex].CauHoi == null)
            {
                lstDapAn[currentIndex].CauHoi = txtCauHoi.Text;
            }
            txtDapAn1.Text = row.Cells["DA1"].Value.ToString();
            txtDapAn2.Text = row.Cells["DA2"].Value.ToString();
            txtDapAn3.Text = row.Cells["DA3"].Value.ToString();
            txtDapAn4.Text = row.Cells["DA4"].Value.ToString();
            if(lstDapAn[currentIndex].DapAnDaChon == "A")
            {
                rdoA.Checked = true;
            }
            else if(lstDapAn[currentIndex].DapAnDaChon == "B")
            {
                rdoB.Checked = true;
            }
            else if(lstDapAn[currentIndex].DapAnDaChon == "C")
            {
                rdoC.Checked = true;
            }
            else if(lstDapAn[currentIndex].DapAnDaChon == "D")
            {
                rdoD.Checked = true;
            }
            else
            {
                rdoA.Checked = rdoB.Checked = rdoC.Checked = rdoD.Checked = false;
            }
            
        }

        List<DapAn> lstDapAn = new List<DapAn>();

        void SetDapAn()
        {
            for(int i=0; i<dgvDSCauHoi.Rows.Count; i++)
            {
                DapAn da = new DapAn();
                lstDapAn.Add(da);
            }
        }
        private void rdoA_CheckedChanged(object sender, EventArgs e)
        {
            lstDapAn[currentIndex].DapAnDaChon = rdoA.Text;
        }

        private void rdoB_CheckedChanged(object sender, EventArgs e)
        {
            lstDapAn[currentIndex].DapAnDaChon = rdoB.Text;

        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            lstDapAn[currentIndex].DapAnDaChon = rdoC.Text;

        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            lstDapAn[currentIndex].DapAnDaChon = rdoD.Text;
        }
    }
}
