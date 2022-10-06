``` ini

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Apple M2, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.9 (6.0.922.41905), Arm64 RyuJIT AdvSIMD


```
|     Method |     Mean |     Error |    StdDev |
|----------- |---------:|----------:|----------:|
|     Single | 5.688 μs | 0.0036 μs | 0.0032 μs |
|      First | 5.707 μs | 0.0026 μs | 0.0023 μs |
| ListSingle | 8.746 μs | 0.0286 μs | 0.0267 μs |
|  ListFirst | 8.743 μs | 0.0163 μs | 0.0127 μs |
