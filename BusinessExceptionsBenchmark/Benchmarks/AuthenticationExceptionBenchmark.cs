using BenchmarkDotNet.Attributes;
using BusinessExceptionsBenchmark.Business;

namespace BusinessExceptionsBenchmark.Benchmarks
{
    [SimpleJob(targetCount: 100)]
    [MemoryDiagnoser, MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class AuthenticationExceptionBenchmark
    {
        [Benchmark]
        public bool AuthenticateWithCredentials()
        {
            return AuthenticationServiceWithException.ValidateUser(UserCredentials.ValidUserName);
        }

        [Benchmark]
        public bool AuthenticateWithoutCredentials()
        {
            try
            {
                return AuthenticationServiceWithException.ValidateUser(UserCredentials.Empty);
            }
            catch
            {
                return false;
            }
        }
    }
}
