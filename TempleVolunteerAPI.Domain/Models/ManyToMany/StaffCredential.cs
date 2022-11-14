namespace TempleVolunteerAPI.Domain
{
    public class StaffCredential
    {
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int CredentialId { get; set; }
        public Credential? Credential { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
