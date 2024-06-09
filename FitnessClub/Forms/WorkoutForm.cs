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
    public partial class WorkoutForm : Form
    {
        private Workout workout;

        public WorkoutForm(Workout workout)
        {
            InitializeComponent();
            this.workout = workout;
            NameLabel.Text = workout.Name;
            WorkoutTypeLabel.Text = workout.WorkoutType.Name;
            TimeSpan timeSpan = workout.TimeEnd - workout.TimeStart;
            TimeLabel.Text = $"{workout.DateWorkout.ToShortDateString()} {workout.TimeStart.ToString(@"hh\:mm")}-{workout.TimeEnd.ToString(@"hh\:mm")} ({timeSpan.TotalMinutes} мин)";
            TrainerPhotoPictureBox.Image = workout.Trainer.PhotoImage;
            TrainerLabel.Text = $"{workout.Trainer.User.SecondName} {workout.Trainer.User.FirstName}";
            RoomLabel.Text = workout.Room.Name;
            DesciptionLabel.Text = workout.Description;
        }


        private void DetailsButton_Click(object sender, EventArgs e)
        {
            TrainerInfoForm trainerInfoForm = new TrainerInfoForm(workout.Trainer);
            trainerInfoForm.ShowDialog();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (User.SignedUser == null)
            {
                MessageBox.Show("Войдите в систему или зарегистрируйтесь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (workout.IsDeleted == 1)
            {
                MessageBox.Show("Тренеровка отменена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (now > workout.DateWorkout.Add(workout.TimeEnd))
            {
                MessageBox.Show("Тренировка уже прошла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (User.SignedUser.RoleId == 3)
            {
                if (User.SignedUser.Client.Workouts.Contains(workout))
                {
                    MessageBox.Show("Вы уже записаны на эту тренировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (workout.NumberSeats == workout.Clients.Count)
                {
                    MessageBox.Show("Недостаточно мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User.SignedUser.Client.Workouts.Add(workout);
                    FitnessClubDbContext.DbContext.SaveChanges();
                    MessageBox.Show("Вы записались на тренировку", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (User.SignedUser.RoleId == 2)
            {
                MessageBox.Show("Вы не можете записаться на тренировку, так как являетесь тренером", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
