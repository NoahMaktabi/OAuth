using System.ComponentModel.DataAnnotations;

namespace IdentityServerHost.Quickstart.UI
{
    public class RegisterViewModel
    {
        [Required] 
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required] 
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required] 
        public string FirstName { get; set; }
        [Required] 
        public string LastName { get; set; }
        [Required] 
        public string Username { get; set; }
        public string ReturnUrl { get; set; }
    }
}