﻿namespace TempleVolunteerAPI.Domain
{
    public class RoleRequest : Audit
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
    }
}
