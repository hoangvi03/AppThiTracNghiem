namespace UngDungThiTN
{
    partial class FormDSChamDiem
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
            this.grDSTSNopBai = new System.Windows.Forms.GroupBox();
            this.btnTim = new Guna.UI2.WinForms.Guna2Button();
            this.CboMaDe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaDe = new System.Windows.Forms.Label();
            this.dgvDSNB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnChamDiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.grDSTSNopBai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNB)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // grDSTSNopBai
            // 
            this.grDSTSNopBai.Controls.Add(this.btnTim);
            this.grDSTSNopBai.Controls.Add(this.CboMaDe);
            this.grDSTSNopBai.Controls.Add(this.CboMonHoc);
            this.grDSTSNopBai.Controls.Add(this.label1);
            this.grDSTSNopBai.Controls.Add(this.lblMaDe);
            this.grDSTSNopBai.Controls.Add(this.dgvDSNB);
            this.grDSTSNopBai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSTSNopBai.Location = new System.Drawing.Point(15, 17);
            this.grDSTSNopBai.Margin = new System.Windows.Forms.Padding(2);
            this.grDSTSNopBai.Name = "grDSTSNopBai";
            this.grDSTSNopBai.Padding = new System.Windows.Forms.Padding(2);
            this.grDSTSNopBai.Size = new System.Drawing.Size(657, 350);
            this.grDSTSNopBai.TabIndex = 0;
            this.grDSTSNopBai.TabStop = false;
            this.grDSTSNopBai.Text = "Danh sách thí sinh đã nộp bài";
            // 
            // btnTim
            // 
            this.btnTim.BorderRadius = 17;
            this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTim.FillColor = System.Drawing.Color.Firebrick;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(552, 34);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(77, 37);
            this.btnTim.TabIndex = 74;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // CboMaDe
            // 
            this.CboMaDe.BackColor = System.Drawing.Color.Transparent;
            this.CboMaDe.BorderColor = System.Drawing.Color.White;
            this.CboMaDe.BorderRadius = 10;
            this.CboMaDe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboMaDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMaDe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CboMaDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CboMaDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CboMaDe.ItemHeight = 30;
            this.CboMaDe.Location = new System.Drawing.Point(130, 34);
            this.CboMaDe.Margin = new System.Windows.Forms.Padding(2);
            this.CboMaDe.Name = "CboMaDe";
            this.CboMaDe.Size = new System.Drawing.Size(117, 36);
            this.CboMaDe.TabIndex = 73;
            this.CboMaDe.SelectedIndexChanged += new System.EventHandler(this.CboMaDe_SelectedIndexChanged);
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
            this.CboMonHoc.Location = new System.Drawing.Point(338, 34);
            this.CboMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.CboMonHoc.Name = "CboMonHoc";
            this.CboMonHoc.Size = new System.Drawing.Size(199, 36);
            this.CboMonHoc.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Môn học";
            // 
            // lblMaDe
            // 
            this.lblMaDe.AutoSize = true;
            this.lblMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDe.Location = new System.Drawing.Point(36, 42);
            this.lblMaDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDe.Name = "lblMaDe";
            this.lblMaDe.Size = new System.Drawing.Size(74, 20);
            this.lblMaDe.TabIndex = 71;
            this.lblMaDe.Text = "Mã đề thi";
            // 
            // dgvDSNB
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSNB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNB.ColumnHeadersHeight = 4;
            this.dgvDSNB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSNB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNB.Location = new System.Drawing.Point(12, 87);
            this.dgvDSNB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSNB.Name = "dgvDSNB";
            this.dgvDSNB.RowHeadersVisible = false;
            this.dgvDSNB.RowHeadersWidth = 62;
            this.dgvDSNB.RowTemplate.Height = 28;
            this.dgvDSNB.Size = new System.Drawing.Size(632, 251);
            this.dgvDSNB.TabIndex = 0;
            this.dgvDSNB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSNB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSNB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSNB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSNB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSNB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSNB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSNB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSNB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSNB.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDSNB.ThemeStyle.ReadOnly = false;
            this.dgvDSNB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSNB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSNB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSNB.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDSNB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSNB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSNB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNB_CellContentClick);
            // 
            // btnChamDiem
            // 
            this.btnChamDiem.BorderRadius = 10;
            this.btnChamDiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChamDiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChamDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChamDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChamDiem.FillColor = System.Drawing.Color.Brown;
            this.btnChamDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamDiem.ForeColor = System.Drawing.Color.White;
            this.btnChamDiem.Location = new System.Drawing.Point(264, 380);
            this.btnChamDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnChamDiem.Name = "btnChamDiem";
            this.btnChamDiem.Size = new System.Drawing.Size(143, 41);
            this.btnChamDiem.TabIndex = 1;
            this.btnChamDiem.Text = "Chấm điểm";
            this.btnChamDiem.Click += new System.EventHandler(this.btnChamDiem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BorderRadius = 10;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.FillColor = System.Drawing.Color.Brown;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(529, 380);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(143, 41);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Reset";
            this.btnLoad.Click += new System.EventHandler(this.btnChamDiem_Click);
            // 
            // FormDSChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 441);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnChamDiem);
            this.Controls.Add(this.grDSTSNopBai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDSChamDiem";
            this.Text = "FormDSChamDiem";
            this.Load += new System.EventHandler(this.FormDSChamDiem_Load);
            this.grDSTSNopBai.ResumeLayout(false);
            this.grDSTSNopBai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.GroupBox grDSTSNopBai;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSNB;
        private Guna.UI2.WinForms.Guna2Button btnChamDiem;
        private Guna.UI2.WinForms.Guna2ComboBox CboMaDe;
        private Guna.UI2.WinForms.Guna2ComboBox CboMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaDe;
        private Guna.UI2.WinForms.Guna2Button btnTim;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
    }
}