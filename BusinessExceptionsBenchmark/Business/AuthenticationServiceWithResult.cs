namespace BusinessExceptionsBenchmark.Business
{
    public class AuthenticationServiceWithResult
    {
        public static Result ValidateUser(UserCredentials userCredentials)
        {
            if (string.IsNullOrWhiteSpace(userCredentials.UserName))
                return Result.Failure("A username must be provided.");

            return Result.Ok();
        }
    }
}
