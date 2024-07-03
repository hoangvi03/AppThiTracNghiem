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

namespace UngDungThiTN
{
    public partial class MonThi : Form
    {
        FormThiSinh ts;
        MonThi mt;
        MonHoc_CN MH_cn = new MonHoc_CN();
        ThiSinh_CN TS_cn = new ThiSinh_CN();

        private string _mathisinh;

        public string Mathisinh
        {
            get { return _mathisinh; }
            set { _mathisinh = value; }
        }

        public MonThi()
        {
            InitializeComponent();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            ts = new FormThiSinh();
            ts.Mathisinh = this.Mathisinh;
            ts.Mamonhoc = cboTenMon.SelectedValue.ToString();
            ts.Dethi = cboMaDeThi.SelectedValue.ToString();
            this.Hide();
            ts.ShowDialog();
            Application.Exit();
        }

        void LoadComBoBox()
        {
            cboTenMon.DataSource = MH_cn.load_monhoc();
            cboTenMon.ValueMember = "MAMONHOC";
            cboTenMon.DisplayMember = "TENMONHOC";


            cboMaDeThi.DataSource = MH_cn.load_dethi();
            cboMaDeThi.DisplayMember = "MADT";
            cboMaDeThi.ValueMember = "MADT";
        }

        private void MonThi_Load(object sender, EventArgs e)
        {
            LoadComBoBox();
        }
    }
}
