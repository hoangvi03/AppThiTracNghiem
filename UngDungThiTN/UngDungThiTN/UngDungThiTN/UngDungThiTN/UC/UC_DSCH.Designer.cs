namespace UngDungThiTN.UC_CauHoi
{
    partial class UC_DSCH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaCH = new Guna.UI2.WinForms.Guna2Button();
            this.grDSCH = new System.Windows.Forms.GroupBox();
            this.dgvDSCH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaDe = new System.Windows.Forms.Label();
            this.btnHienThi = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.grDSCH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.Brown;
            this.btnXoa.BorderRadius = 7;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(540, 337);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Size = new System.Drawing.Size(103, 37);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaCH
            // 
            this.btnSuaCH.BorderColor = System.Drawing.Color.Brown;
            this.btnSuaCH.BorderRadius = 7;
            this.btnSuaCH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaCH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaCH.FillColor = System.Drawing.Color.Firebrick;
            this.btnSuaCH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCH.ForeColor = System.Drawing.Color.White;
            this.btnSuaCH.Location = new System.Drawing.Point(540, 284);
            this.btnSuaCH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuaCH.Size = new System.Drawing.Size(103, 37);
            this.btnSuaCH.TabIndex = 34;
            this.btnSuaCH.Text = "Sửa";
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // grDSCH
            // 
            this.grDSCH.Controls.Add(this.dgvDSCH);
            this.grDSCH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSCH.Location = new System.Drawing.Point(15, 9);
            this.grDSCH.Margin = new System.Windows.Forms.Padding(2);
            this.grDSCH.Name = "grDSCH";
            this.grDSCH.Padding = new System.Windows.Forms.Padding(2);
            this.grDSCH.Size = new System.Drawing.Size(473, 398);
            this.grDSCH.TabIndex = 30;
            this.grDSCH.TabStop = false;
            this.grDSCH.Text = "Danh sách các câu hỏi";
            // 
            // dgvDSCH
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDSCH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDSCH.ColumnHeadersHeight = 4;
            this.dgvDSCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSCH.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSCH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSCH.Location = new System.Drawing.Point(4, 23);
            this.dgvDSCH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSCH.Name = "dgvDSCH";
            this.dgvDSCH.RowHeadersVisible = false;
            this.dgvDSCH.RowHeadersWidth = 62;
            this.dgvDSCH.RowTemplate.Height = 28;
            this.dgvDSCH.Size = new System.Drawing.Size(455, 371);
            this.dgvDSCH.TabIndex = 0;
            this.dgvDSCH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSCH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSCH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSCH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSCH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSCH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSCH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSCH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSCH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSCH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSCH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSCH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSCH.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDSCH.ThemeStyle.ReadOnly = false;
            this.dgvDSCH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSCH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSCH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSCH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSCH.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSCH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSCH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSCH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCH_CellContentClick);
            // 
            // CboMonHoc
            // 
            this.CboMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.CboMonHoc.BorderColor = System.Drawing.Color.White;
            this.CboMonHoc.BorderRadius = 10;
            this.CboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CboMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CboMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CboMonHoc.ItemHeight = 30;
            this.CboMonHoc.Location = new System.Drawing.Point(570, 135);
            this.CboMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.CboMonHoc.Name = "CboMonHoc";
            this.CboMonHoc.Size = new System.Drawing.Size(113, 36);
            this.CboMonHoc.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã MH";
            // 
            // lblMaDe
            // 
            this.lblMaDe.AutoSize = true;
            this.lblMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDe.Location = new System.Drawing.Point(494, 64);
            this.lblMaDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDe.Name = "lblMaDe";
            this.lblMaDe.Size = new System.Drawing.Size(74, 20);
            this.lblMaDe.TabIndex = 65;
            this.lblMaDe.Text = "Mã đề thi";
            // 
            // btnHienThi
            // 
            this.btnHienThi.BorderColor = System.Drawing.Color.Brown;
            this.btnHienThi.BorderRadius = 7;
            this.btnHienThi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienThi.FillColor = System.Drawing.Color.Firebrick;
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(540, 232);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnHienThi.Size = new System.Drawing.Size(103, 37);
            this.btnHienThi.TabIndex = 68;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtMaDT
            // 
            this.txtMaDT.BorderColor = System.Drawing.Color.White;
            this.txtMaDT.BorderRadius = 15;
            this.txtMaDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDT.DefaultText = "";
            this.txtMaDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDT.Location = new System.Drawing.Point(568, 53);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.PasswordChar = '\0';
            this.txtMaDT.PlaceholderText = "";
            this.txtMaDT.SelectedText = "";
            this.txtMaDT.Size = new System.Drawing.Size(115, 40);
            this.txtMaDT.TabIndex = 69;
            this.txtMaDT.TextChanged += new System.EventHandler(this.txtMaDT_TextChanged);
            // 
            // UC_DSCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.CboMonHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaDe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaCH);
            this.Controls.Add(this.grDSCH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_DSCH";
            this.Size = new System.Drawing.Size(697, 417);
            this.Load += new System.EventHandler(this.UC_DSCH_Load);
            this.grDSCH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSuaCH;
        private System.Windows.Forms.GroupBox grDSCH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSCH;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2ComboBox CboMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaDe;
        private Guna.UI2.WinForms.Guna2Button btnHienThi;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDT;
    }
}
