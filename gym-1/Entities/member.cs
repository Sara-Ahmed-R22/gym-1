namespace gym_1.Entities
{
    public class member :GymUser
    {
        public string photo { get; set; }
        public ICollection<MemberShip> memberSubscribtion { get; set; } = default!;
    }
}
