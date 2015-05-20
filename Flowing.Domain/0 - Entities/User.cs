using System;

namespace Flowing.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Token { get; set; }
        public DateTime InclusionDate { get; set; }
    }
}
