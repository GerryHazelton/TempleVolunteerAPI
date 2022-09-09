namespace TempleVolunteerAPI.Domain
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public int StaffId { get; set; }
        public int RoleId { get; set; }
        public int LoginAttempts { get; set; }
        public string EmailAddress { get; set; }
        public bool IsLockedOut { get; set; } = true;
        public bool RememberMe { get; set; } = true;
    }
}
