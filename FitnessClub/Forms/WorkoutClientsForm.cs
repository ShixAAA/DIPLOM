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
    public partial class WorkoutClientsForm : Form
    {
        private Workout workout;

        public WorkoutClientsForm(Workout workout)
        {
            InitializeComponent();
            this.workout = workout;
            LoadInitialData();
            UpdateClients();
        }

        private void LoadInitialData()
        {
            HeaderLabel.Text = $"Клиенты тренировки {workout.Name}";
            List<string> sort = new List<string> { "По умолчанию", "По ФИО↑", "по ФИО↓", "По дате рождения↑", "По дате рождения↓" };
            SortComboBox.DataSource = sort;
        }

        private void UpdateClients()
        {
            ClientsDataGridView.DataSource = null;
            ClientsDataGridView.AutoGenerateColumns = false;
            List<Client> clients = workout.Clients.ToList();
            string search = SearchTextBox.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(search))
            {
                clients = clients.Where(c => c.FullName.ToLower().Contains(search)).ToList();
            }
            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    clients = clients.OrderBy(c => c.FullName).ToList();
                    break;
                case 2:
                    clients = clients.OrderByDescending(c => c.FullName).ToList();
                    break;
                case 3:
                    clients = clients.OrderBy(c => c.User.Birthdate).ToList();
                    break;
                case 4:
                    clients = clients.OrderByDescending(c => c.User.Birthdate).ToList();
                    break;
            }
            ClientsDataGridView.DataSource = clients;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateClients();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateClients();
        }
    }
}
