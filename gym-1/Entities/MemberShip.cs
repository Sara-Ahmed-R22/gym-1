using System.ComponentModel.DataAnnotations.Schema;

namespace gym_1.Entities
{
    public class MemberShip : BaseEntity
    {
        public int memberId { get; set; }
        public member member { get; set; } 
        public int planId { get; set; }
        public Plan plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public string status => DateTime.Now < StartDate ? "Upcoming" 
            : DateTime.Now < EndDate ? "Active" : "Expired";
    }
}
