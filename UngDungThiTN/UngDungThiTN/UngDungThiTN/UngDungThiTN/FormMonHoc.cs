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
    public partial class FormMonHoc : Form
    {
        MonHoc_CN cn = new MonHoc_CN();
        public FormMonHoc()
        {
            InitializeComponent();
        }

        void LoadDataGridView()
        {
            bindingSource1.DataSource = cn.load_monhoc();
            dgvDSMH.DataSource = bindingSource1;

            dgvDSMH.ReadOnly = true;
            dgvDSMH.Columns[0].HeaderText = "Mã môn học";
            dgvDSMH.Columns[1].HeaderText = "Tên môn học";
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadDataGridView();
        }

        private void dgvDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
            {
                lbtrangthai.Text = "Chưa nhập mã môn học!";
                delay();

            }
            else if (txtTenMH.TextLength == 0)
            {
                lbtrangthai.Text = "Chưa nhập tên môn học!";
                delay();
            }
            else if (txtTGThi.TextLength == 0)
            {
                lbtrangthai.Text = "Chưa nhập thời gian thi!";
                delay();
            }
            else
            {
                try
                {
                    MonHoc monhoc = new MonHoc();
                    monhoc.MAMONHOC = txtMaMH.Text;
                    monhoc.MAMONHOCOLD = mamonhoc_old;
                    monhoc.TENMONHOC = txtTenMH.Text;
                    monhoc.TGTHI = int.Parse(txtTGThi.Text);
                    cn.insert_monhoc(monhoc);
                    LoadDataGridView();
                    lbtrangthai.Text = "Thêm môn học thành công.";
                    delay();
                    txtMaMH.Clear();
                    txtTenMH.Clear();
                    txtTGThi.Clear();

                }
                catch
                {
                    lbtrangthai.ForeColor = Color.Red;
                    lbtrangthai.Text = "Mã môn học bị trùng.";
                    delay();
                }
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Điền mã môn vào ô để xóa.";
                delay();
            }
            else if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa môn học này?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MonHoc monhoc = new MonHoc();
                monhoc.MAMONHOC = txtMaMH.Text;
                cn.delete_monhoc(monhoc);
                lbtrangthai.ForeColor = Color.Green;
                lbtrangthai.Text = "Xóa thành công.";
                LoadDataGridView();
                txtMaMH.Text = txtTenMH.Text = txtTGThi.Text = "";
                delay();
            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
            {
                lbtrangthai.Text = "Chưa nhập mã môn học!";
                delay();

            }
            else if (txtTenMH.TextLength == 0)
            {
                lbtrangthai.Text = "Chưa nhập tên môn học!";
                delay();
            }
            else if (txtTGThi.TextLength == 0)
            {
                lbtrangthai.Text = "Chưa nhập thời gian thi!";
                delay();
            }
            else
            {
                try
                {
                    MonHoc monhoc = new MonHoc();
                    monhoc.MAMONHOC = txtMaMH.Text;
                    monhoc.MAMONHOCOLD = mamonhoc_old;
                    monhoc.TENMONHOC = txtTenMH.Text;
                    monhoc.TGTHI = int.Parse(txtTGThi.Text);
                    cn.update_monhoc(monhoc);
                    LoadDataGridView();
                    lbtrangthai.ForeColor = Color.Green;
                    lbtrangthai.Text = "Sửa môn học thành công.";
                    delay();
                    txtMaMH.Clear();
                    txtTenMH.Clear();
                    txtTGThi.Clear();

                }
                catch
                {
                    lbtrangthai.ForeColor = Color.Red;
                    lbtrangthai.Text = "Mã môn học không tồn tại.";
                    delay();
                }
            }
        }
        private string mamonhoc_old = "";
        private void dgvDSMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaMH.Text = dgvDSMH.Rows[dong].Cells[0].Value.ToString();
                mamonhoc_old = dgvDSMH.Rows[dong].Cells[0].Value.ToString();
                txtTenMH.Text = dgvDSMH.Rows[dong].Cells[1].Value.ToString();
                txtTGThi.Text = dgvDSMH.Rows[dong].Cells[2].Value.ToString();
            }
            catch
            { }
        }
    }
}
