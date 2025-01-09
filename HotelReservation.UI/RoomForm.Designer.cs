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
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(44, 432);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(669, 138);
            dgvRooms.TabIndex = 0;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(44, 359);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(94, 29);
            btnAddRoom.TabIndex = 1;
            btnAddRoom.Text = "Oda Ekle";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(115, 47);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(125, 27);
            txtRoomType.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(115, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(115, 160);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(125, 27);
            txtCapacity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 5;
            label1.Text = "Oda Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 108);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 6;
            label2.Text = "Fiyat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 167);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Kapasite";
            // 
            // chkState
            // 
            chkState.AutoSize = true;
            chkState.Location = new Point(115, 223);
            chkState.Name = "chkState";
            chkState.Size = new Size(116, 24);
            chkState.TabIndex = 8;
            chkState.Text = "Oda Durumu";
            chkState.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.Location = new Point(206, 359);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(147, 29);
            btnUpdateRoom.TabIndex = 9;
            btnUpdateRoom.Text = "Oda Düzenle";
            btnUpdateRoom.UseVisualStyleBackColor = true;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Location = new Point(408, 359);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(94, 29);
            btnDeleteRoom.TabIndex = 10;
            btnDeleteRoom.Text = "Oda Sil";
            btnDeleteRoom.UseVisualStyleBackColor = true;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // picRoom
            // 
            picRoom.Location = new Point(358, 47);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(169, 147);
            picRoom.TabIndex = 11;
            picRoom.TabStop = false;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 613);
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
            Text = "AddRoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
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
    }
}