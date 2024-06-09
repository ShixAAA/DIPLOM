namespace FitnessClub.Forms
{
    partial class WorkoutEditForm
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
            DeleteButton = new Button();
            ClientsButton = new Button();
            ChangeButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(HeaderLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(DeleteButton, 2, 2);
            tableLayoutPanel1.Controls.Add(ClientsButton, 3, 2);
            tableLayoutPanel1.Controls.Add(ChangeButton, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.Size = new Size(654, 121);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(HeaderLabel, 3);
            HeaderLabel.Dock = DockStyle.Fill;
            HeaderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.Location = new Point(34, 26);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(585, 30);
            HeaderLabel.TabIndex = 9;
            HeaderLabel.Text = "Тренировка";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top;
            DeleteButton.BackColor = Color.FromArgb(73, 40, 112);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(233, 59);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(175, 32);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Удалить тренировку";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClientsButton
            // 
            ClientsButton.Anchor = AnchorStyles.Top;
            ClientsButton.BackColor = Color.FromArgb(73, 40, 112);
            ClientsButton.FlatAppearance.BorderSize = 0;
            ClientsButton.FlatStyle = FlatStyle.Flat;
            ClientsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientsButton.ForeColor = Color.White;
            ClientsButton.Location = new Point(414, 59);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(205, 32);
            ClientsButton.TabIndex = 10;
            ClientsButton.Text = "Записанные клиенты";
            ClientsButton.UseVisualStyleBackColor = false;
            ClientsButton.Click += ClientsButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Anchor = AnchorStyles.Top;
            ChangeButton.BackColor = Color.FromArgb(73, 40, 112);
            ChangeButton.FlatAppearance.BorderSize = 0;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeButton.ForeColor = Color.White;
            ChangeButton.Location = new Point(34, 59);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(193, 32);
            ChangeButton.TabIndex = 7;
            ChangeButton.Text = "Изменить тренировку";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // WorkoutEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 121);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WorkoutEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button ChangeButton;
        private Label HeaderLabel;
        private Button DeleteButton;
        private Button ClientsButton;
    }
}