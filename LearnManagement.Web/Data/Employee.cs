using Microsoft.AspNetCore.Identity;

namespace LearnManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; } = string.Empty;
        public string? TaxId { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
