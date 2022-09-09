namespace TempleVolunteerAPI.Domain
{
    public class CredentialStaff
    {
        public int CredentialId { get; set; }
        public Credential? Credential { get; set; }
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int PropertyId { get; set; }

    }
}
