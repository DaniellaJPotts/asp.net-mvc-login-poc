using System.Security.Cryptography;
using System.Text;

namespace LoginPOC.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public new string GetHashCode()
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] stringBytes = Encoding.UTF8.GetBytes(Email.ToLower() + Password);
                byte[] hash = sha.ComputeHash(stringBytes);

                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
    }
}
