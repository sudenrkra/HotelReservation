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
            dgvReservations = new DataGridView();
            btnAddReservation = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { odaİşlemleriToolStripMenuItem, rezervasyonİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // odaİşlemleriToolStripMenuItem
            // 
            odaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { odaEkleToolStripMenuItem, odaDüzenleToolStripMenuItem, odaSilToolStripMenuItem });
            odaİşlemleriToolStripMenuItem.Name = "odaİşlemleriToolStripMenuItem";
            odaİşlemleriToolStripMenuItem.Size = new Size(115, 24);
            odaİşlemleriToolStripMenuItem.Text = "Oda İşlemleri ";
            // 
            // odaEkleToolStripMenuItem
            // 
            odaEkleToolStripMenuItem.Name = "odaEkleToolStripMenuItem";
            odaEkleToolStripMenuItem.Size = new Size(174, 26);
            odaEkleToolStripMenuItem.Text = "Oda ekle";
            odaEkleToolStripMenuItem.Click += odaEkleToolStripMenuItem_Click;
            // 
            // odaDüzenleToolStripMenuItem
            // 
            odaDüzenleToolStripMenuItem.Name = "odaDüzenleToolStripMenuItem";
            odaDüzenleToolStripMenuItem.Size = new Size(174, 26);
            odaDüzenleToolStripMenuItem.Text = "oda düzenle";
            odaDüzenleToolStripMenuItem.Click += odaDüzenleToolStripMenuItem_Click;
            // 
            // odaSilToolStripMenuItem
            // 
            odaSilToolStripMenuItem.Name = "odaSilToolStripMenuItem";
            odaSilToolStripMenuItem.Size = new Size(174, 26);
            odaSilToolStripMenuItem.Text = "oda sil";
            odaSilToolStripMenuItem.Click += odaSilToolStripMenuItem_Click;
            // 
            // rezervasyonİşlemleriToolStripMenuItem
            // 
            rezervasyonİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rezervasyonEkleToolStripMenuItem, rezervasyonSilToolStripMenuItem });
            rezervasyonİşlemleriToolStripMenuItem.Name = "rezervasyonİşlemleriToolStripMenuItem";
            rezervasyonİşlemleriToolStripMenuItem.Size = new Size(165, 24);
            rezervasyonİşlemleriToolStripMenuItem.Text = "Rezervasyon İşlemleri";
            // 
            // rezervasyonEkleToolStripMenuItem
            // 
            rezervasyonEkleToolStripMenuItem.Name = "rezervasyonEkleToolStripMenuItem";
            rezervasyonEkleToolStripMenuItem.Size = new Size(225, 26);
            rezervasyonEkleToolStripMenuItem.Text = "Rezervasyon Ekle";
            rezervasyonEkleToolStripMenuItem.Click += rezervasyonEkleToolStripMenuItem_Click;
            // 
            // rezervasyonSilToolStripMenuItem
            // 
            rezervasyonSilToolStripMenuItem.Name = "rezervasyonSilToolStripMenuItem";
            rezervasyonSilToolStripMenuItem.Size = new Size(225, 26);
            rezervasyonSilToolStripMenuItem.Text = "Rezervasyon İptal Et";
            rezervasyonSilToolStripMenuItem.Click += rezervasyonSilToolStripMenuItem_Click;
            // 
            // dgvReservations
            // 
            dgvReservations.BackgroundColor = SystemColors.ButtonFace;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(25, 145);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(595, 331);
            dgvReservations.TabIndex = 1;
            // 
            // btnAddReservation
            // 
            btnAddReservation.BackColor = Color.Maroon;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(btnAddReservation);
            Controls.Add(dgvReservations);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "MainForm";
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
    }
}