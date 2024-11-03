using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TaskManagment.Model
{
    public class Login
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public Role Role { get; set; }
       

    }

    public enum Role
    {
        Admin = 1,
        Editor = 2,
        Viewer = 3
    }

}
