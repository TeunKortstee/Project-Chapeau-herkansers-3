namespace Model
{
    public class LoginException : Exception
    {
        public LoginException() : base("Invalid credentials were added") { }

        public LoginException(string message) : base(message) { }

        public LoginException(string message, Exception innerException) : base(message, innerException) { }
    }
}
