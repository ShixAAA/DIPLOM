using FitnessClub.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Forms
{
    public partial class AddChangeWorkoutForm : Form
    {
        private Workout? workout;

        public AddChangeWorkoutForm(Workout? workout = null)
        {
            InitializeComponent();
            this.workout = workout;
            WorkoutTypeComboBox.DataSource = FitnessClubDbContext.DbContext.WorkoutTypes.ToList();
            WorkoutTypeComboBox.SelectedItem = null;
            RoomComboBox.DataSource = FitnessClubDbContext.DbContext.Rooms.ToList();
            RoomComboBox.SelectedItem = null;
            TrainerComboBox.DataSource = FitnessClubDbContext.DbContext.Trainers.Where(t => t.IsDeleted == 0).ToList();
            TrainerComboBox.SelectedItem = null;
            DateWorkoutDatePicker.MinDate = DateTime.Today;
            DateWorkoutDatePicker.MaxDate = DateTime.Today.AddDays(14);
            if (workout == null)
            {
                HeaderLabel.Text = "Добавление тренировки";
                AddButton.Text = "Добавить тренировку";
            }
            else
            {
                HeaderLabel.Text = "Изменение тренировки";
                AddButton.Text = "Изменить тренировку";
                NameTextBox.Text = workout.Name;
                WorkoutTypeComboBox.SelectedItem = workout.WorkoutType;
                RoomComboBox.SelectedItem = workout.Room;
                DateWorkoutDatePicker.Value = workout.DateWorkout;
                TimeStartTimePicker.Value = DateTime.Today.Add(workout.TimeStart);
                TimeEndTimePicker.Value = DateTime.Today.Add(workout.TimeEnd);
                TrainerComboBox.SelectedItem = workout.Trainer;
                DescriptionTextBox.Text = workout.Description;
                NumberSeatsNumeric.Value = workout.NumberSeats;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            WorkoutType? workoutType = (WorkoutType)WorkoutTypeComboBox.SelectedItem;
            Room? room = (Room)RoomComboBox.SelectedItem;
            DateTime dateWorkout = DateWorkoutDatePicker.Value;
            TimeSpan timeStart = TimeStartTimePicker.Value.TimeOfDay;
            TimeSpan timeEnd = TimeEndTimePicker.Value.TimeOfDay;
            Trainer? trainer = (Trainer)TrainerComboBox.SelectedItem;
            string description = DescriptionTextBox.Text;
            int numberSeats = (int)NumberSeatsNumeric.Value;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Заполните наименование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (workoutType == null)
            {
                MessageBox.Show("Выберите тип тренировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (room == null)
            {
                MessageBox.Show("Выберите помещение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Заполните описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numberSeats == 0)
            {
                MessageBox.Show("Количество место должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (timeStart >= timeEnd)
            {
                MessageBox.Show("Время начала должно быть меньше времени конца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (room.Workouts.Any(w => w != workout && w.DateWorkout.Date == dateWorkout.Date && (w.TimeStart >= timeStart && w.TimeStart <= timeEnd || w.TimeEnd >= timeStart && w.TimeEnd <= timeEnd) && w.IsDeleted == 0))
            {
                MessageBox.Show("В помощении уже назначена тренировка на выбранную дату и время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (trainer.Workouts.Any(w => w != workout && w.DateWorkout.Date == dateWorkout.Date && (w.TimeStart >= timeStart && w.TimeStart <= timeEnd || w.TimeEnd >= timeStart && w.TimeEnd <= timeEnd) && w.IsDeleted == 0))
            {
                MessageBox.Show("У тренера уже назначена тренировка на выбранную дату и время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (workout == null)
                {
                    workout = new Workout();
                    workout.Name = name;
                    workout.WorkoutType = workoutType;
                    workout.Room = room;
                    workout.DateWorkout = dateWorkout;
                    workout.TimeStart = timeStart;
                    workout.TimeEnd = timeEnd;
                    workout.Trainer = trainer;
                    workout.Description = description;
                    workout.NumberSeats = numberSeats;
                    FitnessClubDbContext.DbContext.Workouts.Add(workout);
                    FitnessClubDbContext.DbContext.SaveChanges();
                    MessageBox.Show("Тренировка добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    workout.Name = name;
                    workout.WorkoutType = workoutType;
                    workout.Room = room;
                    workout.DateWorkout = dateWorkout;
                    workout.TimeStart = timeStart;
                    workout.TimeEnd = timeEnd;
                    workout.Trainer = trainer;
                    workout.Description = description;
                    workout.NumberSeats = numberSeats;
                    FitnessClubDbContext.DbContext.SaveChanges();
                    MessageBox.Show("Тренировка изменена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
