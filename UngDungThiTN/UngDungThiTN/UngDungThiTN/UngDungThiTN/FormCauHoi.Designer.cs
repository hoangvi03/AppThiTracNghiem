namespace UngDungThiTN
{
    partial class FormCauHoi
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.rdoDSCH = new Guna.UI2.WinForms.Guna2Button();
            this.rdoCauhoi = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox4.BorderRadius = 15;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(99, 384);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(403, 57);
            this.guna2TextBox4.TabIndex = 24;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContainer.Controls.Add(this.rdoDSCH);
            this.panelContainer.Controls.Add(this.rdoCauhoi);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(696, 52);
            this.panelContainer.TabIndex = 28;
            // 
            // rdoDSCH
            // 
            this.rdoDSCH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdoDSCH.CheckedState.CustomBorderColor = System.Drawing.Color.Brown;
            this.rdoDSCH.CustomBorderColor = System.Drawing.Color.White;
            this.rdoDSCH.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rdoDSCH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdoDSCH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rdoDSCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rdoDSCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rdoDSCH.FillColor = System.Drawing.Color.White;
            this.rdoDSCH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDSCH.ForeColor = System.Drawing.Color.Black;
            this.rdoDSCH.HoverState.CustomBorderColor = System.Drawing.Color.Brown;
            this.rdoDSCH.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdoDSCH.Location = new System.Drawing.Point(342, 0);
            this.rdoDSCH.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDSCH.Name = "rdoDSCH";
            this.rdoDSCH.Size = new System.Drawing.Size(355, 52);
            this.rdoDSCH.TabIndex = 0;
            this.rdoDSCH.Text = "Danh sách câu hỏi";
            this.rdoDSCH.Click += new System.EventHandler(this.rdoDSCH_Click);
            // 
            // rdoCauhoi
            // 
            this.rdoCauhoi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.rdoCauhoi.CheckedState.CustomBorderColor = System.Drawing.Color.Brown;
            this.rdoCauhoi.CustomBorderColor = System.Drawing.Color.White;
            this.rdoCauhoi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rdoCauhoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdoCauhoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rdoCauhoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rdoCauhoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rdoCauhoi.FillColor = System.Drawing.Color.White;
            this.rdoCauhoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCauhoi.ForeColor = System.Drawing.Color.Black;
            this.rdoCauhoi.HoverState.CustomBorderColor = System.Drawing.Color.Brown;
            this.rdoCauhoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdoCauhoi.Location = new System.Drawing.Point(0, 0);
            this.rdoCauhoi.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCauhoi.Name = "rdoCauhoi";
            this.rdoCauhoi.Size = new System.Drawing.Size(349, 52);
            this.rdoCauhoi.TabIndex = 0;
            this.rdoCauhoi.Text = "Câu hỏi";
            this.rdoCauhoi.Click += new System.EventHandler(this.rdoCauhoi_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 52);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(696, 412);
            this.panelMain.TabIndex = 29;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // FormCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 464);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.guna2TextBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCauHoi";
            this.Text = "FormCauHoi";
            this.Load += new System.EventHandler(this.FormCauHoi_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button rdoCauhoi;
        private Guna.UI2.WinForms.Guna2Button rdoDSCH;
    }
}