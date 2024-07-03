namespace UngDungThiTN
{
    partial class FormMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.grThongTinMonHoc = new System.Windows.Forms.GroupBox();
            this.txtTGThi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.txtMaMH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.grDSMH = new System.Windows.Forms.GroupBox();
            this.dgvDSMH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThemMH = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaMH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaMH = new Guna.UI2.WinForms.Guna2Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.grThongTinMonHoc.SuspendLayout();
            this.grDSMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // grThongTinMonHoc
            // 
            this.grThongTinMonHoc.Controls.Add(this.txtTGThi);
            this.grThongTinMonHoc.Controls.Add(this.label1);
            this.grThongTinMonHoc.Controls.Add(this.txtTenMH);
            this.grThongTinMonHoc.Controls.Add(this.lblTenMH);
            this.grThongTinMonHoc.Controls.Add(this.txtMaMH);
            this.grThongTinMonHoc.Controls.Add(this.lblMaMH);
            this.grThongTinMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinMonHoc.Location = new System.Drawing.Point(10, 18);
            this.grThongTinMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.grThongTinMonHoc.Name = "grThongTinMonHoc";
            this.grThongTinMonHoc.Padding = new System.Windows.Forms.Padding(2);
            this.grThongTinMonHoc.Size = new System.Drawing.Size(442, 182);
            this.grThongTinMonHoc.TabIndex = 0;
            this.grThongTinMonHoc.TabStop = false;
            this.grThongTinMonHoc.Text = "Thông tin môn học";
            // 
            // txtTGThi
            // 
            this.txtTGThi.BorderColor = System.Drawing.Color.White;
            this.txtTGThi.BorderRadius = 10;
            this.txtTGThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTGThi.DefaultText = "";
            this.txtTGThi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTGThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTGThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTGThi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTGThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTGThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTGThi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTGThi.Location = new System.Drawing.Point(125, 127);
            this.txtTGThi.Name = "txtTGThi";
            this.txtTGThi.PasswordChar = '\0';
            this.txtTGThi.PlaceholderText = "";
            this.txtTGThi.SelectedText = "";
            this.txtTGThi.Size = new System.Drawing.Size(88, 34);
            this.txtTGThi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian thi:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.BorderColor = System.Drawing.Color.White;
            this.txtTenMH.BorderRadius = 10;
            this.txtTenMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMH.DefaultText = "";
            this.txtTenMH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenMH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMH.Location = new System.Drawing.Point(125, 77);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.PasswordChar = '\0';
            this.txtTenMH.PlaceholderText = "";
            this.txtTenMH.SelectedText = "";
            this.txtTenMH.Size = new System.Drawing.Size(279, 34);
            this.txtTenMH.TabIndex = 1;
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.Location = new System.Drawing.Point(27, 84);
            this.lblTenMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(95, 19);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Tên môn học :";
            // 
            // txtMaMH
            // 
            this.txtMaMH.BorderColor = System.Drawing.Color.White;
            this.txtMaMH.BorderRadius = 10;
            this.txtMaMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaMH.DefaultText = "";
            this.txtMaMH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaMH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaMH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaMH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaMH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaMH.Location = new System.Drawing.Point(125, 26);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.PasswordChar = '\0';
            this.txtMaMH.PlaceholderText = "";
            this.txtMaMH.SelectedText = "";
            this.txtMaMH.Size = new System.Drawing.Size(216, 34);
            this.txtMaMH.TabIndex = 1;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMH.Location = new System.Drawing.Point(27, 33);
            this.lblMaMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(94, 19);
            this.lblMaMH.TabIndex = 0;
            this.lblMaMH.Text = "Mã môn học :";
            // 
            // grDSMH
            // 
            this.grDSMH.Controls.Add(this.dgvDSMH);
            this.grDSMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSMH.Location = new System.Drawing.Point(7, 236);
            this.grDSMH.Margin = new System.Windows.Forms.Padding(2);
            this.grDSMH.Name = "grDSMH";
            this.grDSMH.Padding = new System.Windows.Forms.Padding(2);
            this.grDSMH.Size = new System.Drawing.Size(673, 234);
            this.grDSMH.TabIndex = 2;
            this.grDSMH.TabStop = false;
            this.grDSMH.Text = "Danh sách môn học";
            // 
            // dgvDSMH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSMH.ColumnHeadersHeight = 4;
            this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSMH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSMH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSMH.Location = new System.Drawing.Point(10, 25);
            this.dgvDSMH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSMH.Name = "dgvDSMH";
            this.dgvDSMH.RowHeadersVisible = false;
            this.dgvDSMH.RowHeadersWidth = 62;
            this.dgvDSMH.RowTemplate.Height = 28;
            this.dgvDSMH.Size = new System.Drawing.Size(653, 201);
            this.dgvDSMH.TabIndex = 1;
            this.dgvDSMH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSMH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSMH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSMH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSMH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSMH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSMH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSMH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSMH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSMH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSMH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSMH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSMH.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDSMH.ThemeStyle.ReadOnly = false;
            this.dgvDSMH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSMH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSMH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSMH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSMH.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSMH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSMH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellContentClick);
            this.dgvDSMH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_RowEnter);
            // 
            // btnThemMH
            // 
            this.btnThemMH.BorderRadius = 7;
            this.btnThemMH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMH.FillColor = System.Drawing.Color.Brown;
            this.btnThemMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.ForeColor = System.Drawing.Color.White;
            this.btnThemMH.Location = new System.Drawing.Point(471, 33);
            this.btnThemMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(199, 45);
            this.btnThemMH.TabIndex = 3;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.BorderRadius = 7;
            this.btnSuaMH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaMH.FillColor = System.Drawing.Color.Brown;
            this.btnSuaMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMH.ForeColor = System.Drawing.Color.White;
            this.btnSuaMH.Location = new System.Drawing.Point(471, 95);
            this.btnSuaMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(199, 45);
            this.btnSuaMH.TabIndex = 3;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.BorderRadius = 7;
            this.btnXoaMH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaMH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaMH.FillColor = System.Drawing.Color.Brown;
            this.btnXoaMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.ForeColor = System.Drawing.Color.White;
            this.btnXoaMH.Location = new System.Drawing.Point(471, 155);
            this.btnXoaMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(199, 45);
            this.btnXoaMH.TabIndex = 3;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrangthai.ForeColor = System.Drawing.Color.Green;
            this.lbtrangthai.Location = new System.Drawing.Point(256, 208);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(0, 30);
            this.lbtrangthai.TabIndex = 2;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 488);
            this.Controls.Add(this.lbtrangthai);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnSuaMH);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.grDSMH);
            this.Controls.Add(this.grThongTinMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMonHoc";
            this.Text = "FormMonHoc";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.grThongTinMonHoc.ResumeLayout(false);
            this.grThongTinMonHoc.PerformLayout();
            this.grDSMH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnXoaMH;
        private Guna.UI2.WinForms.Guna2Button btnSuaMH;
        private Guna.UI2.WinForms.Guna2Button btnThemMH;
        private System.Windows.Forms.GroupBox grDSMH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSMH;
        private System.Windows.Forms.GroupBox grThongTinMonHoc;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMH;
        private System.Windows.Forms.Label lblTenMH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaMH;
        private System.Windows.Forms.Label lblMaMH;
        private Guna.UI2.WinForms.Guna2TextBox txtTGThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbtrangthai;
    }
}