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
using UngDungThiTN.UC;
using UngDungThiTN.UC_CauHoi;

namespace UngDungThiTN
{
    public partial class FormCauHoi : Form
    {
        GiaoVien_CN GV_CN = new GiaoVien_CN();
        private string _magiaovien;

        public string Magiaovien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        public FormCauHoi()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void rdoCauhoi_Click(object sender, EventArgs e)
        {
            UC_QLyCauHoi qLyCauHoi = new UC_QLyCauHoi();
            GiaoVien gv = new GiaoVien();
            gv.MAGV = this.Magiaovien;
            qLyCauHoi.Magiaovien = GV_CN.get_MaGV_ID(gv);
            qLyCauHoi.Dock = DockStyle.Fill;
            addUserControl(qLyCauHoi);
        }

        private void rdoDSCH_Click(object sender, EventArgs e)
        {
            UC_DSCH dsch = new UC_DSCH();

            // Đăng ký sự kiện EditButtonClicked của UC_DSCH
            dsch.EditButtonClicked += UC_DSCH_EditButtonClicked;

            addUserControl(dsch);
        }

        private void uC_CauHoi1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
        }

        private void FormCauHoi_Load(object sender, EventArgs e)
        {

        }


        private void UC_DSCH_EditButtonClicked(object sender, UC_DSCH.EditButtonEventArgs e)
        {
            // Khi sự kiện EditButtonClicked xảy ra, hiển thị UC_QLyCauHoi
            UC_QLyCauHoi qLyCauHoi = new UC_QLyCauHoi();
            GiaoVien gv = new GiaoVien();
            gv.MAGV = this.Magiaovien;
            qLyCauHoi.NDCauHoi = e.NDCauHoi;
            qLyCauHoi.Magiaovien = GV_CN.get_MaGV_ID(gv);
            qLyCauHoi.Dock = DockStyle.Fill;
            addUserControl(qLyCauHoi);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
