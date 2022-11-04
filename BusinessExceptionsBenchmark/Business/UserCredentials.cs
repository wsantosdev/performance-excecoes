namespace BusinessExceptionsBenchmark.Business
{
    public class UserCredentials
    {
        public static readonly UserCredentials Empty = new() { UserName = string.Empty };
        public static readonly UserCredentials ValidUserName = new (){ UserName = "wsantosdev" };

        public string? UserName { get; private set; }
    }
}