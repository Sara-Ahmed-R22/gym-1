namespace gym_1.Entities
{
    public class Session :BaseEntity
    {
        public string description { get; set; } = default!;
        public int capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int trainerId { get; set; }
        public trainer trainer { get; set; } = default!;
    }
}
