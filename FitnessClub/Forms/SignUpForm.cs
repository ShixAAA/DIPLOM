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
    public partial class SignUpForm : Form
    {
        private string? photoPath = null;

        public SignUpForm()
        {
            InitializeComponent();
            BirthdateDateTime.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string secondName = SecondNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string patronymic = PatronymicTextBox.Text;
            DateTime birthdate = BirthdateDateTime.Value;
            string phone = PhoneMaskedBox.Text;
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(secondName))
            {
                MessageBox.Show("Заполните фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Заполните имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Заполните отчество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Заполните телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phone.Length != 10)
            {
                MessageBox.Show("Телефон должен состоять из 10 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (FitnessClubDbContext.DbContext.Users.FirstOrDefault(u => u.Login == login) != null)
            {
                MessageBox.Show("Данный логин уже используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(photoPath))
            {
                MessageBox.Show("Загрузите фотографию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();
                user.SecondName = secondName;
                user.FirstName = firstName;
                user.Patronymic = patronymic;
                user.Birthdate = birthdate;
                user.Phone = phone;
                user.Login = login;
                user.Password = password;
                user.Role = FitnessClubDbContext.DbContext.Roles.First(r => r.RoleId == 3);
                Client client = new Client();
                string fileName = $@"{Path.GetRandomFileName().Replace('.', '_')}.jpg";
                File.Copy(photoPath, $@"{AppDomain.CurrentDomain.BaseDirectory}\Photos\Trainers\{fileName}", true);
                client.Photo = fileName;
                client.User = user;
                user.Client = client;
                FitnessClubDbContext.DbContext.Clients.Add(client);
                FitnessClubDbContext.DbContext.SaveChanges();
                MessageBox.Show("Регистрация пройдена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Все изображения|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            fileDialog.Title = "Выберите изображение";
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = fileDialog.FileName;
                PhotoPictureBox.Image = LoadImageFromFile(photoPath);
            }
        }

        private Image LoadImageFromFile(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    return Image.FromStream(memoryStream);
                }
            }
        }
    }
}
