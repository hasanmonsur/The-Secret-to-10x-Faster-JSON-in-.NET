using BenchmarkDotNet.Attributes;
using JsonPerformanceLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonPerformanceLab
{
    [MemoryDiagnoser]
    public class JsonBenchmarks
    {
        private static readonly Person _person = DataGenerator.CreatePerson();
        private static readonly string _personJson = JsonSerializer.Serialize(_person);

        [Benchmark]
        public string SystemTextJson_Serialize()
            => JsonSerializer.Serialize(_person);

        [Benchmark]
        public Person SystemTextJson_Deserialize()
            => JsonSerializer.Deserialize<Person>(_personJson)!;

        // Repeat for Newtonsoft.Json and MemoryPack...
    }
}
