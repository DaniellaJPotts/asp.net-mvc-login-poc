namespace LoginPOC.Models
{
    public class AuthenticationViewModel
    {
        public string? AccountHash { get; set; }
        public string? Name { get; set; }
        public string? PhoneEnding { get; set; }
        public string? AuthnCodePOC { get; set; }
        public string? AuthnCode { get; set; }
    }
}
