#region Array
BenchmarkRunner.Run<ArrayOperationsBenchmark>();
#endregion

#region Stack
BenchmarkRunner.Run<ArrayStackBenchmark>();
BenchmarkRunner.Run<ListStackBenchmark>();
BenchmarkRunner.Run<QueueStackBenchmark>();
BenchmarkRunner.Run<LinkedListStackBenchmark>();
BenchmarkRunner.Run<StackWrapperBenchmark>();
BenchmarkRunner.Run<ConcurrentStackWrapperBenchmarks>();
#endregion