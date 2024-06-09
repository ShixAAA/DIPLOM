namespace FitnessClub.Forms
{
    partial class WorkoutForm
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
            NameLabel = new Label();
            WorkoutTypeLabel = new Label();
            TimeLabel = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            TrainerPhotoPictureBox = new PictureBox();
            TrainerLabel = new Label();
            DetailsButton = new Button();
            RoomLabel = new Label();
            label10 = new Label();
            panel2 = new Panel();
            DesciptionLabel = new Label();
            SignUpButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainerPhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NameLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(WorkoutTypeLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(TimeLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(panel1, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(label10, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 1, 7);
            tableLayoutPanel1.Controls.Add(DesciptionLabel, 1, 8);
            tableLayoutPanel1.Controls.Add(SignUpButton, 1, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(584, 436);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(45, 86);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(494, 32);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Тренировка";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WorkoutTypeLabel
            // 
            WorkoutTypeLabel.AutoSize = true;
            WorkoutTypeLabel.Dock = DockStyle.Fill;
            WorkoutTypeLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            WorkoutTypeLabel.Location = new Point(45, 118);
            WorkoutTypeLabel.Name = "WorkoutTypeLabel";
            WorkoutTypeLabel.Size = new Size(494, 25);
            WorkoutTypeLabel.TabIndex = 1;
            WorkoutTypeLabel.Text = "Спорт";
            WorkoutTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Dock = DockStyle.Fill;
            TimeLabel.ForeColor = Color.FromArgb(51, 51, 51);
            TimeLabel.Location = new Point(45, 143);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(494, 21);
            TimeLabel.TabIndex = 6;
            TimeLabel.Text = "00:00-00:00 (50 мин)";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 222, 222);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(45, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 1);
            panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(TrainerPhotoPictureBox, 0, 0);
            tableLayoutPanel2.Controls.Add(TrainerLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(DetailsButton, 1, 1);
            tableLayoutPanel2.Controls.Add(RoomLabel, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(45, 174);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(494, 86);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // TrainerPhotoPictureBox
            // 
            TrainerPhotoPictureBox.Dock = DockStyle.Fill;
            TrainerPhotoPictureBox.Location = new Point(3, 3);
            TrainerPhotoPictureBox.Name = "TrainerPhotoPictureBox";
            tableLayoutPanel2.SetRowSpan(TrainerPhotoPictureBox, 3);
            TrainerPhotoPictureBox.Size = new Size(80, 80);
            TrainerPhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            TrainerPhotoPictureBox.TabIndex = 0;
            TrainerPhotoPictureBox.TabStop = false;
            // 
            // TrainerLabel
            // 
            TrainerLabel.AutoSize = true;
            TrainerLabel.Dock = DockStyle.Fill;
            TrainerLabel.Location = new Point(89, 0);
            TrainerLabel.Name = "TrainerLabel";
            TrainerLabel.Size = new Size(402, 21);
            TrainerLabel.TabIndex = 1;
            TrainerLabel.Text = "Петров Максим";
            // 
            // DetailsButton
            // 
            DetailsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DetailsButton.BackColor = Color.FromArgb(73, 40, 112);
            DetailsButton.FlatAppearance.BorderSize = 0;
            DetailsButton.FlatStyle = FlatStyle.Flat;
            DetailsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DetailsButton.ForeColor = Color.White;
            DetailsButton.Location = new Point(89, 24);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(109, 32);
            DetailsButton.TabIndex = 2;
            DetailsButton.Text = "Подробнее";
            DetailsButton.UseVisualStyleBackColor = false;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // RoomLabel
            // 
            RoomLabel.AutoSize = true;
            RoomLabel.Dock = DockStyle.Fill;
            RoomLabel.ForeColor = Color.FromArgb(153, 153, 153);
            RoomLabel.Location = new Point(89, 59);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new Size(402, 27);
            RoomLabel.TabIndex = 3;
            RoomLabel.Text = "Зал 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(45, 263);
            label10.Name = "label10";
            label10.Size = new Size(494, 21);
            label10.TabIndex = 9;
            label10.Text = "О тренировке";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 222, 222);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(45, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 1);
            panel2.TabIndex = 10;
            // 
            // DesciptionLabel
            // 
            DesciptionLabel.AutoSize = true;
            DesciptionLabel.Dock = DockStyle.Fill;
            DesciptionLabel.Location = new Point(45, 291);
            DesciptionLabel.Name = "DesciptionLabel";
            DesciptionLabel.Size = new Size(494, 21);
            DesciptionLabel.TabIndex = 11;
            DesciptionLabel.Text = "Тренировка";
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.Top;
            SignUpButton.BackColor = Color.FromArgb(73, 40, 112);
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(232, 315);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(119, 32);
            SignUpButton.TabIndex = 5;
            SignUpButton.Text = "Записаться";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // WorkoutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 436);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WorkoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrainerPhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label NameLabel;
        private Label WorkoutTypeLabel;
        private Button SignUpButton;
        private Label TimeLabel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox TrainerPhotoPictureBox;
        private Label TrainerLabel;
        private Button DetailsButton;
        private Label RoomLabel;
        private Label label10;
        private Panel panel2;
        private Label DesciptionLabel;
    }
}