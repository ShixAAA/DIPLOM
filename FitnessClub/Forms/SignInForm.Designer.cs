namespace FitnessClub.Forms
{
    partial class SignInForm
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
            label1 = new Label();
            label2 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label3 = new Label();
            SignInButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(LoginTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(SignInButton, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(384, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 39);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(45, 71);
            label2.Name = "label2";
            label2.Size = new Size(294, 21);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Dock = DockStyle.Fill;
            LoginTextBox.Location = new Point(45, 95);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(294, 29);
            LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Dock = DockStyle.Fill;
            PasswordTextBox.Location = new Point(45, 151);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(294, 29);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(45, 127);
            label3.Name = "label3";
            label3.Size = new Size(294, 21);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.Top;
            SignInButton.BackColor = Color.FromArgb(73, 40, 112);
            SignInButton.FlatAppearance.BorderSize = 0;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(151, 186);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(82, 32);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Войти";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 261);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FitnessClub";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox LoginTextBox;
        private Label label3;
        private Button SignInButton;
        private TextBox PasswordTextBox;
    }
}