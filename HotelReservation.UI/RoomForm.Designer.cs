namespace HotelReservation.UI
{
    partial class RoomForm
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
            dgvRooms = new DataGridView();
            btnAddRoom = new Button();
            txtRoomType = new TextBox();
            txtPrice = new TextBox();
            txtCapacity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkState = new CheckBox();
            btnUpdateRoom = new Button();
            btnDeleteRoom = new Button();
            picRoom = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.BackgroundColor = SystemColors.ButtonFace;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(44, 561);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(757, 138);
            dgvRooms.TabIndex = 0;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.LimeGreen;
            btnAddRoom.Location = new Point(44, 500);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(169, 43);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "Oda Ekle";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = SystemColors.ButtonFace;
            txtRoomType.Location = new Point(145, 94);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(150, 27);
            txtRoomType.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.ButtonFace;
            txtPrice.Location = new Point(145, 192);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = SystemColors.ButtonFace;
            txtCapacity.Location = new Point(145, 277);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(150, 27);
            txtCapacity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 96);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 5;
            label1.Text = "Oda Tipi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(32, 191);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 6;
            label2.Text = "Fiyat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(32, 276);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Kapasite :";
            // 
            // chkState
            // 
            chkState.AutoSize = true;
            chkState.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkState.Location = new Point(145, 338);
            chkState.Name = "chkState";
            chkState.Size = new Size(132, 27);
            chkState.TabIndex = 8;
            chkState.Text = "Oda Durumu";
            chkState.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.BackColor = Color.LightSkyBlue;
            btnUpdateRoom.Location = new Point(343, 500);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(164, 43);
            btnUpdateRoom.TabIndex = 9;
            btnUpdateRoom.Text = "Oda Düzenle";
            btnUpdateRoom.UseVisualStyleBackColor = false;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.Red;
            btnDeleteRoom.Font = new Font("Segoe UI", 9F);
            btnDeleteRoom.Location = new Point(637, 500);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(164, 46);
            btnDeleteRoom.TabIndex = 10;
            btnDeleteRoom.Text = "Oda Sil";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // picRoom
            // 
            picRoom.BackColor = SystemColors.ButtonFace;
            picRoom.Location = new Point(408, 32);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(660, 433);
            picRoom.TabIndex = 11;
            picRoom.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back_button;
            pictureBox1.Location = new Point(32, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(76, 23);
            label4.Name = "label4";
            label4.Size = new Size(57, 31);
            label4.TabIndex = 13;
            label4.Text = "Geri";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1187, 727);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(picRoom);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnUpdateRoom);
            Controls.Add(chkState);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCapacity);
            Controls.Add(txtPrice);
            Controls.Add(txtRoomType);
            Controls.Add(btnAddRoom);
            Controls.Add(dgvRooms);
            Name = "RoomForm";
            Text = "Oda İşlemleri";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRooms;
        private Button btnAddRoom;
        private TextBox txtRoomType;
        private TextBox txtPrice;
        private TextBox txtCapacity;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkState;
        private Button btnUpdateRoom;
        private Button btnDeleteRoom;
        private PictureBox picRoom;
        private PictureBox pictureBox1;
        private Label label4;
    }
}