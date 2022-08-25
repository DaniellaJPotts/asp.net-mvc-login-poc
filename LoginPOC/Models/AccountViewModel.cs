namespace LoginPOC.Models
{
    public class AccountViewModel
    {
        public string? Forename { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public long LastLoginAttempt { get; set; }

        public string GetName()
        {
            return Forename + " " + Surname;
        }

        public string GetAuthenticationCode()
        {
            return (LastLoginAttempt % 1000000).ToString();
        }

        public string GetPhoneEnding()
        {
            if (Phone is null) return string.Empty;
            return Phone[^4..];
        }
    }
}
