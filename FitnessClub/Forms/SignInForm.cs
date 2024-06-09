using FitnessClub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Forms
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User? user = FitnessClubDbContext.DbContext.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user.RoleId == 1)
                {
                    User.SignedUser = user;
                    AdministratorForm administratorForm = new AdministratorForm();
                    administratorForm.Show();
                    DialogResult = DialogResult.OK;
                }
                else if (user.RoleId == 2)
                {
                    User.SignedUser = user;
                    TrainerForm trainerForm = new TrainerForm();
                    trainerForm.Show();
                    DialogResult = DialogResult.OK;
                }
                else if (user.RoleId == 3)
                {
                    User.SignedUser = user;
                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Неудалось найти роль пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
