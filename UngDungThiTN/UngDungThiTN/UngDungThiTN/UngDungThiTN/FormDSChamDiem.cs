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
using UngDungThiTN.ChucNang;

namespace UngDungThiTN
{
    public partial class FormDSChamDiem : Form
    {
        DeThi_CN DT_CN = new DeThi_CN();
        MonHoc_CN MH_CN = new MonHoc_CN();
        DSNopBai_CN DSNB_CN = new DSNopBai_CN();


        private string _magiaovien;
        public string MaGiaoVien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }

        public FormDSChamDiem()
        {
            InitializeComponent();
        }

        void loadComBoBox()
        {
            CboMaDe.DataSource = DT_CN.load_DeThi();
            CboMaDe.DisplayMember = "MADT";
            CboMaDe.ValueMember = "MADT";
            CboMonHoc.DataSource = MH_CN.load_monhoc();
            CboMonHoc.DisplayMember = "TENMONHOC";
            CboMonHoc.ValueMember = "MAMONHOC";
        }
        void loadDataGridView()
        {
            dgvDSNB.DataSource = DSNB_CN.loadDSNopBai();
        }
        private void FormDSChamDiem_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadComBoBox();
            loadDataGridView();
            dgvDSNB.ReadOnly = true;
        }
        FormChamDiem chamDiem;
        private string ts;
        private void btnChamDiem_Click(object sender, EventArgs e)
        {
            if (chamDiem == null)
            {
                if(ts == null)
                {
                    MessageBox.Show("Chưa chọn thí sinh muốn chấm điểm!");
                }
                else
                {
                    chamDiem = new FormChamDiem();
                    chamDiem.FormClosed += ChamDiem_FormClosed;
                    chamDiem.MaGiaoVien = this.MaGiaoVien;
                    chamDiem.MaDeThi = CboMaDe.SelectedValue.ToString();
                    chamDiem.MaThiSinh = ts;
                    chamDiem.MaMonHoc = CboMonHoc.SelectedValue.ToString();
                    chamDiem.MdiParent = this.MdiParent;
                    chamDiem.Dock = DockStyle.Fill;
                    chamDiem.Show();
                }
            }
            else
            {
                chamDiem.Activate();
            }
        }

        private void ChamDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            chamDiem = null;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDSNB.DataSource = DSNB_CN.loadDSNopBai_DeThi_MH(CboMaDe.SelectedValue.ToString());
        }

        private void CboMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboMonHoc.SelectedValue = DT_CN.get_MAMH(CboMaDe.SelectedValue.ToString());
        }

        private void dgvDSNB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSNB.Rows[e.RowIndex];
                ts = row.Cells["MATHISINH"].Value.ToString();
            }
        }
    }
}
