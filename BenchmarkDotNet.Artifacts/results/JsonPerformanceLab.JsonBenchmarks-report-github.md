```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method                     | Mean       | Error    | StdDev   | Gen0   | Allocated |
|--------------------------- |-----------:|---------:|---------:|-------:|----------:|
| SystemTextJson_Serialize   |   594.8 ns |  8.02 ns |  6.70 ns | 0.1354 |     640 B |
| SystemTextJson_Deserialize | 1,141.8 ns | 13.96 ns | 11.66 ns | 0.1926 |     912 B |
