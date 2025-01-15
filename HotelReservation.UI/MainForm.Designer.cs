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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1186, 585);
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
    }
}