﻿namespace TempleVolunteerAPI.Domain
{
    public class ResetForgottenPasswordRequest : Audit
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int PropertyId { get; set; }
    }
}
