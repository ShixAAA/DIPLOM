namespace FitnessClub.Forms
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            DeleteButton = new Button();
            AddButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            ChangeButton = new Button();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            TrainersDataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            SortComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            WelcomeLabel = new Label();
            TrainerFilterComboBox = new ComboBox();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            WorkoutTypeFilterComboBox = new ComboBox();
            label5 = new Label();
            RoomFilterComboBox = new ComboBox();
            label6 = new Label();
            MondayLabel = new Label();
            TuesdayLabel = new Label();
            WednesdayLabel = new Label();
            ThursdayLabel = new Label();
            FridayLabel = new Label();
            SaturdayLabel = new Label();
            SundayLabel = new Label();
            PreviousWeekButton = new Button();
            ScheduleTablePanel = new TableLayoutPanel();
            NextWeekButton = new Button();
            SignOutButton = new Button();
            WeekTablePanel = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            HeaderLabel = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label7 = new Label();
            TypeScheduleComboBox = new ComboBox();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            WeekTablePanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top;
            DeleteButton.BackColor = Color.FromArgb(214, 25, 5);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(131, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(60, 32);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить тренера";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.BackColor = Color.FromArgb(16, 162, 27);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(58, 32);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить тренера";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(DeleteButton, 0, 0);
            tableLayoutPanel3.Controls.Add(ChangeButton, 0, 0);
            tableLayoutPanel3.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 320);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(194, 38);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // ChangeButton
            // 
            ChangeButton.Anchor = AnchorStyles.Top;
            ChangeButton.BackColor = Color.FromArgb(222, 222, 222);
            ChangeButton.FlatAppearance.BorderSize = 0;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeButton.ForeColor = Color.White;
            ChangeButton.Location = new Point(67, 3);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(58, 32);
            ChangeButton.TabIndex = 6;
            ChangeButton.Text = "Изменить тренера";
            ChangeButton.UseVisualStyleBackColor = false;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "OnTraining";
            Column6.FillWeight = 80F;
            Column6.HeaderText = "На тренеровке";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "WorkStartDate";
            Column7.FillWeight = 80F;
            Column7.HeaderText = "Дата начала работы";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PhoneFormat";
            Column5.HeaderText = "Телефон";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Birthdate";
            Column4.FillWeight = 80F;
            Column4.HeaderText = "Дата рождения";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Patronymic";
            Column3.HeaderText = "Отчество";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FirstName";
            Column2.HeaderText = "Имя";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SecondName";
            Column1.HeaderText = "Фамилия";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // TrainersDataGridView
            // 
            TrainersDataGridView.AllowUserToAddRows = false;
            TrainersDataGridView.AllowUserToDeleteRows = false;
            TrainersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TrainersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TrainersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column6 });
            TrainersDataGridView.Dock = DockStyle.Fill;
            TrainersDataGridView.Location = new Point(3, 160);
            TrainersDataGridView.MultiSelect = false;
            TrainersDataGridView.Name = "TrainersDataGridView";
            TrainersDataGridView.ReadOnly = true;
            TrainersDataGridView.RowHeadersVisible = false;
            TrainersDataGridView.RowTemplate.Height = 25;
            TrainersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TrainersDataGridView.Size = new Size(194, 154);
            TrainersDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 35);
            label2.TabIndex = 0;
            label2.Text = "Поиск";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(84, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 35);
            label3.TabIndex = 2;
            label3.Text = "Сортировка";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SortComboBox
            // 
            SortComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SortComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SortComboBox.Dock = DockStyle.Fill;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Location = new Point(163, 3);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(28, 23);
            SortComboBox.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Location = new Point(51, 3);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(27, 23);
            SearchTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(194, 80);
            label1.TabIndex = 0;
            label1.Text = "Тренера";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FirnessClubLogo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(SortComboBox, 3, 0);
            tableLayoutPanel2.Controls.Add(SearchTextBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 119);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(194, 35);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(889, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 35);
            label4.TabIndex = 5;
            label4.Text = "Тренер";
            label4.TextAlign = ContentAlignment.MiddleLeft;
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
            tableLayoutPanel4.Controls.Add(label4, 5, 0);
            tableLayoutPanel4.Controls.Add(WorkoutTypeFilterComboBox, 4, 0);
            tableLayoutPanel4.Controls.Add(label5, 3, 0);
            tableLayoutPanel4.Controls.Add(RoomFilterComboBox, 2, 0);
            tableLayoutPanel4.Controls.Add(label6, 1, 0);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(427, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 35);
            label5.TabIndex = 4;
            label5.Text = "Тип тренировкии";
            label5.TextAlign = ContentAlignment.MiddleLeft;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 35);
            label6.TabIndex = 0;
            label6.Text = "Помещение";
            label6.TextAlign = ContentAlignment.MiddleLeft;
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
            // SignOutButton
            // 
            SignOutButton.Anchor = AnchorStyles.Right;
            SignOutButton.BackColor = Color.FromArgb(73, 40, 112);
            SignOutButton.FlatAppearance.BorderSize = 0;
            SignOutButton.FlatStyle = FlatStyle.Flat;
            SignOutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignOutButton.ForeColor = Color.Black;
            SignOutButton.Image = Properties.Resources.icons8_выход_50__1_;
            SignOutButton.Location = new Point(1192, 4);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(83, 78);
            SignOutButton.TabIndex = 5;
            SignOutButton.UseVisualStyleBackColor = false;
            SignOutButton.Click += SignOutButton_Click;
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
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(SignOutButton, 2, 0);
            tableLayoutPanel5.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel5.Controls.Add(WelcomeLabel, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1278, 86);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.FirnessClubLogo;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(WeekTablePanel, 0, 4);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel6.Controls.Add(HeaderLabel, 0, 2);
            tableLayoutPanel6.Controls.Add(ScheduleTablePanel, 0, 5);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 6;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1284, 761);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(label7, 0, 0);
            tableLayoutPanel7.Controls.Add(TypeScheduleComboBox, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 95);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1278, 35);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 35);
            label7.TabIndex = 0;
            label7.Text = "Тип расписания";
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
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 761);
            Controls.Add(tableLayoutPanel6);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1000, 500);
            Name = "TrainerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TrainersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            WeekTablePanel.ResumeLayout(false);
            WeekTablePanel.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteButton;
        private Button AddButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ChangeButton;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView TrainersDataGridView;
        private Label label2;
        private Label label3;
        private ComboBox SortComboBox;
        private TextBox SearchTextBox;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label WelcomeLabel;
        private ComboBox TrainerFilterComboBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox WorkoutTypeFilterComboBox;
        private Label label5;
        private ComboBox RoomFilterComboBox;
        private Label label6;
        private Label MondayLabel;
        private Label TuesdayLabel;
        private Label WednesdayLabel;
        private Label ThursdayLabel;
        private Label FridayLabel;
        private Label SaturdayLabel;
        private Label SundayLabel;
        private Button PreviousWeekButton;
        private TableLayoutPanel ScheduleTablePanel;
        private Button NextWeekButton;
        private Button SignOutButton;
        private TableLayoutPanel WeekTablePanel;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox2;
        private Label HeaderLabel;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label7;
        private ComboBox TypeScheduleComboBox;
    }
}