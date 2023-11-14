namespace CustomAttribute
{
    public class UserProfile
    {
        //we want user name to be 10 charlong
        [MinLength(10)]
        public string Username { get; set; }

        //we want password to be 15 char long
        [MinLength(15)]
        public string Password { get; set; }
    }
}