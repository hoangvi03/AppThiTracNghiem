namespace UngDungThiTN
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.grThongTinGV = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.txtHoTenGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.grThongTinGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(199, 8);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 130);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // grThongTinGV
            // 
            this.grThongTinGV.Controls.Add(this.lblNgaySinh);
            this.grThongTinGV.Controls.Add(this.dtpNgaySinh);
            this.grThongTinGV.Controls.Add(this.txtGioiTinh);
            this.grThongTinGV.Controls.Add(this.lblGioiTinh);
            this.grThongTinGV.Controls.Add(this.txtMaGV);
            this.grThongTinGV.Controls.Add(this.lblMaGV);
            this.grThongTinGV.Controls.Add(this.txtHoTenGV);
            this.grThongTinGV.Controls.Add(this.lblHoTenGV);
            this.grThongTinGV.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinGV.Location = new System.Drawing.Point(35, 142);
            this.grThongTinGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grThongTinGV.Name = "grThongTinGV";
            this.grThongTinGV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grThongTinGV.Size = new System.Drawing.Size(598, 236);
            this.grThongTinGV.TabIndex = 1;
            this.grThongTinGV.TabStop = false;
            this.grThongTinGV.Text = "Thông tin giáo viên";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AcceptsReturn = true;
            this.txtGioiTinh.BorderColor = System.Drawing.Color.White;
            this.txtGioiTinh.BorderRadius = 10;
            this.txtGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioiTinh.DefaultText = "";
            this.txtGioiTinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGioiTinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGioiTinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.Location = new System.Drawing.Point(130, 176);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.PasswordChar = '\0';
            this.txtGioiTinh.PlaceholderText = "";
            this.txtGioiTinh.SelectedText = "";
            this.txtGioiTinh.Size = new System.Drawing.Size(160, 39);
            this.txtGioiTinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(41, 184);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính : ";
            // 
            // txtMaGV
            // 
            this.txtMaGV.AcceptsReturn = true;
            this.txtMaGV.BorderColor = System.Drawing.Color.White;
            this.txtMaGV.BorderRadius = 10;
            this.txtMaGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaGV.DefaultText = "";
            this.txtMaGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGV.Location = new System.Drawing.Point(130, 37);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.PasswordChar = '\0';
            this.txtMaGV.PlaceholderText = "";
            this.txtMaGV.SelectedText = "";
            this.txtMaGV.Size = new System.Drawing.Size(445, 39);
            this.txtMaGV.TabIndex = 3;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.Location = new System.Drawing.Point(59, 50);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(56, 20);
            this.lblMaGV.TabIndex = 2;
            this.lblMaGV.Text = "Mã số :";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.AcceptsReturn = true;
            this.txtHoTenGV.BorderColor = System.Drawing.Color.White;
            this.txtHoTenGV.BorderRadius = 10;
            this.txtHoTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenGV.DefaultText = "";
            this.txtHoTenGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTenGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTenGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenGV.Location = new System.Drawing.Point(130, 83);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.PasswordChar = '\0';
            this.txtHoTenGV.PlaceholderText = "";
            this.txtHoTenGV.SelectedText = "";
            this.txtHoTenGV.Size = new System.Drawing.Size(445, 39);
            this.txtHoTenGV.TabIndex = 1;
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTenGV.Location = new System.Drawing.Point(35, 92);
            this.lblHoTenGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(80, 20);
            this.lblHoTenGV.TabIndex = 0;
            this.lblHoTenGV.Text = "Họ và tên :";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.Brown;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(485, 394);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(148, 47);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BorderRadius = 10;
            this.btnDoiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMK.FillColor = System.Drawing.Color.Brown;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Location = new System.Drawing.Point(35, 394);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(148, 47);
            this.btnDoiMK.TabIndex = 2;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(34, 137);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lblNgaySinh.TabIndex = 22;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 10;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.Brown;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(130, 131);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(300, 36);
            this.dtpNgaySinh.TabIndex = 21;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 12, 11, 19, 20, 44, 807);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 482);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.grThongTinGV);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.grThongTinGV.ResumeLayout(false);
            this.grThongTinGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.GroupBox grThongTinGV;
        private System.Windows.Forms.Label lblHoTenGV;
        private Guna.UI2.WinForms.Guna2TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtMaGV;
        private System.Windows.Forms.Label lblMaGV;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTenGV;
        private Guna.UI2.WinForms.Guna2Button btnDoiMK;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private System.Windows.Forms.Label lblNgaySinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
    }
}