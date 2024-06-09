namespace FitnessClub.UserControls
{
    partial class WorkoutUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            TimeFromToLabel = new Label();
            TimeLabel = new Label();
            NameLabel = new Label();
            TypeLabel = new Label();
            TrainerLabel = new Label();
            RoomLabel = new Label();
            IsDeleteLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TimeFromToLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(TimeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(TypeLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(TrainerLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(RoomLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(IsDeleteLabel, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(0, 146);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Click += Workout_Click;
            // 
            // TimeFromToLabel
            // 
            TimeFromToLabel.AutoSize = true;
            TimeFromToLabel.Dock = DockStyle.Fill;
            TimeFromToLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeFromToLabel.ForeColor = Color.FromArgb(51, 51, 51);
            TimeFromToLabel.Location = new Point(3, 0);
            TimeFromToLabel.Name = "TimeFromToLabel";
            TimeFromToLabel.Size = new Size(1, 1);
            TimeFromToLabel.TabIndex = 0;
            TimeFromToLabel.Text = "00:00-00:00";
            TimeFromToLabel.TextAlign = ContentAlignment.MiddleLeft;
            TimeFromToLabel.Click += Workout_Click;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Dock = DockStyle.Fill;
            TimeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.FromArgb(153, 153, 153);
            TimeLabel.Location = new Point(3, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(1, 1);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "50 мин";
            TimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            TimeLabel.Click += Workout_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(1, 146);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Спорта ";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            NameLabel.Click += Workout_Click;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Dock = DockStyle.Fill;
            TypeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(3, 146);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(1, 1);
            TypeLabel.TabIndex = 3;
            TypeLabel.Text = "Гимнастика";
            TypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            TypeLabel.Click += Workout_Click;
            // 
            // TrainerLabel
            // 
            TrainerLabel.AutoSize = true;
            TrainerLabel.Dock = DockStyle.Fill;
            TrainerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TrainerLabel.ForeColor = Color.FromArgb(51, 51, 51);
            TrainerLabel.Location = new Point(3, 146);
            TrainerLabel.Name = "TrainerLabel";
            TrainerLabel.Size = new Size(1, 1);
            TrainerLabel.TabIndex = 4;
            TrainerLabel.Text = "Сергеев Максим";
            TrainerLabel.TextAlign = ContentAlignment.MiddleLeft;
            TrainerLabel.Click += Workout_Click;
            // 
            // RoomLabel
            // 
            RoomLabel.AutoSize = true;
            RoomLabel.Dock = DockStyle.Fill;
            RoomLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RoomLabel.ForeColor = Color.FromArgb(153, 153, 153);
            RoomLabel.Location = new Point(3, 146);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new Size(1, 1);
            RoomLabel.TabIndex = 5;
            RoomLabel.Text = "Зал 1";
            RoomLabel.TextAlign = ContentAlignment.MiddleLeft;
            RoomLabel.Click += Workout_Click;
            // 
            // IsDeleteLabel
            // 
            IsDeleteLabel.AutoSize = true;
            IsDeleteLabel.Dock = DockStyle.Fill;
            IsDeleteLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            IsDeleteLabel.ForeColor = Color.Red;
            IsDeleteLabel.Location = new Point(3, 146);
            IsDeleteLabel.Name = "IsDeleteLabel";
            IsDeleteLabel.Size = new Size(1, 1);
            IsDeleteLabel.TabIndex = 6;
            IsDeleteLabel.Text = "Отменено";
            IsDeleteLabel.TextAlign = ContentAlignment.MiddleCenter;
            IsDeleteLabel.Visible = false;
            // 
            // WorkoutUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(0, 150);
            Name = "WorkoutUserControl";
            Padding = new Padding(2);
            Size = new Size(0, 150);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label TimeFromToLabel;
        private Label TimeLabel;
        private Label NameLabel;
        private Label TypeLabel;
        private Label TrainerLabel;
        private Label RoomLabel;
        private Label IsDeleteLabel;
    }
}
