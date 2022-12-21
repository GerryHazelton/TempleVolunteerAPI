namespace TempleVolunteerAPI.Domain
{
    public class StaffRole
    {
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        public int PropertyId { get; set; }
    }
}
