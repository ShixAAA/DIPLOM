using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class WorkoutType
    {
        public WorkoutType()
        {
            Workouts = new HashSet<Workout>();
        }

        public int WorkoutTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string Photo { get; set; } = null!;

        public virtual ICollection<Workout> Workouts { get; set; }
    }
}
