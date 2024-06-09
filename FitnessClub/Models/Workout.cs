using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class Workout
    {
        public Workout()
        {
            Clients = new HashSet<Client>();
        }

        public int WorkoutId { get; set; }
        public string Name { get; set; } = null!;
        public int WorkoutTypeId { get; set; }
        public int RoomId { get; set; }
        public DateTime DateWorkout { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public int TrainerId { get; set; }
        public string Description { get; set; } = null!;
        public int NumberSeats { get; set; }
        public byte IsDeleted { get; set; }

        public virtual Room Room { get; set; } = null!;
        public virtual Trainer Trainer { get; set; } = null!;
        public virtual WorkoutType WorkoutType { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; }
    }
}
