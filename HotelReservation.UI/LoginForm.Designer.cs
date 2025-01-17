namespace HotelReservation.UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(104, 204);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Kullanıcı Adı :";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(132, 294);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifre :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(269, 208);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(163, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(269, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(163, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SpringGreen;
            btnLogin.Cursor = Cursors.AppStarting;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLogin.Location = new Point(244, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(591, 519);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "Kullanıcı Girişi";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
