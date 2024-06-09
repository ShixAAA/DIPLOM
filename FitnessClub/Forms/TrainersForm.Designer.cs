namespace FitnessClub.Forms
{
    partial class TrainersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainersForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            SortComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            TrainersDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            DeleteButton = new Button();
            ChangeButton = new Button();
            AddButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainersDataGridView).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(TrainersDataGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(884, 411);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 86);
            label1.Name = "label1";
            label1.Size = new Size(878, 30);
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
            tableLayoutPanel2.Size = new Size(878, 35);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 35);
            label2.TabIndex = 0;
            label2.Text = "Поиск";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(421, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 35);
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
            SortComboBox.Location = new Point(523, 3);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(352, 29);
            SortComboBox.TabIndex = 3;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Location = new Point(63, 3);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(352, 29);
            SearchTextBox.TabIndex = 4;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
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
            TrainersDataGridView.Size = new Size(878, 204);
            TrainersDataGridView.TabIndex = 3;
            TrainersDataGridView.SelectionChanged += TrainersDataGridView_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SecondName";
            Column1.HeaderText = "Фамилия";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FirstName";
            Column2.HeaderText = "Имя";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Patronymic";
            Column3.HeaderText = "Отчество";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Birthdate";
            Column4.FillWeight = 80F;
            Column4.HeaderText = "Дата рождения";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PhoneFormat";
            Column5.HeaderText = "Телефон";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "WorkStartDate";
            Column7.FillWeight = 80F;
            Column7.HeaderText = "Дата начала работы";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "OnTraining";
            Column6.FillWeight = 80F;
            Column6.HeaderText = "На тренеровке";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
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
            tableLayoutPanel3.Location = new Point(3, 370);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(878, 38);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top;
            DeleteButton.BackColor = Color.FromArgb(73, 40, 112);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(643, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(175, 32);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить тренера";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Anchor = AnchorStyles.Top;
            ChangeButton.BackColor = Color.FromArgb(73, 40, 112);
            ChangeButton.FlatAppearance.BorderSize = 0;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeButton.ForeColor = Color.White;
            ChangeButton.Location = new Point(350, 3);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(175, 32);
            ChangeButton.TabIndex = 6;
            ChangeButton.Text = "Изменить тренера";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.BackColor = Color.FromArgb(73, 40, 112);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(58, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(175, 32);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить тренера";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // TrainersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 411);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(600, 400);
            Name = "TrainersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrainersDataGridView).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView TrainersDataGridView;
        private Label label2;
        private Label label3;
        private ComboBox SortComboBox;
        private TextBox SearchTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ChangeButton;
        private Button AddButton;
        private Button DeleteButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
    }
}