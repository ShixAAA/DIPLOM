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
    public partial class AddChangeTrainer : Form
    {
        private Trainer? trainer;
        private string? photoPath = null;

        public AddChangeTrainer(Trainer? trainer = null)
        {
            InitializeComponent();
            this.trainer = trainer;
            BirthdateDateTime.MaxDate = DateTime.Today.AddYears(-18);
            if (trainer == null)
            {
                HeaderLabel.Text = "Добавление тренера";
                AddButton.Text = "Добавить тренера";
            }
            else
            {
                HeaderLabel.Text = "Изменение тренера";
                AddButton.Text = "Изменить тренера";
                LoginTextBox.Enabled = false;
                PasswordTextBox.Enabled = false;
                SecondNameTextBox.Text = trainer.SecondName;
                FirstNameTextBox.Text = trainer.FirstName;
                PatronymicTextBox.Text = trainer.Patronymic;
                BirthdateDateTime.Value = trainer.Birthdate;
                PhoneMaskedBox.Text = trainer.User.Phone;
                LoginTextBox.Text = trainer.User.Login;
                PasswordTextBox.Text = trainer.User.Password;
                PhotoPictureBox.Image = trainer.PhotoImage;
                photoPath = trainer.Photo;
            }
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
            else if (FitnessClubDbContext.DbContext.Users.FirstOrDefault(u => u.Login == login && trainer == null) != null)
            {
                MessageBox.Show("Данный логин уже используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (trainer == null && string.IsNullOrEmpty(photoPath))
            {
                MessageBox.Show("Загрузите фотографию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (trainer == null)
                {
                    User user = new User();
                    user.SecondName = secondName;
                    user.FirstName = firstName;
                    user.Patronymic = patronymic;
                    user.Birthdate = birthdate;
                    user.Phone = phone;
                    user.Login = login;
                    user.Password = password;
                    user.RoleId = 2;
                    trainer = new Trainer();
                    trainer.WorkStartDate = DateTime.Today;
                    string fileName = $@"{Path.GetRandomFileName().Replace('.', '_')}.jpg";
                    File.Copy(photoPath, $@"{AppDomain.CurrentDomain.BaseDirectory}\Photos\Trainers\{fileName}", true);
                    trainer.Photo = fileName;
                    trainer.User = user;
                    user.Trainer = trainer;
                    FitnessClubDbContext.DbContext.Trainers.Add(trainer);
                    FitnessClubDbContext.DbContext.SaveChanges();
                    MessageBox.Show("Тренер добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    User user = trainer.User;
                    user.SecondName = secondName;
                    user.FirstName = firstName;
                    user.Patronymic = patronymic;
                    user.Birthdate = birthdate;
                    user.Phone = phone;
                    if (trainer.Photo != photoPath)
                    {
                        string fileName = $@"{Path.GetRandomFileName().Replace('.', '_')}.jpg";
                        File.Copy(photoPath, $@"{AppDomain.CurrentDomain.BaseDirectory}\Photos\Trainers\{fileName}", true);
                        trainer.Photo = fileName;
                    }
                    FitnessClubDbContext.DbContext.SaveChanges();
                    MessageBox.Show("Тренер изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
