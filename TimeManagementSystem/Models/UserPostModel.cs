using static TimeManaementSystem.Core.Entities.User;
using TimeManaementSystem.Core.Entities;

namespace TimeManagementSystem.Api.Models
{
    public class UserPostModel
    {
        public string Name { get; set; }
        public RoleType Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
