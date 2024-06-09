namespace FitnessClub.Forms
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            ClientsDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            SortComboBox = new ComboBox();
            SearchTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ClientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            ClientsDataGridView.AllowUserToAddRows = false;
            ClientsDataGridView.AllowUserToDeleteRows = false;
            ClientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            ClientsDataGridView.Dock = DockStyle.Fill;
            ClientsDataGridView.Location = new Point(3, 160);
            ClientsDataGridView.MultiSelect = false;
            ClientsDataGridView.Name = "ClientsDataGridView";
            ClientsDataGridView.ReadOnly = true;
            ClientsDataGridView.RowHeadersVisible = false;
            ClientsDataGridView.RowTemplate.Height = 25;
            ClientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientsDataGridView.Size = new Size(878, 248);
            ClientsDataGridView.TabIndex = 3;
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
            // Column6
            // 
            Column6.DataPropertyName = "OnTraining";
            Column6.FillWeight = 80F;
            Column6.HeaderText = "На тренеровке";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 86);
            label1.Name = "label1";
            label1.Size = new Size(878, 30);
            label1.TabIndex = 0;
            label1.Text = "Клиенты";
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(ClientsDataGridView, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(884, 411);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ClientsForm
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
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            ((System.ComponentModel.ISupportInitialize)ClientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ClientsDataGridView;
        private Label label2;
        private Label label3;
        private ComboBox SortComboBox;
        private TextBox SearchTextBox;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}