namespace FitnessClub.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            TypeScheduleComboBox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            WeekTablePanel = new TableLayoutPanel();
            MondayLabel = new Label();
            TuesdayLabel = new Label();
            WednesdayLabel = new Label();
            ThursdayLabel = new Label();
            FridayLabel = new Label();
            SaturdayLabel = new Label();
            SundayLabel = new Label();
            PreviousWeekButton = new Button();
            NextWeekButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            SignOutButton = new Button();
            pictureBox1 = new PictureBox();
            WelcomeLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            TrainerFilterComboBox = new ComboBox();
            label3 = new Label();
            WorkoutTypeFilterComboBox = new ComboBox();
            label2 = new Label();
            RoomFilterComboBox = new ComboBox();
            label1 = new Label();
            HeaderLabel = new Label();
            ScheduleTablePanel = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            WeekTablePanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(TypeScheduleComboBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 95);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1278, 35);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 35);
            label5.TabIndex = 0;
            label5.Text = "Тип расписания";
            // 
            // TypeScheduleComboBox
            // 
            TypeScheduleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeScheduleComboBox.FormattingEnabled = true;
            TypeScheduleComboBox.Items.AddRange(new object[] { "Общее расписание", "Мое расписаниие" });
            TypeScheduleComboBox.Location = new Point(132, 3);
            TypeScheduleComboBox.Name = "TypeScheduleComboBox";
            TypeScheduleComboBox.Size = new Size(200, 29);
            TypeScheduleComboBox.TabIndex = 1;
            TypeScheduleComboBox.SelectedIndexChanged += TypeScheduleComboBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(WeekTablePanel, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(HeaderLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(ScheduleTablePanel, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1284, 761);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // WeekTablePanel
            // 
            WeekTablePanel.AutoSize = true;
            WeekTablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            WeekTablePanel.ColumnCount = 9;
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            WeekTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            WeekTablePanel.Controls.Add(MondayLabel, 1, 0);
            WeekTablePanel.Controls.Add(TuesdayLabel, 2, 0);
            WeekTablePanel.Controls.Add(WednesdayLabel, 3, 0);
            WeekTablePanel.Controls.Add(ThursdayLabel, 4, 0);
            WeekTablePanel.Controls.Add(FridayLabel, 5, 0);
            WeekTablePanel.Controls.Add(SaturdayLabel, 6, 0);
            WeekTablePanel.Controls.Add(SundayLabel, 7, 0);
            WeekTablePanel.Controls.Add(PreviousWeekButton, 0, 0);
            WeekTablePanel.Controls.Add(NextWeekButton, 8, 0);
            WeekTablePanel.Dock = DockStyle.Fill;
            WeekTablePanel.Location = new Point(3, 207);
            WeekTablePanel.Name = "WeekTablePanel";
            WeekTablePanel.RowCount = 1;
            WeekTablePanel.RowStyles.Add(new RowStyle());
            WeekTablePanel.Size = new Size(1278, 48);
            WeekTablePanel.TabIndex = 0;
            // 
            // MondayLabel
            // 
            MondayLabel.AutoSize = true;
            MondayLabel.Dock = DockStyle.Fill;
            MondayLabel.Location = new Point(63, 1);
            MondayLabel.Name = "MondayLabel";
            MondayLabel.Size = new Size(158, 46);
            MondayLabel.TabIndex = 0;
            MondayLabel.Tag = "UnDelete";
            MondayLabel.Text = "ПН";
            MondayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TuesdayLabel
            // 
            TuesdayLabel.AutoSize = true;
            TuesdayLabel.Dock = DockStyle.Fill;
            TuesdayLabel.Location = new Point(228, 1);
            TuesdayLabel.Name = "TuesdayLabel";
            TuesdayLabel.Size = new Size(158, 46);
            TuesdayLabel.TabIndex = 1;
            TuesdayLabel.Tag = "UnDelete";
            TuesdayLabel.Text = "ВТ";
            TuesdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WednesdayLabel
            // 
            WednesdayLabel.AutoSize = true;
            WednesdayLabel.Dock = DockStyle.Fill;
            WednesdayLabel.Location = new Point(393, 1);
            WednesdayLabel.Name = "WednesdayLabel";
            WednesdayLabel.Size = new Size(158, 46);
            WednesdayLabel.TabIndex = 2;
            WednesdayLabel.Tag = "UnDelete";
            WednesdayLabel.Text = "СР";
            WednesdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThursdayLabel
            // 
            ThursdayLabel.AutoSize = true;
            ThursdayLabel.Dock = DockStyle.Fill;
            ThursdayLabel.Location = new Point(558, 1);
            ThursdayLabel.Name = "ThursdayLabel";
            ThursdayLabel.Size = new Size(158, 46);
            ThursdayLabel.TabIndex = 3;
            ThursdayLabel.Tag = "UnDelete";
            ThursdayLabel.Text = "ЧТ";
            ThursdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FridayLabel
            // 
            FridayLabel.AutoSize = true;
            FridayLabel.Dock = DockStyle.Fill;
            FridayLabel.Location = new Point(723, 1);
            FridayLabel.Name = "FridayLabel";
            FridayLabel.Size = new Size(158, 46);
            FridayLabel.TabIndex = 4;
            FridayLabel.Tag = "UnDelete";
            FridayLabel.Text = "ПТ";
            FridayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaturdayLabel
            // 
            SaturdayLabel.AutoSize = true;
            SaturdayLabel.Dock = DockStyle.Fill;
            SaturdayLabel.Location = new Point(888, 1);
            SaturdayLabel.Name = "SaturdayLabel";
            SaturdayLabel.Size = new Size(158, 46);
            SaturdayLabel.TabIndex = 5;
            SaturdayLabel.Tag = "UnDelete";
            SaturdayLabel.Text = "СБ";
            SaturdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SundayLabel
            // 
            SundayLabel.AutoSize = true;
            SundayLabel.Dock = DockStyle.Fill;
            SundayLabel.Location = new Point(1053, 1);
            SundayLabel.Name = "SundayLabel";
            SundayLabel.Size = new Size(158, 46);
            SundayLabel.TabIndex = 6;
            SundayLabel.Tag = "UnDelete";
            SundayLabel.Text = "ВС";
            SundayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PreviousWeekButton
            // 
            PreviousWeekButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PreviousWeekButton.BackColor = Color.FromArgb(73, 40, 112);
            PreviousWeekButton.Enabled = false;
            PreviousWeekButton.FlatAppearance.BorderSize = 0;
            PreviousWeekButton.FlatStyle = FlatStyle.Flat;
            PreviousWeekButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PreviousWeekButton.ForeColor = Color.White;
            PreviousWeekButton.Location = new Point(4, 4);
            PreviousWeekButton.Name = "PreviousWeekButton";
            PreviousWeekButton.Size = new Size(52, 40);
            PreviousWeekButton.TabIndex = 7;
            PreviousWeekButton.Tag = "UnDelete";
            PreviousWeekButton.Text = "🡰";
            PreviousWeekButton.UseVisualStyleBackColor = false;
            PreviousWeekButton.Click += PreviousWeekButton_Click;
            // 
            // NextWeekButton
            // 
            NextWeekButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NextWeekButton.BackColor = Color.FromArgb(73, 40, 112);
            NextWeekButton.FlatAppearance.BorderSize = 0;
            NextWeekButton.FlatStyle = FlatStyle.Flat;
            NextWeekButton.ForeColor = Color.White;
            NextWeekButton.Location = new Point(1218, 4);
            NextWeekButton.Name = "NextWeekButton";
            NextWeekButton.Size = new Size(56, 40);
            NextWeekButton.TabIndex = 8;
            NextWeekButton.Tag = "UnDelete";
            NextWeekButton.Text = "🡲";
            NextWeekButton.UseVisualStyleBackColor = false;
            NextWeekButton.Click += NextWeekButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(SignOutButton, 2, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(WelcomeLabel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1278, 86);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // SignOutButton
            // 
            SignOutButton.Anchor = AnchorStyles.Right;
            SignOutButton.BackColor = Color.FromArgb(73, 40, 112);
            SignOutButton.FlatAppearance.BorderSize = 0;
            SignOutButton.FlatStyle = FlatStyle.Flat;
            SignOutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignOutButton.ForeColor = Color.White;
            SignOutButton.Image = Properties.Resources.icons8_выход_50__1_;
            SignOutButton.Location = new Point(1192, 4);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(83, 78);
            SignOutButton.TabIndex = 5;
            SignOutButton.UseVisualStyleBackColor = false;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FirnessClubLogo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Dock = DockStyle.Fill;
            WelcomeLabel.Location = new Point(89, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(1097, 86);
            WelcomeLabel.TabIndex = 6;
            WelcomeLabel.Text = "Добро пожаловать";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 7;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(TrainerFilterComboBox, 6, 0);
            tableLayoutPanel4.Controls.Add(label3, 5, 0);
            tableLayoutPanel4.Controls.Add(WorkoutTypeFilterComboBox, 4, 0);
            tableLayoutPanel4.Controls.Add(label2, 3, 0);
            tableLayoutPanel4.Controls.Add(RoomFilterComboBox, 2, 0);
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 166);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1278, 35);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // TrainerFilterComboBox
            // 
            TrainerFilterComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TrainerFilterComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            TrainerFilterComboBox.DisplayMember = "FullName";
            TrainerFilterComboBox.Dock = DockStyle.Fill;
            TrainerFilterComboBox.FormattingEnabled = true;
            TrainerFilterComboBox.Location = new Point(956, 3);
            TrainerFilterComboBox.Name = "TrainerFilterComboBox";
            TrainerFilterComboBox.Size = new Size(319, 29);
            TrainerFilterComboBox.TabIndex = 3;
            TrainerFilterComboBox.SelectedIndexChanged += TrainerFilterComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(889, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 35);
            label3.TabIndex = 5;
            label3.Text = "Тренер";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WorkoutTypeFilterComboBox
            // 
            WorkoutTypeFilterComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            WorkoutTypeFilterComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            WorkoutTypeFilterComboBox.DisplayMember = "Name";
            WorkoutTypeFilterComboBox.Dock = DockStyle.Fill;
            WorkoutTypeFilterComboBox.FormattingEnabled = true;
            WorkoutTypeFilterComboBox.Location = new Point(567, 3);
            WorkoutTypeFilterComboBox.Name = "WorkoutTypeFilterComboBox";
            WorkoutTypeFilterComboBox.Size = new Size(316, 29);
            WorkoutTypeFilterComboBox.TabIndex = 2;
            WorkoutTypeFilterComboBox.SelectedIndexChanged += WorkoutTypeFilterComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(427, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 35);
            label2.TabIndex = 4;
            label2.Text = "Тип тренировкии";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoomFilterComboBox
            // 
            RoomFilterComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RoomFilterComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            RoomFilterComboBox.DisplayMember = "Name";
            RoomFilterComboBox.Dock = DockStyle.Fill;
            RoomFilterComboBox.FormattingEnabled = true;
            RoomFilterComboBox.Location = new Point(105, 3);
            RoomFilterComboBox.Name = "RoomFilterComboBox";
            RoomFilterComboBox.Size = new Size(316, 29);
            RoomFilterComboBox.TabIndex = 1;
            RoomFilterComboBox.SelectedIndexChanged += RoomFilterComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "Помещение";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Dock = DockStyle.Fill;
            HeaderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.Location = new Point(3, 133);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(1278, 30);
            HeaderLabel.TabIndex = 3;
            HeaderLabel.Text = "Общее расписание";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScheduleTablePanel
            // 
            ScheduleTablePanel.AutoScroll = true;
            ScheduleTablePanel.AutoSize = true;
            ScheduleTablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ScheduleTablePanel.ColumnCount = 9;
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285306F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285306F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285306F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285306F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285306F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853088F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881632F));
            ScheduleTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            ScheduleTablePanel.Dock = DockStyle.Fill;
            ScheduleTablePanel.Location = new Point(3, 261);
            ScheduleTablePanel.Name = "ScheduleTablePanel";
            ScheduleTablePanel.RowCount = 1;
            ScheduleTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ScheduleTablePanel.Size = new Size(1278, 497);
            ScheduleTablePanel.TabIndex = 4;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 761);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 500);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            FormClosed += ClientForm_FormClosed;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            WeekTablePanel.ResumeLayout(false);
            WeekTablePanel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel WeekTablePanel;
        private Label MondayLabel;
        private Label TuesdayLabel;
        private Label WednesdayLabel;
        private Label ThursdayLabel;
        private Label FridayLabel;
        private Label SaturdayLabel;
        private Label SundayLabel;
        private Button PreviousWeekButton;
        private Button NextWeekButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button SignOutButton;
        private PictureBox pictureBox1;
        private Label WelcomeLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox TrainerFilterComboBox;
        private Label label3;
        private ComboBox WorkoutTypeFilterComboBox;
        private Label label2;
        private ComboBox RoomFilterComboBox;
        private Label label1;
        private Label HeaderLabel;
        private TableLayoutPanel ScheduleTablePanel;
        private Label label5;
        private ComboBox TypeScheduleComboBox;
    }
}