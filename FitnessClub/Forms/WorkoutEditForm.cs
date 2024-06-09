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
    public partial class WorkoutEditForm : Form
    {
        private Workout workout;
        public WorkoutEditForm(Workout workout)
        {
            InitializeComponent();
            this.workout = workout;
            HeaderLabel.Text = $"Тренировка {workout.Name}";
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now > workout.DateWorkout.Add(workout.TimeEnd))
            {
                MessageBox.Show("Тренировка уже прошла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddChangeWorkoutForm addChangeWorkoutForm = new AddChangeWorkoutForm(workout);
                addChangeWorkoutForm.ShowDialog();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now > workout.DateWorkout.Add(workout.TimeEnd))
            {
                MessageBox.Show("Тренировка уже прошла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show($"Вы действительно хотите удалить тренировку {workout.Name}?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (workout.Clients.Count > 0)
                {
                    workout.IsDeleted = 1;
                    FitnessClubDbContext.DbContext.SaveChanges();
                }
                else
                {
                    FitnessClubDbContext.DbContext.Workouts.Remove(workout);
                    FitnessClubDbContext.DbContext.SaveChanges();
                    Close();
                }
            }
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            WorkoutClientsForm workoutClientsForm = new WorkoutClientsForm(workout);
            workoutClientsForm.ShowDialog();
        }
    }
}
