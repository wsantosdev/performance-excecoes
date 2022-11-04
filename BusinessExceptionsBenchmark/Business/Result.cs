namespace BusinessExceptionsBenchmark.Business
{
    public readonly ref struct Result
    {
        private Result(bool isOk, string? errorMessage) 
        {
            IsOk = isOk;
            ErrorMessage = errorMessage;
        }

        public bool IsOk { get; }
        public string? ErrorMessage { get; }

        public static Result Ok() => new (true, default);
        public static Result Failure(string errorMessage) => new (false, errorMessage);
    }
}
