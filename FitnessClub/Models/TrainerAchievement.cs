using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class TrainerAchievement
    {
        public int TrainerAchievementId { get; set; }
        public int TrainerId { get; set; }
        public string Achievement { get; set; } = null!;

        public virtual Trainer Trainer { get; set; } = null!;
    }
}
