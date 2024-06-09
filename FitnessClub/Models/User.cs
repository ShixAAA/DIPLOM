using System;
using System.Collections.Generic;

namespace FitnessClub.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string SecondName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public string FullName { get { return $"{SecondName} {FirstName} {Patronymic}".Trim(); } }
        public static User? SignedUser = null;
        public string PhoneFormat { get { return $"+7({Phone.Substring(0, 3)}) {Phone.Substring(3, 3)}-{Phone.Substring(6, 2)}-{Phone.Substring(8)}"; } }

        public virtual Role Role { get; set; } = null!;
        public virtual Client? Client { get; set; }
        public virtual Trainer? Trainer { get; set; }
    }
}
