using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            TrainerAchievements = new HashSet<TrainerAchievement>();
            Workouts = new HashSet<Workout>();
        }

        public int UserId { get; set; }
        public DateTime WorkStartDate { get; set; }
        public string Photo { get; set; } = null!;
        public string FullName { get { return User.FullName; } }
        public string SecondName { get { return User.SecondName; } }
        public string FirstName { get { return User.FirstName; } }
        public string Patronymic { get { return User.Patronymic; } }
        public DateTime Birthdate { get { return User.Birthdate; } }
        public byte IsDeleted { get; set; }
        public string PhoneFormat { get { return User.PhoneFormat; } }
        public bool IsCurrentlyTraining
        {
            get
            {
                DateTime now = DateTime.Now;
                return Workouts.Any(w => w.DateWorkout.Date == now.Date &&
                                         w.TimeStart <= now.TimeOfDay &&
                                         w.TimeEnd >= now.TimeOfDay &&
                                         w.IsDeleted == 0);
            }
        }
        public string OnTraining { get { return IsCurrentlyTraining ? "Да" : "Нет"; } }
        public Image PhotoImage
        {
            get
            {
                try
                {
                    return LoadImageFromFile(new FileStream($@"{Environment.CurrentDirectory}\Photos\Trainers\{Photo}", FileMode.Open, FileAccess.Read, FileShare.Inheritable));
                }
                catch
                {
                    return LoadImageFromFile(new FileStream($@"{Environment.CurrentDirectory}\Photos\placeholder.png", FileMode.Open, FileAccess.Read, FileShare.Inheritable));
                }

            }
        }

        private Image LoadImageFromFile(FileStream photoFIleStream)
        {
            using (FileStream fileStream = photoFIleStream)
            {
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    return Image.FromStream(memoryStream);
                }
            }
        }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<TrainerAchievement> TrainerAchievements { get; set; }
        public virtual ICollection<Workout> Workouts { get; set; }
    }
}
