namespace FitnessClub.Forms
{
    partial class TrainerInfoForm
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
            ExperienceLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            TrainerPhotoPictureBox = new PictureBox();
            NameLabel = new Label();
            FullNameLabel = new Label();
            label10 = new Label();
            panel2 = new Panel();
            AgeLabel = new Label();
            AchivementsListBox = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainerPhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ExperienceLabel
            // 
            ExperienceLabel.AutoSize = true;
            ExperienceLabel.Dock = DockStyle.Fill;
            ExperienceLabel.ForeColor = Color.FromArgb(51, 51, 51);
            ExperienceLabel.Location = new Point(52, 98);
            ExperienceLabel.Name = "ExperienceLabel";
            ExperienceLabel.Size = new Size(394, 21);
            ExperienceLabel.TabIndex = 6;
            ExperienceLabel.Text = "Стаж: 5 лет";
            ExperienceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(TrainerPhotoPictureBox, 2, 2);
            tableLayoutPanel1.Controls.Add(NameLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(FullNameLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(ExperienceLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 1, 5);
            tableLayoutPanel1.Controls.Add(panel2, 1, 6);
            tableLayoutPanel1.Controls.Add(AgeLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(AchivementsListBox, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(584, 311);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // TrainerPhotoPictureBox
            // 
            TrainerPhotoPictureBox.Location = new Point(452, 76);
            TrainerPhotoPictureBox.Name = "TrainerPhotoPictureBox";
            tableLayoutPanel1.SetRowSpan(TrainerPhotoPictureBox, 4);
            TrainerPhotoPictureBox.Size = new Size(80, 80);
            TrainerPhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            TrainerPhotoPictureBox.TabIndex = 0;
            TrainerPhotoPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(NameLabel, 2);
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(52, 41);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(480, 32);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Информация о тренере";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Dock = DockStyle.Fill;
            FullNameLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameLabel.Location = new Point(52, 73);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(394, 25);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Петров Александр";
            FullNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(52, 140);
            label10.Name = "label10";
            label10.Size = new Size(394, 21);
            label10.TabIndex = 9;
            label10.Text = "Достижения";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(222, 222, 222);
            tableLayoutPanel1.SetColumnSpan(panel2, 2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(52, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 1);
            panel2.TabIndex = 10;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(52, 119);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(69, 21);
            AgeLabel.TabIndex = 12;
            AgeLabel.Text = "Возраст:";
            // 
            // AchivementsListBox
            // 
            tableLayoutPanel1.SetColumnSpan(AchivementsListBox, 2);
            AchivementsListBox.DisplayMember = "Achievement";
            AchivementsListBox.Dock = DockStyle.Fill;
            AchivementsListBox.FormattingEnabled = true;
            AchivementsListBox.ItemHeight = 21;
            AchivementsListBox.Location = new Point(52, 171);
            AchivementsListBox.Name = "AchivementsListBox";
            AchivementsListBox.Size = new Size(480, 96);
            AchivementsListBox.TabIndex = 13;
            // 
            // TrainerInfoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 311);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerInfoForm";
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrainerPhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ExperienceLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label NameLabel;
        private Label FullNameLabel;
        private Label label10;
        private Panel panel2;
        private PictureBox TrainerPhotoPictureBox;
        private Label AgeLabel;
        private ListBox AchivementsListBox;
    }
}