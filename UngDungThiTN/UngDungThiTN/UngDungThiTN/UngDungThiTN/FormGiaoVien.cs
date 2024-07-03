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

namespace UngDungThiTN
{
    public partial class FormGiaoVien : Form
    {
        TaiKhoan_CN TK_cn = new TaiKhoan_CN();
        GiaoVien_CN GV_cn = new GiaoVien_CN();
        bool slidebarExpand;
        FormHome home;
        FormCauHoi cauHoi;
        FormMonHoc monHoc;
        FormDSChamDiem DSChamdiem;
        FormChamDiem chamDiem;
        public FormGiaoVien()
        {
            InitializeComponent();
        }
        private string _magiaovien;

        public string Magiaovien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        private void slidebarTimer_Tick(object sender, EventArgs e)
        {

            if(slidebarExpand)
            {
                slidebar.Width -= 10;
                if(slidebar.Width==slidebar.MinimumSize.Width)
                {
                    slidebarExpand= false;
                    slidebarTimer.Stop();
                }
            }
            else
            {
                slidebar.Width += 10;
                if(slidebar.Width==slidebar.MaximumSize.Width)
                {
                    slidebarExpand = true;
                    slidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(home==null)
            {
                home=new FormHome();
                GiaoVien gv = new GiaoVien();
                gv.MAGV = this.Magiaovien;
                home.Magiaovien = GV_cn.get_MaGV_ID(gv);
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            if(cauHoi==null)
            {
                cauHoi=new FormCauHoi();
                GiaoVien gv = new GiaoVien();
                gv.MAGV = this.Magiaovien;
                cauHoi.Magiaovien = GV_cn.get_MaGV_ID(gv);
                cauHoi.FormClosed += CauHoi_FormClosed;
                cauHoi.MdiParent=this;
                cauHoi.Dock= DockStyle.Fill;
                cauHoi.Show();
            }
            else
            {
                cauHoi.Activate();
            }
        }

        private void CauHoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            cauHoi = null;
        }


        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if(monHoc==null)
            {
                monHoc=new FormMonHoc();
                monHoc.FormClosed += MonHoc_FormClosed;
                monHoc.MdiParent = this;
                monHoc.Dock= DockStyle.Fill;
                monHoc.Show();
            }
            else
            {
                monHoc.Activate();
            }
        }

        private void MonHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            monHoc= null;
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if(DSChamdiem==null)
            {
                DSChamdiem = new FormDSChamDiem();
                DSChamdiem.MaGiaoVien = this.Magiaovien;
                DSChamdiem.FormClosed += Chamdiem_FormClosed;
                DSChamdiem.MdiParent= this;
                DSChamdiem.Dock= DockStyle.Fill;
                DSChamdiem.Show();
            }
            else
            {
                DSChamdiem.Activate();
            }
        }

        private void Chamdiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            DSChamdiem = null;
        }

        private void ChamDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            chamDiem=null;
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            string ma = this.Magiaovien;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            this.Close();
            dn.ShowDialog();
            Application.Exit();
        }

        private void FormGiaoVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Đảm bảo đóng tất cả các form con
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
