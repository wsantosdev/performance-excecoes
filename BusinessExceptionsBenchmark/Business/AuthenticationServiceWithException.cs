namespace BusinessExceptionsBenchmark.Business
{
    public class AuthenticationServiceWithException
    {
        public static bool ValidateUser(UserCredentials userCredentials)
        {
            if (string.IsNullOrWhiteSpace(userCredentials.UserName))
                throw new UserValidationException("A username must be provided.");

            return true;
        }
    }
}
