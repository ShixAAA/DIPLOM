﻿using FitnessClub.Models;
using FitnessClub.UserControls;
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
    public partial class ClientForm : Form
    {
        private int week = 0;
        private bool isSignOut = false;

        public ClientForm()
        {
            InitializeComponent();
            LoadInitialData();
            UpdateWeekSchedule();
        }

        private void LoadInitialData()
        {
            WelcomeLabel.Text = $"Добро пожаловать {User.SignedUser.FullName} ({User.SignedUser.Role.Name})";
            TypeScheduleComboBox.SelectedIndex = 0;
            List<Room> rooms = new List<Room>() { new Room() { RoomId = 0, Name = "Все помещения", Description = "Все помещения" } };
            rooms.AddRange(FitnessClubDbContext.DbContext.Rooms.ToList());
            RoomFilterComboBox.DataSource = rooms;
            List<WorkoutType> workoutTypes = new List<WorkoutType>() { new WorkoutType() { WorkoutTypeId = 0, Name = "Все типы тренировок", Photo = "no photo" } };
            workoutTypes.AddRange(FitnessClubDbContext.DbContext.WorkoutTypes.ToList());
            WorkoutTypeFilterComboBox.DataSource = workoutTypes;
            List<Trainer> trainers = new List<Trainer>() { new Trainer() { UserId = 0, User = new User() { UserId = 0, SecondName = "Все тренера" } } };
            trainers.AddRange(FitnessClubDbContext.DbContext.Trainers.Where(t => t.IsDeleted == 0).ToList());
            TrainerFilterComboBox.DataSource = trainers;
        }

        public void UpdateWeekSchedule()
        {
            ScheduleTablePanel.Controls.Clear();
            DateTime today = DateTime.Today.AddDays(week * 7);
            DayOfWeek currentDayOfWeek = today.DayOfWeek;
            int daysToMonday = (int)currentDayOfWeek - (int)DayOfWeek.Monday;
            if (daysToMonday < 0)
            {
                daysToMonday += 7;
            }
            DateTime monday = today.AddDays(-daysToMonday);
            DateTime sunday = monday.AddDays(6);
            MondayLabel.Text = $"{monday.ToString("dd MMMM")}\nПН";
            TuesdayLabel.Text = $"{monday.AddDays(1).ToString("dd MMMM")}\nВТ";
            WednesdayLabel.Text = $"{monday.AddDays(2).ToString("dd MMMM")}\nСР";
            ThursdayLabel.Text = $"{monday.AddDays(3).ToString("dd MMMM")}\nЧТ";
            FridayLabel.Text = $"{monday.AddDays(4).ToString("dd MMMM")}\nПТ";
            SaturdayLabel.Text = $"{monday.AddDays(5).ToString("dd MMMM")}\nСБ";
            SundayLabel.Text = $"{sunday.ToString("dd MMMM")}\nВС";
            IQueryable<Workout> data;
            if (TypeScheduleComboBox.SelectedIndex == 0)
            {
                data = FitnessClubDbContext.DbContext.Workouts.Where(w => w.DateWorkout >= monday && w.DateWorkout.Date <= sunday);
            }
            else
            {
                data = FitnessClubDbContext.DbContext.Workouts.Where(w => w.DateWorkout >= monday && w.DateWorkout.Date <= sunday && w.Clients.Contains(User.SignedUser.Client));
            }
            List<Workout> workouts;
            if (data.Count() > 0)
            {
                workouts = data.ToList();
            }
            else
            {
                workouts = new List<Workout>();
            }
            Room room = (Room)RoomFilterComboBox.SelectedItem;
            if (room != null && room.RoomId != 0)
            {
                workouts = workouts.Where(w => w.RoomId == room.RoomId).ToList();
            }
            WorkoutType workoutType = (WorkoutType)WorkoutTypeFilterComboBox.SelectedItem;
            if (workoutType != null && workoutType.WorkoutTypeId != 0)
            {
                workouts = workouts.Where(w => w.WorkoutTypeId == workoutType.WorkoutTypeId).ToList();
            }
            Trainer trainer = (Trainer)TrainerFilterComboBox.SelectedItem;
            if (trainer != null && trainer.UserId != 0)
            {
                workouts = workouts.Where(w => w.TrainerId == trainer.UserId).ToList();
            }
            int minTime = workouts.Count != 0 ? workouts.Min(w => w.TimeStart).Hours : 0;
            int maxTime = workouts.Count != 0 ? workouts.Max(w => w.TimeEnd).Hours : 0;
            ScheduleTablePanel.RowCount = maxTime - minTime + 2;
            ScheduleTablePanel.RowStyles.Clear();
            ScheduleTablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            if (minTime > 0 && maxTime > 0)
            {
                for (int time = minTime, i = 0; time <= maxTime; time++, i++)
                {
                    Label label = new Label();
                    label.Width = 50;
                    Label label2 = new Label();
                    label.Text = $"{time}:00";
                    label2.Text = $"{time}:00";
                    label2.Width = 50;
                    ScheduleTablePanel.Controls.Add(label, 0, i);
                    ScheduleTablePanel.Controls.Add(label2, 8, i);
                }
            }

            foreach (Workout workout in workouts)
            {
                int dayOfWeek = (int)workout.DateWorkout.DayOfWeek;
                if (dayOfWeek == 0)
                {
                    dayOfWeek = 7;
                }
                AddTrainingControl(workout.TimeStart.Hours - minTime, dayOfWeek, workout);
            }
        }

        private void AddTrainingControl(int row, int column, Workout workout)
        {
            TableLayoutPanel panel = (TableLayoutPanel)ScheduleTablePanel.GetControlFromPosition(column, row);

            if (panel == null)
            {
                panel = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoSize = true,
                    ColumnCount = 1,
                    RowCount = 1,
                };
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                ScheduleTablePanel.Controls.Add(panel, column, row);
            }
            else
            {
                panel.RowCount = panel.RowCount + 1;
            }

            WorkoutUserControl workoutUserControl = new WorkoutUserControl(workout);
            workoutUserControl.Dock = DockStyle.Fill;
            panel.Controls.Add(workoutUserControl, 0, panel.RowCount - 1);
        }

        private void PreviousWeekButton_Click(object sender, EventArgs e)
        {
            if (week > 0)
            {
                week--;
                UpdateWeekSchedule();
                PreviousWeekButton.Enabled = false;
                NextWeekButton.Enabled = true;
            }
        }

        private void NextWeekButton_Click(object sender, EventArgs e)
        {
            if (week == 0)
            {
                week++;
                UpdateWeekSchedule();
                NextWeekButton.Enabled = false;
                PreviousWeekButton.Enabled = true;
            }
        }

        private void RoomFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeekSchedule();
        }

        private void WorkoutTypeFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeekSchedule();
        }

        private void TrainerFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeekSchedule();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            isSignOut = true;
            User.SignedUser = null;
            Close();
        }

        private void TypeScheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWeekSchedule();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isSignOut)
            {
                Application.OpenForms[0].Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
