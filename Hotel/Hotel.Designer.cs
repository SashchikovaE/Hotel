namespace Hotel
{
    partial class HotelIgor
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            areDischargedButton = new RadioButton();
            occupiedButton = new RadioButton();
            reservedButton = new RadioButton();
            availableButton = new RadioButton();
            panel2 = new Panel();
            label7 = new Label();
            ld = new Label();
            fd = new Label();
            SNRlabel = new Label();
            viewingCard = new Button();
            statusLabel = new Label();
            statusBox = new ComboBox();
            number = new Label();
            profilePicture = new PictureBox();
            status = new Label();
            guestsBox = new ListBox();
            listGuests = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(areDischargedButton);
            panel1.Controls.Add(occupiedButton);
            panel1.Controls.Add(reservedButton);
            panel1.Controls.Add(availableButton);
            panel1.Location = new Point(1, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 526);
            panel1.TabIndex = 0;
            // 
            // areDischargedButton
            // 
            areDischargedButton.AutoSize = true;
            areDischargedButton.ForeColor = Color.FromArgb(128, 64, 0);
            areDischargedButton.Location = new Point(10, 230);
            areDischargedButton.Name = "areDischargedButton";
            areDischargedButton.Size = new Size(135, 24);
            areDischargedButton.TabIndex = 4;
            areDischargedButton.TabStop = true;
            areDischargedButton.Text = "Выписываются";
            areDischargedButton.UseVisualStyleBackColor = true;
            areDischargedButton.CheckedChanged += areDischargedButton_CheckedChanged;
            // 
            // occupiedButton
            // 
            occupiedButton.AutoSize = true;
            occupiedButton.ForeColor = Color.FromArgb(128, 64, 0);
            occupiedButton.Location = new Point(10, 174);
            occupiedButton.Name = "occupiedButton";
            occupiedButton.Size = new Size(80, 24);
            occupiedButton.TabIndex = 5;
            occupiedButton.TabStop = true;
            occupiedButton.Text = "Заняты";
            occupiedButton.UseVisualStyleBackColor = true;
            occupiedButton.CheckedChanged += occupiedButton_CheckedChanged;
            // 
            // reservedButton
            // 
            reservedButton.AutoSize = true;
            reservedButton.ForeColor = Color.FromArgb(128, 64, 0);
            reservedButton.Location = new Point(10, 62);
            reservedButton.Name = "reservedButton";
            reservedButton.Size = new Size(156, 24);
            reservedButton.TabIndex = 3;
            reservedButton.TabStop = true;
            reservedButton.Text = "Зарезервировано";
            reservedButton.UseVisualStyleBackColor = true;
            reservedButton.CheckedChanged += reservedButton_CheckedChanged;
            // 
            // availableButton
            // 
            availableButton.AutoSize = true;
            availableButton.ForeColor = Color.FromArgb(128, 64, 0);
            availableButton.Location = new Point(10, 117);
            availableButton.Name = "availableButton";
            availableButton.Size = new Size(110, 24);
            availableButton.TabIndex = 3;
            availableButton.TabStop = true;
            availableButton.Text = "Свободные";
            availableButton.UseVisualStyleBackColor = true;
            availableButton.CheckedChanged += availableButton_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ld);
            panel2.Controls.Add(fd);
            panel2.Controls.Add(SNRlabel);
            panel2.Controls.Add(viewingCard);
            panel2.Controls.Add(statusLabel);
            panel2.Controls.Add(statusBox);
            panel2.Controls.Add(number);
            panel2.Controls.Add(profilePicture);
            panel2.Location = new Point(601, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 526);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(124, 11);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 15;
            // 
            // ld
            // 
            ld.BorderStyle = BorderStyle.FixedSingle;
            ld.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ld.ForeColor = Color.FromArgb(128, 64, 0);
            ld.Location = new Point(217, 385);
            ld.Name = "ld";
            ld.Size = new Size(118, 34);
            ld.TabIndex = 14;
            ld.Text = "Дата выезда";
            // 
            // fd
            // 
            fd.BorderStyle = BorderStyle.FixedSingle;
            fd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fd.ForeColor = Color.FromArgb(128, 64, 0);
            fd.Location = new Point(39, 385);
            fd.Name = "fd";
            fd.Size = new Size(114, 34);
            fd.TabIndex = 13;
            fd.Text = "Дата заезда";
            // 
            // SNRlabel
            // 
            SNRlabel.BorderStyle = BorderStyle.FixedSingle;
            SNRlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SNRlabel.ForeColor = Color.FromArgb(128, 64, 0);
            SNRlabel.Location = new Point(39, 309);
            SNRlabel.Name = "SNRlabel";
            SNRlabel.Size = new Size(296, 41);
            SNRlabel.TabIndex = 12;
            SNRlabel.Text = "ФИО";
            // 
            // viewingCard
            // 
            viewingCard.BackColor = Color.FromArgb(255, 224, 192);
            viewingCard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            viewingCard.ForeColor = Color.FromArgb(128, 64, 0);
            viewingCard.Location = new Point(88, 465);
            viewingCard.Name = "viewingCard";
            viewingCard.Size = new Size(193, 49);
            viewingCard.TabIndex = 11;
            viewingCard.Text = "Просмотр карточки";
            viewingCard.UseVisualStyleBackColor = false;
            viewingCard.Click += viewingCard_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BorderStyle = BorderStyle.FixedSingle;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusLabel.ForeColor = Color.FromArgb(128, 64, 0);
            statusLabel.Location = new Point(39, 245);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(71, 30);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Статус";
            // 
            // statusBox
            // 
            statusBox.BackColor = Color.FromArgb(255, 224, 192);
            statusBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "Зарезервировано", "Свободные", "Заняты", "Выписываются" });
            statusBox.Location = new Point(116, 244);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(151, 31);
            statusBox.TabIndex = 9;
            // 
            // number
            // 
            number.AutoSize = true;
            number.BorderStyle = BorderStyle.FixedSingle;
            number.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            number.ForeColor = Color.FromArgb(128, 64, 0);
            number.Location = new Point(-1, -2);
            number.Name = "number";
            number.Size = new Size(119, 33);
            number.TabIndex = 7;
            number.Text = "Номер №";
            // 
            // profilePicture
            // 
            profilePicture.BorderStyle = BorderStyle.FixedSingle;
            profilePicture.Location = new Point(94, 62);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(136, 136);
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // status
            // 
            status.AutoSize = true;
            status.BorderStyle = BorderStyle.FixedSingle;
            status.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            status.ForeColor = Color.FromArgb(128, 64, 0);
            status.Location = new Point(1, 31);
            status.Name = "status";
            status.Size = new Size(82, 33);
            status.TabIndex = 4;
            status.Text = "Статус";
            // 
            // guestsBox
            // 
            guestsBox.BackColor = Color.FromArgb(255, 224, 192);
            guestsBox.BorderStyle = BorderStyle.FixedSingle;
            guestsBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guestsBox.ForeColor = Color.FromArgb(128, 64, 0);
            guestsBox.FormattingEnabled = true;
            guestsBox.ItemHeight = 25;
            guestsBox.Location = new Point(176, 64);
            guestsBox.Name = "guestsBox";
            guestsBox.Size = new Size(419, 477);
            guestsBox.TabIndex = 5;
            guestsBox.DoubleClick += GuestBox_DoubleClick;
            // 
            // listGuests
            // 
            listGuests.AutoSize = true;
            listGuests.BorderStyle = BorderStyle.FixedSingle;
            listGuests.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listGuests.ForeColor = Color.FromArgb(128, 64, 0);
            listGuests.Location = new Point(176, 30);
            listGuests.Name = "listGuests";
            listGuests.Size = new Size(164, 33);
            listGuests.TabIndex = 6;
            listGuests.Text = "Список гостей";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer
            // 
            timer.BorderStyle = BorderStyle.FixedSingle;
            timer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timer.ForeColor = Color.FromArgb(128, 64, 0);
            timer.Location = new Point(1, -1);
            timer.Name = "timer";
            timer.Size = new Size(146, 32);
            timer.TabIndex = 7;
            timer.Text = "timer";
            // 
            // HotelIgor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(972, 561);
            Controls.Add(timer);
            Controls.Add(listGuests);
            Controls.Add(guestsBox);
            Controls.Add(status);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HotelIgor";
            Text = "Отель \"Игорёк\"";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Panel panel2;
        public RadioButton areDischargedButton;
        public RadioButton occupiedButton;
        public RadioButton reservedButton;
        public RadioButton availableButton;
        private Label status;
        public ListBox guestsBox;
        private Label listGuests;
        private PictureBox profilePicture;
        private Label number;
        private ComboBox statusBox;
        private Label statusLabel;
        private Button viewingCard;
        private Label SNRlabel;
        private Label ld;
        private Label fd;
        private System.Windows.Forms.Timer timer1;
        private Label timer;
        private Label label7;
    }
}
