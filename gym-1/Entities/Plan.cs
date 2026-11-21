namespace gym_1.Entities
{
    public class Plan :BaseEntity
    {
        public string name { get; set; } = default!;
        public string description { get; set; } = default!;
        public decimal price { get; set; }
        public int durationDays { get; set; }
        public bool isActive { get; set; }

        public ICollection<MemberShip> planSubscribtion { get; set; } = default!;
    }
}
