﻿
namespace TempleVolunteerAPI.Domain
{
    public class MyProfileRequest : Audit
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public bool FirstAid { get; set; }
        public bool CPR { get; set; }
        public bool Kriyaban { get; set; }
        public bool LessonStudent { get; set; }
        public string EmailAddress { get; set; }
        public int PropertyId { get; set; }
        public string? StaffFileName { get; set; }
        public byte[]? StaffImage { get; set; }
    }
}