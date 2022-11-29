using System;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Domain
{
    public class CredentialRequest : Audit
    {
        public int CredentialId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
    }
}
