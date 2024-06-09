namespace FitnessClub.Forms
{
    partial class AddChangeWorkoutForm
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
            HeaderLabel = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            label3 = new Label();
            AddButton = new Button();
            label4 = new Label();
            label5 = new Label();
            DateWorkoutDatePicker = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            WorkoutTypeComboBox = new ComboBox();
            RoomComboBox = new ComboBox();
            TimeStartTimePicker = new DateTimePicker();
            TimeEndTimePicker = new DateTimePicker();
            TrainerComboBox = new ComboBox();
            label1 = new Label();
            DescriptionTextBox = new TextBox();
            label10 = new Label();
            NumberSeatsNumeric = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSeatsNumeric).BeginInit();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Dock = DockStyle.Fill;
            HeaderLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.Location = new Point(40, 28);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(344, 32);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Добавление тренировки";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(40, 60);
            label2.Name = "label2";
            label2.Size = new Size(344, 21);
            label2.TabIndex = 1;
            label2.Text = "Наименование";
            // 
            // NameTextBox
            // 
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Location = new Point(40, 84);
            NameTextBox.MaxLength = 30;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(344, 29);
            NameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(40, 116);
            label3.Name = "label3";
            label3.Size = new Size(344, 21);
            label3.TabIndex = 4;
            label3.Text = "Тип тренировки";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.BackColor = Color.FromArgb(73, 40, 112);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(104, 567);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(216, 32);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить тренировку";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(40, 175);
            label4.Name = "label4";
            label4.Size = new Size(344, 21);
            label4.TabIndex = 6;
            label4.Text = "Помещение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(40, 234);
            label5.Name = "label5";
            label5.Size = new Size(344, 21);
            label5.TabIndex = 8;
            label5.Text = "Дата тренировки";
            // 
            // DateWorkoutDatePicker
            // 
            DateWorkoutDatePicker.Dock = DockStyle.Fill;
            DateWorkoutDatePicker.Format = DateTimePickerFormat.Short;
            DateWorkoutDatePicker.Location = new Point(40, 258);
            DateWorkoutDatePicker.Name = "DateWorkoutDatePicker";
            DateWorkoutDatePicker.Size = new Size(344, 29);
            DateWorkoutDatePicker.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(40, 346);
            label7.Name = "label7";
            label7.Size = new Size(344, 21);
            label7.TabIndex = 12;
            label7.Text = "Время конца";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(40, 402);
            label8.Name = "label8";
            label8.Size = new Size(344, 21);
            label8.TabIndex = 13;
            label8.Text = "Тренер";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(40, 290);
            label6.Name = "label6";
            label6.Size = new Size(344, 21);
            label6.TabIndex = 10;
            label6.Text = "Время начала";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(HeaderLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(AddButton, 1, 21);
            tableLayoutPanel1.Controls.Add(label4, 1, 7);
            tableLayoutPanel1.Controls.Add(label5, 1, 9);
            tableLayoutPanel1.Controls.Add(DateWorkoutDatePicker, 1, 10);
            tableLayoutPanel1.Controls.Add(label6, 1, 11);
            tableLayoutPanel1.Controls.Add(label7, 1, 13);
            tableLayoutPanel1.Controls.Add(label8, 1, 15);
            tableLayoutPanel1.Controls.Add(WorkoutTypeComboBox, 1, 5);
            tableLayoutPanel1.Controls.Add(RoomComboBox, 1, 8);
            tableLayoutPanel1.Controls.Add(TimeStartTimePicker, 1, 12);
            tableLayoutPanel1.Controls.Add(TimeEndTimePicker, 1, 14);
            tableLayoutPanel1.Controls.Add(TrainerComboBox, 1, 16);
            tableLayoutPanel1.Controls.Add(label1, 1, 17);
            tableLayoutPanel1.Controls.Add(DescriptionTextBox, 1, 18);
            tableLayoutPanel1.Controls.Add(label10, 1, 19);
            tableLayoutPanel1.Controls.Add(NumberSeatsNumeric, 1, 20);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 23;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
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
            tableLayoutPanel1.Size = new Size(424, 631);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // WorkoutTypeComboBox
            // 
            WorkoutTypeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            WorkoutTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            WorkoutTypeComboBox.DisplayMember = "Name";
            WorkoutTypeComboBox.Dock = DockStyle.Fill;
            WorkoutTypeComboBox.FormattingEnabled = true;
            WorkoutTypeComboBox.Location = new Point(40, 140);
            WorkoutTypeComboBox.Name = "WorkoutTypeComboBox";
            WorkoutTypeComboBox.Size = new Size(344, 29);
            WorkoutTypeComboBox.TabIndex = 17;
            // 
            // RoomComboBox
            // 
            RoomComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RoomComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            RoomComboBox.DisplayMember = "Name";
            RoomComboBox.Dock = DockStyle.Fill;
            RoomComboBox.FormattingEnabled = true;
            RoomComboBox.Location = new Point(40, 199);
            RoomComboBox.Name = "RoomComboBox";
            RoomComboBox.Size = new Size(344, 29);
            RoomComboBox.TabIndex = 18;
            // 
            // TimeStartTimePicker
            // 
            TimeStartTimePicker.CustomFormat = "HH:mm";
            TimeStartTimePicker.Dock = DockStyle.Fill;
            TimeStartTimePicker.Format = DateTimePickerFormat.Custom;
            TimeStartTimePicker.Location = new Point(40, 314);
            TimeStartTimePicker.Name = "TimeStartTimePicker";
            TimeStartTimePicker.ShowUpDown = true;
            TimeStartTimePicker.Size = new Size(344, 29);
            TimeStartTimePicker.TabIndex = 19;
            // 
            // TimeEndTimePicker
            // 
            TimeEndTimePicker.CustomFormat = "HH:mm";
            TimeEndTimePicker.Dock = DockStyle.Fill;
            TimeEndTimePicker.Format = DateTimePickerFormat.Custom;
            TimeEndTimePicker.Location = new Point(40, 370);
            TimeEndTimePicker.Name = "TimeEndTimePicker";
            TimeEndTimePicker.ShowUpDown = true;
            TimeEndTimePicker.Size = new Size(344, 29);
            TimeEndTimePicker.TabIndex = 20;
            // 
            // TrainerComboBox
            // 
            TrainerComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TrainerComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            TrainerComboBox.DisplayMember = "FullName";
            TrainerComboBox.Dock = DockStyle.Fill;
            TrainerComboBox.FormattingEnabled = true;
            TrainerComboBox.Location = new Point(40, 426);
            TrainerComboBox.Name = "TrainerComboBox";
            TrainerComboBox.Size = new Size(344, 29);
            TrainerComboBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(40, 452);
            label1.Name = "label1";
            label1.Size = new Size(344, 21);
            label1.TabIndex = 22;
            label1.Text = "Описание";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Dock = DockStyle.Fill;
            DescriptionTextBox.Location = new Point(40, 476);
            DescriptionTextBox.MaxLength = 300;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(344, 29);
            DescriptionTextBox.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(40, 508);
            label10.Name = "label10";
            label10.Size = new Size(344, 21);
            label10.TabIndex = 24;
            label10.Text = "Количество мест";
            // 
            // NumberSeatsNumeric
            // 
            NumberSeatsNumeric.Dock = DockStyle.Fill;
            NumberSeatsNumeric.Location = new Point(40, 532);
            NumberSeatsNumeric.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberSeatsNumeric.Name = "NumberSeatsNumeric";
            NumberSeatsNumeric.Size = new Size(344, 29);
            NumberSeatsNumeric.TabIndex = 25;
            // 
            // AddChangeWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 631);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddChangeWorkoutForm";
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberSeatsNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label HeaderLabel;
        private Label label2;
        private TextBox NameTextBox;
        private Label label3;
        private Button AddButton;
        private Label label4;
        private Label label5;
        private DateTimePicker DateWorkoutDatePicker;
        private Label label7;
        private Label label8;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox WorkoutTypeComboBox;
        private ComboBox RoomComboBox;
        private DateTimePicker TimeStartTimePicker;
        private DateTimePicker TimeEndTimePicker;
        private ComboBox TrainerComboBox;
        private Label label1;
        private TextBox DescriptionTextBox;
        private Label label10;
        private NumericUpDown NumberSeatsNumeric;
    }
}