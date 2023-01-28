
namespace Resturant_Application
{
    partial class LoginForm
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
            this.TxtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUserID
            // 
            this.TxtUserID.BorderColor = System.Drawing.Color.Gray;
            this.TxtUserID.BorderRadius = 5;
            this.TxtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserID.DefaultText = "";
            this.TxtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserID.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.TxtUserID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtUserID.HoverState.BorderColor = System.Drawing.Color.Black;
            this.TxtUserID.Location = new System.Drawing.Point(128, 134);
            this.TxtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.PasswordChar = '\0';
            this.TxtUserID.PlaceholderText = "";
            this.TxtUserID.SelectedText = "";
            this.TxtUserID.Size = new System.Drawing.Size(250, 37);
            this.TxtUserID.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.Gray;
            this.TxtPassword.BorderRadius = 5;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(128, 186);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.PlaceholderText = "";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(250, 37);
            this.TxtPassword.TabIndex = 3;
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignUpLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpLink.Location = new System.Drawing.Point(166, 234);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(149, 13);
            this.SignUpLink.TabIndex = 18;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Click Here To Create Account";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(37, 196);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 18);
            this.label25.TabIndex = 17;
            this.label25.Text = "Password:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(53, 141);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 18);
            this.label24.TabIndex = 16;
            this.label24.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Resturant Application";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 50;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Black;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.Animated = true;
            this.guna2CustomCheckBox1.Checked = true;
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(392, 196);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomCheckBox1.TabIndex = 29;
            this.guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomCheckBox1.Click += new System.EventHandler(this.guna2CustomCheckBox1_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.ControlText;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(479, 42);
            this.guna2CustomGradientPanel1.TabIndex = 85;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.CustomClick = true;
            this.guna2ControlBox1.CustomIconSize = 30F;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(425, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(54, 42);
            this.guna2ControlBox1.TabIndex = 82;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(192, 275);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(105, 49);
            this.guna2GradientButton1.TabIndex = 86;
            this.guna2GradientButton1.Text = "LOGIN";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 337);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2CustomCheckBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TxtUserID;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}