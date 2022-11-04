using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(typeof(Program).Assembly,
                    ManualConfig.Create(DefaultConfig.Instance)
                                .WithOptions(ConfigOptions.JoinSummary)
                                .WithOptions(ConfigOptions.DisableLogFile));
