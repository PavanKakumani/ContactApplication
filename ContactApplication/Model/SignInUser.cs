using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Model
{
    public class SignInUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
