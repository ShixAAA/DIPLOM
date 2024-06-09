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
    public partial class TrainerInfoForm : Form
    {
        private Trainer trainer;

        public TrainerInfoForm(Trainer trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
            FullNameLabel.Text = trainer.FullName;
            int exp = DateTime.Now.Year - trainer.WorkStartDate.Year;
            if (DateTime.Now.Month < trainer.WorkStartDate.Month || (DateTime.Now.Month == trainer.WorkStartDate.Month && DateTime.Now.Day < trainer.WorkStartDate.Day))
            {
                exp--;
            }
            ExperienceLabel.Text = $"Стаж: {exp} {GetYearsText(exp)}";
            int age = DateTime.Now.Year - trainer.User.Birthdate.Year;
            if (DateTime.Now.Month < trainer.User.Birthdate.Month || (DateTime.Now.Month == trainer.User.Birthdate.Month && DateTime.Now.Day < trainer.User.Birthdate.Day))
            {
                age--;
            }
            AgeLabel.Text = $"Возраст: {age} {GetYearsText(age)}";
            TrainerPhotoPictureBox.Image = trainer.PhotoImage;
            AchivementsListBox.DataSource = trainer.TrainerAchievements.ToList();
        }

        private string GetYearsText(int years)
        {
            if (years % 10 == 1 && years % 100 != 11)
            {
                return "год";
            }
            else if ((years % 10 >= 2 && years % 10 <= 4) && (years % 100 < 10 || years % 100 >= 20))
            {
                return "года";
            }
            else
            {
                return "лет";
            }
        }
    }
}
