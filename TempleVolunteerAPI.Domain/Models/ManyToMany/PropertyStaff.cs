namespace TempleVolunteerAPI.Domain
{
    public class PropertyStaff
    {
        public int PropertyId { get; set; }
        public Property? Property { get; set; }
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
    }
}
