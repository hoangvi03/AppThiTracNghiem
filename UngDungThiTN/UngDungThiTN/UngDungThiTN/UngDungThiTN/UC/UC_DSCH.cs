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
using UngDungThiTN.UC;

namespace UngDungThiTN.UC_CauHoi
{
    public partial class UC_DSCH : UserControl
    {
        CauHoi_CN CH_cn = new CauHoi_CN();
        DeThi_CN DT_CN = new DeThi_CN();
        private string _magiaovien;

        public string Magiaovien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        public UC_DSCH()
        {
            InitializeComponent();
        }

        void LoadCombobox()
        {
            CboMonHoc.DataSource = CH_cn.load_MonHoc();
            CboMonHoc.DisplayMember = "TENMONHOC";
            CboMonHoc.ValueMember = "MAMONHOC";
        }
        void LoadDataGridView()
        {
            dgvDSCH.DataSource = null;
            dgvDSCH.DataSource = CH_cn.load_cauhoi(txtMaDT.Text);
        }
        private void UC_DSCH_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            dgvDSCH.ReadOnly = true;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }



        public class EditButtonEventArgs : EventArgs
        {
            public string NDCauHoi { get; set; }
        }

        public event EventHandler<EditButtonEventArgs> EditButtonClicked;
        private void btnSuaCH_Click(object sender, EventArgs e)
        {
            EditButtonEventArgs args = new EditButtonEventArgs
            {
                NDCauHoi = nd
            };

            EditButtonClicked?.Invoke(this, args);
        }
        private string nd;
        private void dgvDSCH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSCH.Rows[e.RowIndex];
                nd = row.Cells["NOIDUNG"].Value.ToString();
            }
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = DT_CN.get_MAMH(txtMaDT.Text);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                CboMonHoc.SelectedValue = row["MAMH"].ToString().Replace(" ", "");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(nd == "")
            {
                MessageBox.Show("Chưa chọn câu hỏi muốn xóa");
            }
            else
            {
                try
                {
                    CauHoi ch = new CauHoi();
                    ch.NOIDUNG = nd;
                    CH_cn.delete_cauhoi(ch);
                    LoadDataGridView();
                }
                catch
                {
                    MessageBox.Show("Không xóa được do vi phạm ràng buộc!");
                }
            }    

        }
    }
}
