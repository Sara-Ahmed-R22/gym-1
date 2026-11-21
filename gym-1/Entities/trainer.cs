using gym_1.Entities.enums;

namespace gym_1.Entities
{
    public class trainer : GymUser
    {
        public Specialties specialty { get; set; }
        public ICollection<Session> sessions { get; set; } = default!;
    }
}
