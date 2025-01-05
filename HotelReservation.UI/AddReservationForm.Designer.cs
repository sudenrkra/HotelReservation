﻿namespace HotelReservation.UI
{
    partial class AddReservationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpEntryDate = new DateTimePicker();
            dtpReleaseDate = new DateTimePicker();
            cmbRoomId = new ComboBox();
            txtCustomerName = new TextBox();
            txtCustomerSurname = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 192);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 260);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 68);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 2;
            label3.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 133);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 317);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Oda Id:";
            // 
            // dtpEntryDate
            // 
            dtpEntryDate.Location = new Point(183, 185);
            dtpEntryDate.Name = "dtpEntryDate";
            dtpEntryDate.Size = new Size(196, 27);
            dtpEntryDate.TabIndex = 5;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(183, 255);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(196, 27);
            dtpReleaseDate.TabIndex = 6;
            // 
            // cmbRoomId
            // 
            cmbRoomId.FormattingEnabled = true;
            cmbRoomId.Location = new Point(183, 314);
            cmbRoomId.Name = "cmbRoomId";
            cmbRoomId.Size = new Size(71, 28);
            cmbRoomId.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(183, 65);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(196, 27);
            txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerSurname
            // 
            txtCustomerSurname.Location = new Point(183, 126);
            txtCustomerSurname.Name = "txtCustomerSurname";
            txtCustomerSurname.Size = new Size(196, 27);
            txtCustomerSurname.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Firebrick;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(183, 387);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 52);
            btnSave.TabIndex = 11;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 535);
            Controls.Add(btnSave);
            Controls.Add(txtCustomerSurname);
            Controls.Add(txtCustomerName);
            Controls.Add(cmbRoomId);
            Controls.Add(dtpReleaseDate);
            Controls.Add(dtpEntryDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddReservationForm";
            Text = "AddReservationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpEntryDate;
        private DateTimePicker dtpReleaseDate;
        private ComboBox cmbRoomId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerSurname;
        private Button btnSave;
    }
}