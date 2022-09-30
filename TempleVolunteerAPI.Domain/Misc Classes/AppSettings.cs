namespace TempleVolunteerAPI.Domain
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string Salt { get; set; }
        public int RefreshTokenTTL { get; set; }
        public string EmailFrom { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
        public string UriLocal { get; set; }
        public string UriHiranyaloka { get; set; }
        public string UriProduction { get; set; }
        public string UriClientLocal { get; set; }
    }
}
