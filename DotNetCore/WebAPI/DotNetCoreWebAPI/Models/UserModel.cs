using System.ComponentModel.DataAnnotations;

namespace DotNetCoreWebAPI.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
