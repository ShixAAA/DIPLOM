using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class Room
    {
        public Room()
        {
            Workouts = new HashSet<Workout>();
        }

        public int RoomId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Workout> Workouts { get; set; }
    }
}
