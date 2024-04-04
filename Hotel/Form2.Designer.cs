namespace Hotel
{
    partial class Form2
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
            guestСard = new Label();
            numberOfDays = new Label();
            travelAni = new CheckBox();
            SNP = new Label();
            birth = new Label();
            payment = new ComboBox();
            minusButton = new Button();
            plusButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // guestСard
            // 
            guestСard.AutoSize = true;
            guestСard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guestСard.ForeColor = Color.FromArgb(128, 64, 0);
            guestСard.Location = new Point(89, 27);
            guestСard.Name = "guestСard";
            guestСard.Size = new Size(223, 41);
            guestСard.TabIndex = 0;
            guestСard.Text = "Карточка гостя";
            // 
            // numberOfDays
            // 
            numberOfDays.BorderStyle = BorderStyle.FixedSingle;
            numberOfDays.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberOfDays.ForeColor = Color.FromArgb(128, 64, 0);
            numberOfDays.Location = new Point(212, 351);
            numberOfDays.Name = "numberOfDays";
            numberOfDays.Size = new Size(116, 29);
            numberOfDays.TabIndex = 1;
            numberOfDays.Text = "Кол-во дней";
            // 
            // travelAni
            // 
            travelAni.AutoSize = true;
            travelAni.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            travelAni.ForeColor = Color.FromArgb(128, 64, 0);
            travelAni.Location = new Point(68, 413);
            travelAni.Name = "travelAni";
            travelAni.Size = new Size(246, 27);
            travelAni.TabIndex = 2;
            travelAni.Text = "путешествую с животными";
            travelAni.UseVisualStyleBackColor = true;
            // 
            // SNP
            // 
            SNP.BorderStyle = BorderStyle.FixedSingle;
            SNP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SNP.ForeColor = Color.FromArgb(128, 64, 0);
            SNP.Location = new Point(68, 114);
            SNP.Name = "SNP";
            SNP.Size = new Size(260, 31);
            SNP.TabIndex = 3;
            SNP.Text = "ФИО";
            // 
            // birth
            // 
            birth.BorderStyle = BorderStyle.FixedSingle;
            birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birth.ForeColor = Color.FromArgb(128, 64, 0);
            birth.Location = new Point(68, 178);
            birth.Name = "birth";
            birth.Size = new Size(260, 35);
            birth.TabIndex = 4;
            birth.Text = "Дата рождения";
            // 
            // payment
            // 
            payment.BackColor = Color.FromArgb(255, 224, 192);
            payment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            payment.ForeColor = Color.FromArgb(128, 64, 0);
            payment.FormattingEnabled = true;
            payment.Location = new Point(68, 244);
            payment.Name = "payment";
            payment.Size = new Size(260, 36);
            payment.TabIndex = 5;
            payment.Text = "Оплата";
            // 
            // minusButton
            // 
            minusButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            minusButton.Location = new Point(153, 351);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(35, 29);
            minusButton.TabIndex = 6;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            // 
            // plusButton
            // 
            plusButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plusButton.Location = new Point(89, 351);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(28, 29);
            plusButton.TabIndex = 7;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(116, 351);
            label3.Name = "label3";
            label3.Size = new Size(40, 29);
            label3.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(419, 468);
            Controls.Add(label3);
            Controls.Add(plusButton);
            Controls.Add(minusButton);
            Controls.Add(payment);
            Controls.Add(birth);
            Controls.Add(SNP);
            Controls.Add(travelAni);
            Controls.Add(numberOfDays);
            Controls.Add(guestСard);
            Name = "Form2";
            Text = "Карточка гостя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label guestСard;
        private Label numberOfDays;
        private CheckBox travelAni;
        private Label SNP;
        private Label birth;
        private ComboBox payment;
        private Button minusButton;
        private Button plusButton;
        private Label label3;
    }
}