// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using JsonPerformanceLab;

Console.WriteLine("Hello, World!");

var summary1 = BenchmarkRunner.Run<JsonBenchmarks>();
