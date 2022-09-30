
using System.Text.Json.Serialization;

namespace TempleVolunteerAPI.Domain
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }

        public string? ErrorCode { get; set; }

        public string? Message { get; set; }
    }
}
