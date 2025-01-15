using System.ComponentModel.DataAnnotations;

namespace ECommerce.Api.Models
{
    public class RegisterDto
    {
        [EmailAddress]
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}