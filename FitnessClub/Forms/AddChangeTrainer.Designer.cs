namespace FitnessClub.Forms
{
    partial class AddChangeTrainer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            HeaderLabel = new Label();
            label2 = new Label();
            SecondNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            label3 = new Label();
            AddButton = new Button();
            label4 = new Label();
            PatronymicTextBox = new TextBox();
            label5 = new Label();
            BirthdateDateTime = new DateTimePicker();
            label6 = new Label();
            PhoneMaskedBox = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            UploadPhotoButton = new Button();
            label9 = new Label();
            PhotoPictureBox = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(HeaderLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(SecondNameTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(FirstNameTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(AddButton, 1, 18);
            tableLayoutPanel1.Controls.Add(label4, 1, 7);
            tableLayoutPanel1.Controls.Add(PatronymicTextBox, 1, 8);
            tableLayoutPanel1.Controls.Add(label5, 1, 9);
            tableLayoutPanel1.Controls.Add(BirthdateDateTime, 1, 10);
            tableLayoutPanel1.Controls.Add(label6, 1, 11);
            tableLayoutPanel1.Controls.Add(PhoneMaskedBox, 1, 12);
            tableLayoutPanel1.Controls.Add(label7, 1, 13);
            tableLayoutPanel1.Controls.Add(label8, 1, 15);
            tableLayoutPanel1.Controls.Add(LoginTextBox, 1, 14);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 16);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 17);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(414, 591);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Dock = DockStyle.Fill;
            HeaderLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.Location = new Point(35, 32);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(344, 32);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Добавление тренера";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(35, 64);
            label2.Name = "label2";
            label2.Size = new Size(344, 21);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Dock = DockStyle.Fill;
            SecondNameTextBox.Location = new Point(35, 88);
            SecondNameTextBox.MaxLength = 30;
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(344, 29);
            SecondNameTextBox.TabIndex = 2;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Dock = DockStyle.Fill;
            FirstNameTextBox.Location = new Point(35, 144);
            FirstNameTextBox.MaxLength = 30;
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(344, 29);
            FirstNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(35, 120);
            label3.Name = "label3";
            label3.Size = new Size(344, 21);
            label3.TabIndex = 4;
            label3.Text = "Имя";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.BackColor = Color.FromArgb(73, 40, 112);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(121, 524);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(171, 32);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить тренера";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(35, 176);
            label4.Name = "label4";
            label4.Size = new Size(344, 21);
            label4.TabIndex = 6;
            label4.Text = "Отчество";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Dock = DockStyle.Fill;
            PatronymicTextBox.Location = new Point(35, 200);
            PatronymicTextBox.MaxLength = 30;
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(344, 29);
            PatronymicTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(35, 232);
            label5.Name = "label5";
            label5.Size = new Size(344, 21);
            label5.TabIndex = 8;
            label5.Text = "Дата рождения";
            // 
            // BirthdateDateTime
            // 
            BirthdateDateTime.Dock = DockStyle.Fill;
            BirthdateDateTime.Format = DateTimePickerFormat.Short;
            BirthdateDateTime.Location = new Point(35, 256);
            BirthdateDateTime.Name = "BirthdateDateTime";
            BirthdateDateTime.Size = new Size(344, 29);
            BirthdateDateTime.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(35, 288);
            label6.Name = "label6";
            label6.Size = new Size(344, 21);
            label6.TabIndex = 10;
            label6.Text = "Телефон";
            // 
            // PhoneMaskedBox
            // 
            PhoneMaskedBox.Dock = DockStyle.Fill;
            PhoneMaskedBox.Location = new Point(35, 312);
            PhoneMaskedBox.Mask = "+7 (000) 000-00-00";
            PhoneMaskedBox.Name = "PhoneMaskedBox";
            PhoneMaskedBox.Size = new Size(344, 29);
            PhoneMaskedBox.TabIndex = 11;
            PhoneMaskedBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(35, 344);
            label7.Name = "label7";
            label7.Size = new Size(344, 21);
            label7.TabIndex = 12;
            label7.Text = "Логин";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(35, 400);
            label8.Name = "label8";
            label8.Size = new Size(344, 21);
            label8.TabIndex = 13;
            label8.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Dock = DockStyle.Fill;
            LoginTextBox.Location = new Point(35, 368);
            LoginTextBox.MaxLength = 30;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(344, 29);
            LoginTextBox.TabIndex = 14;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Dock = DockStyle.Fill;
            PasswordTextBox.Location = new Point(35, 424);
            PasswordTextBox.MaxLength = 30;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(344, 29);
            PasswordTextBox.TabIndex = 15;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(UploadPhotoButton, 0, 1);
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Controls.Add(PhotoPictureBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(35, 459);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(344, 59);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // UploadPhotoButton
            // 
            UploadPhotoButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UploadPhotoButton.BackColor = Color.FromArgb(222, 222, 222);
            UploadPhotoButton.FlatStyle = FlatStyle.Flat;
            UploadPhotoButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UploadPhotoButton.ForeColor = Color.White;
            UploadPhotoButton.Location = new Point(3, 24);
            UploadPhotoButton.Name = "UploadPhotoButton";
            UploadPhotoButton.Size = new Size(166, 32);
            UploadPhotoButton.TabIndex = 4;
            UploadPhotoButton.Text = "Загрузить";
            UploadPhotoButton.UseVisualStyleBackColor = false;
            UploadPhotoButton.Click += UploadPhotoButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 21);
            label9.TabIndex = 0;
            label9.Text = "Фотография";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Anchor = AnchorStyles.None;
            PhotoPictureBox.BorderStyle = BorderStyle.FixedSingle;
            PhotoPictureBox.Location = new Point(233, 4);
            PhotoPictureBox.Name = "PhotoPictureBox";
            tableLayoutPanel2.SetRowSpan(PhotoPictureBox, 2);
            PhotoPictureBox.Size = new Size(50, 50);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhotoPictureBox.TabIndex = 2;
            PhotoPictureBox.TabStop = false;
            // 
            // AddChangeTrainer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(414, 591);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddChangeTrainer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label HeaderLabel;
        private Label label2;
        private TextBox SecondNameTextBox;
        private TextBox FirstNameTextBox;
        private Label label3;
        private Button AddButton;
        private Label label4;
        private TextBox PatronymicTextBox;
        private Label label5;
        private DateTimePicker BirthdateDateTime;
        private Label label6;
        private MaskedTextBox PhoneMaskedBox;
        private Label label7;
        private Label label8;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private Button button1;
        private PictureBox PhotoPictureBox;
        private Button UploadPhotoButton;
    }
}