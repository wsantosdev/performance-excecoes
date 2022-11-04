using BenchmarkDotNet.Attributes;
using BusinessExceptionsBenchmark.Business;

namespace BusinessExceptionsBenchmark.Benchmarks
{
    [SimpleJob(targetCount: 100)]
    [MemoryDiagnoser, MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class AuthenticationResultBenchmark
    {
        [Benchmark]
        public Result AuthenticateWithCredentials()
        {
            return AuthenticationServiceWithResult.ValidateUser(UserCredentials.ValidUserName);
        }

        [Benchmark]
        public Result AuthenticateWithoutCredentials()
        {
            return AuthenticationServiceWithResult.ValidateUser(UserCredentials.Empty);
        }
    }
}
