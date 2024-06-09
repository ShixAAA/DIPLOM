using FitnessClub.Forms;
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

namespace FitnessClub.UserControls
{
    public partial class WorkoutUserControl : UserControl
    {
        private Workout workout;
        private AdministratorForm? administratorForm;

        public WorkoutUserControl(Workout workout, AdministratorForm? administratorForm = null)
        {
            InitializeComponent();
            this.workout = workout;
            this.administratorForm = administratorForm;
            DateTime now = DateTime.Now;
            if (now > workout.DateWorkout.Add(workout.TimeEnd))
            {
                IsDeleteLabel.Text = "Прошло";
                IsDeleteLabel.Visible = true;
                IsDeleteLabel.ForeColor = Color.FromArgb(222, 222, 222);
            }
            if (workout.IsDeleted == 1)
            {
                IsDeleteLabel.Text = "Отменено";
                IsDeleteLabel.Visible = true;
                IsDeleteLabel.ForeColor = Color.FromArgb(214,25,5);
            }

            TimeFromToLabel.Text = $"{workout.TimeStart.ToString(@"hh\:mm")}-{workout.TimeEnd.ToString(@"hh\:mm")}";
            TimeSpan timeSpan = workout.TimeEnd - workout.TimeStart;
            TimeLabel.Text = $"{timeSpan.TotalMinutes} мин";
            NameLabel.Text = workout.Name;
            TypeLabel.Text = workout.WorkoutType.Name;
            TrainerLabel.Text = $"{workout.Trainer.User.SecondName} {workout.Trainer.User.FirstName}";
            RoomLabel.Text = workout.Room.Name;
        }

        private void Workout_Click(object sender, EventArgs e)
        {
            if (User.SignedUser != null && User.SignedUser.RoleId == 1)
            {
                WorkoutEditForm workoutEditForm = new WorkoutEditForm(workout);
                workoutEditForm.ShowDialog();
                if (administratorForm != null)
                {
                    administratorForm.UpdateWeekSchedule();
                }
            }
            else
            {
                WorkoutForm workoutForm = new WorkoutForm(workout);
                workoutForm.ShowDialog();
            }
        }
    }
}
