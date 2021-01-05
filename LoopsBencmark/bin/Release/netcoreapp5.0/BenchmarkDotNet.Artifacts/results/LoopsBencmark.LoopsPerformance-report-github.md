``` ini

BenchmarkDotNet=v0.12.1, OS=macOS 11.1 (20C69) [Darwin 20.2.0]
Intel Core i9-8950HK CPU 2.90GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|            Method |        Mean |       Error |       StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |------------:|------------:|-------------:|-------:|------:|------:|----------:|
|        ForAddLoop | 32,224.6 ns |   527.06 ns |    440.12 ns |      - |     - |     - |         - |
| ParalelForAddLoop | 95,459.9 ns | 5,450.60 ns | 15,813.19 ns | 0.5493 |     - |     - |    3685 B |
|    ParalelForLoop | 14,160.8 ns |    88.14 ns |     68.82 ns | 0.5188 |     - |     - |    3249 B |
| ParalelForechLoop | 15,399.9 ns |    73.95 ns |     61.75 ns | 0.5493 |     - |     - |    3476 B |
|        ForechLoop |    271.2 ns |     5.49 ns |     12.50 ns |      - |     - |     - |         - |
