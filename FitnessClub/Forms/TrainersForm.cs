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
    public partial class TrainersForm : Form
    {
        private Trainer? selectedTrainer;

        public TrainersForm()
        {
            InitializeComponent();
            LoadInitialData();
            UpdateTrainers();
        }

        private void LoadInitialData()
        {
            List<string> sort = new List<string> { "По умолчанию", "По ФИО↑", "по ФИО↓", "По дате рождения↑", "По дате рождения↓" };
            SortComboBox.DataSource = sort;
        }

        private void UpdateTrainers()
        {
            TrainersDataGridView.DataSource = null;
            TrainersDataGridView.AutoGenerateColumns = false;
            IQueryable<Trainer> data = FitnessClubDbContext.DbContext.Trainers.Where(t => t.IsDeleted == 0);
            List<Trainer> trainers;
            if (data.Count() > 0)
            {
                trainers = data.ToList();
            }
            else
            {
                trainers = new List<Trainer>();
            }
            string search = SearchTextBox.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(search))
            {
                trainers = trainers.Where(t => t.FullName.ToLower().Contains(search)).ToList();
            }
            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    trainers = trainers.OrderBy(t => t.FullName).ToList();
                    break;
                case 2:
                    trainers = trainers.OrderByDescending(t => t.FullName).ToList();
                    break;
                case 3:
                    trainers = trainers.OrderBy(t => t.User.Birthdate).ToList();
                    break;
                case 4:
                    trainers = trainers.OrderByDescending(t => t.User.Birthdate).ToList();
                    break;
            }
            TrainersDataGridView.DataSource = trainers;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTrainers();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTrainers();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddChangeTrainer addChangeTrainer = new AddChangeTrainer();
            if (addChangeTrainer.ShowDialog() == DialogResult.OK)
            {
                UpdateTrainers();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (selectedTrainer == null)
            {
                MessageBox.Show("Выберите тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddChangeTrainer addChangeTrainer = new AddChangeTrainer(selectedTrainer);
                if (addChangeTrainer.ShowDialog() == DialogResult.OK)
                {
                    UpdateTrainers();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedTrainer == null)
            {
                MessageBox.Show("Выберите тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show($"Вы действительно хотите удалить тренера {selectedTrainer.FirstName}?\nВсе его тренеровки будут отменены!", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (selectedTrainer.Workouts.Count > 0)
                {
                    selectedTrainer.IsDeleted = 1;
                    foreach (Workout workout in selectedTrainer.Workouts)
                    {
                        workout.IsDeleted = 1;
                    }
                }
                else
                {
                    FitnessClubDbContext.DbContext.Trainers.Remove(selectedTrainer);
                }
                FitnessClubDbContext.DbContext.SaveChanges();
                UpdateTrainers();
            }
        }

        private void TrainersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TrainersDataGridView.SelectedRows.Count > 0)
            {
                selectedTrainer = (Trainer)TrainersDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                selectedTrainer = null;
            }

        }
    }
}
