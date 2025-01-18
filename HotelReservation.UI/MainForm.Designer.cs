namespace HotelReservation.UI
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            odaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            odaEkleToolStripMenuItem = new ToolStripMenuItem();
            odaDüzenleToolStripMenuItem = new ToolStripMenuItem();
            odaSilToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonEkleToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonSilToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonlToolStripMenuItem = new ToolStripMenuItem();
            dgvReservations = new DataGridView();
            DownloadBillColumn = new DataGridViewButtonColumn();
            BillDetailsColumn = new DataGridViewButtonColumn();
            btnAddReservation = new Button();
            btnCancelReservation = new Button();
            pnlChangePassword = new Panel();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            txtEmail = new TextBox();
            btnSavePassword = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBoxSettings = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            pnlChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { odaİşlemleriToolStripMenuItem, rezervasyonİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1186, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // odaİşlemleriToolStripMenuItem
            // 
            odaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { odaEkleToolStripMenuItem, odaDüzenleToolStripMenuItem, odaSilToolStripMenuItem });
            odaİşlemleriToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            odaİşlemleriToolStripMenuItem.Name = "odaİşlemleriToolStripMenuItem";
            odaİşlemleriToolStripMenuItem.Size = new Size(123, 24);
            odaİşlemleriToolStripMenuItem.Text = "Oda İşlemleri ";
            // 
            // odaEkleToolStripMenuItem
            // 
            odaEkleToolStripMenuItem.Name = "odaEkleToolStripMenuItem";
            odaEkleToolStripMenuItem.Size = new Size(178, 26);
            odaEkleToolStripMenuItem.Text = "Oda Ekle";
            odaEkleToolStripMenuItem.Click += odaEkleToolStripMenuItem_Click;
            // 
            // odaDüzenleToolStripMenuItem
            // 
            odaDüzenleToolStripMenuItem.Name = "odaDüzenleToolStripMenuItem";
            odaDüzenleToolStripMenuItem.Size = new Size(178, 26);
            odaDüzenleToolStripMenuItem.Text = "Oda Düzenle";
            odaDüzenleToolStripMenuItem.Click += odaDüzenleToolStripMenuItem_Click;
            // 
            // odaSilToolStripMenuItem
            // 
            odaSilToolStripMenuItem.Name = "odaSilToolStripMenuItem";
            odaSilToolStripMenuItem.Size = new Size(178, 26);
            odaSilToolStripMenuItem.Text = "Oda Sil";
            odaSilToolStripMenuItem.Click += odaSilToolStripMenuItem_Click;
            // 
            // rezervasyonİşlemleriToolStripMenuItem
            // 
            rezervasyonİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rezervasyonEkleToolStripMenuItem, rezervasyonSilToolStripMenuItem, rezervasyonlToolStripMenuItem });
            rezervasyonİşlemleriToolStripMenuItem.Name = "rezervasyonİşlemleriToolStripMenuItem";
            rezervasyonİşlemleriToolStripMenuItem.Size = new Size(177, 24);
            rezervasyonİşlemleriToolStripMenuItem.Text = "Rezervasyon İşlemleri ";
            // 
            // rezervasyonEkleToolStripMenuItem
            // 
            rezervasyonEkleToolStripMenuItem.Name = "rezervasyonEkleToolStripMenuItem";
            rezervasyonEkleToolStripMenuItem.Size = new Size(243, 26);
            rezervasyonEkleToolStripMenuItem.Text = "Rezervasyon Ekle";
            rezervasyonEkleToolStripMenuItem.Click += rezervasyonEkleToolStripMenuItem_Click;
            // 
            // rezervasyonSilToolStripMenuItem
            // 
            rezervasyonSilToolStripMenuItem.Name = "rezervasyonSilToolStripMenuItem";
            rezervasyonSilToolStripMenuItem.Size = new Size(243, 26);
            rezervasyonSilToolStripMenuItem.Text = "Rezervasyon İptal Et";
            rezervasyonSilToolStripMenuItem.Click += rezervasyonSilToolStripMenuItem_Click;
            // 
            // rezervasyonlToolStripMenuItem
            // 
            rezervasyonlToolStripMenuItem.Name = "rezervasyonlToolStripMenuItem";
            rezervasyonlToolStripMenuItem.Size = new Size(243, 26);
            rezervasyonlToolStripMenuItem.Text = "Rezervasyon Görüntüle";
            // 
            // dgvReservations
            // 
            dgvReservations.BackgroundColor = SystemColors.ButtonFace;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Columns.AddRange(new DataGridViewColumn[] { DownloadBillColumn, BillDetailsColumn });
            dgvReservations.Location = new Point(25, 152);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(1136, 403);
            dgvReservations.TabIndex = 1;
            dgvReservations.CellContentClick += dgvReservations_CellContentClick;
            // 
            // DownloadBillColumn
            // 
            DownloadBillColumn.HeaderText = "Fatura İndir";
            DownloadBillColumn.MinimumWidth = 6;
            DownloadBillColumn.Name = "DownloadBillColumn";
            DownloadBillColumn.Text = "İndir";
            DownloadBillColumn.UseColumnTextForButtonValue = true;
            DownloadBillColumn.Width = 125;
            // 
            // BillDetailsColumn
            // 
            BillDetailsColumn.HeaderText = "Fatura Detayları";
            BillDetailsColumn.MinimumWidth = 6;
            BillDetailsColumn.Name = "BillDetailsColumn";
            BillDetailsColumn.Text = "Detaylar";
            BillDetailsColumn.UseColumnTextForButtonValue = true;
            BillDetailsColumn.Width = 125;
            // 
            // btnAddReservation
            // 
            btnAddReservation.BackColor = Color.LimeGreen;
            btnAddReservation.Font = new Font("Segoe UI", 10F);
            btnAddReservation.ForeColor = SystemColors.Control;
            btnAddReservation.Location = new Point(25, 69);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(162, 46);
            btnAddReservation.TabIndex = 2;
            btnAddReservation.Text = "Rezervasyon Ekle";
            btnAddReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnAddReservation.UseVisualStyleBackColor = false;
            btnAddReservation.Click += button1_Click;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.BackColor = Color.Red;
            btnCancelReservation.ForeColor = SystemColors.ControlLightLight;
            btnCancelReservation.Location = new Point(244, 69);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(172, 45);
            btnCancelReservation.TabIndex = 3;
            btnCancelReservation.Text = "Rezervasyon İptal Et";
            btnCancelReservation.UseVisualStyleBackColor = false;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.BackColor = SystemColors.ControlLight;
            pnlChangePassword.Controls.Add(txtNewPassword);
            pnlChangePassword.Controls.Add(txtOldPassword);
            pnlChangePassword.Controls.Add(txtEmail);
            pnlChangePassword.Controls.Add(btnSavePassword);
            pnlChangePassword.Controls.Add(label3);
            pnlChangePassword.Controls.Add(label2);
            pnlChangePassword.Controls.Add(label1);
            pnlChangePassword.Location = new Point(922, 103);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Size = new Size(239, 197);
            pnlChangePassword.TabIndex = 4;
            pnlChangePassword.Paint += panel1_Paint;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(91, 103);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(125, 27);
            txtNewPassword.TabIndex = 6;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(91, 61);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(125, 27);
            txtOldPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 18);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.Red;
            btnSavePassword.ForeColor = SystemColors.ButtonHighlight;
            btnSavePassword.Location = new Point(91, 146);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(94, 34);
            btnSavePassword.TabIndex = 3;
            btnSavePassword.Text = "Kaydet";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Yeni Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 61);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Eski Şifre  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "E-Posta :";
            // 
            // pictureBoxSettings
            // 
            pictureBoxSettings.BackColor = SystemColors.ControlLight;
            pictureBoxSettings.Image = Properties.Resources.cogwheel1;
            pictureBoxSettings.Location = new Point(1104, 52);
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.Size = new Size(57, 45);
            pictureBoxSettings.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSettings.TabIndex = 5;
            pictureBoxSettings.TabStop = false;
            pictureBoxSettings.Click += pictureBoxSettings_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1186, 585);
            Controls.Add(pictureBoxSettings);
            Controls.Add(pnlChangePassword);
            Controls.Add(btnCancelReservation);
            Controls.Add(btnAddReservation);
            Controls.Add(dgvReservations);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "Ana Menü";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            pnlChangePassword.ResumeLayout(false);
            pnlChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem odaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem odaEkleToolStripMenuItem;
        private ToolStripMenuItem odaDüzenleToolStripMenuItem;
        private ToolStripMenuItem odaSilToolStripMenuItem;
        private ToolStripMenuItem rezervasyonİşlemleriToolStripMenuItem;
        private ToolStripMenuItem rezervasyonEkleToolStripMenuItem;
        private ToolStripMenuItem rezervasyonSilToolStripMenuItem;
        private DataGridView dgvReservations;
        private Button btnAddReservation;
        private ToolStripMenuItem rezervasyonlToolStripMenuItem;
        private Button btnCancelReservation;
        private DataGridViewButtonColumn DownloadBillColumn;
        private DataGridViewButtonColumn BillDetailsColumn;
        private Panel pnlChangePassword;
        private PictureBox pictureBoxSettings;
        private Label label2;
        private Label label1;
        private Button btnSavePassword;
        private Label label3;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private TextBox txtEmail;
    }
}