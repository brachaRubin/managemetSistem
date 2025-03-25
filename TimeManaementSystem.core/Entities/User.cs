using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TimeManaementSystem.Core.Entities
{
    public class User
    {
        public enum RoleType
        {
            Manager, Employee
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoleType Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List< WorkHours> WorkHours { get; set; }

    }
}
