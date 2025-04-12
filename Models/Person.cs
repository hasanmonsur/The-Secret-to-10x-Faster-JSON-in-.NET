using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPerformanceLab.Models
{
    public record Person(
    Guid Id,
    string Name,
    int Age,
    DateTime BirthDate,
    List<string> Tags
    );

    // Generate test data
    public static class DataGenerator
    {
        public static Person CreatePerson() => new(
            Guid.NewGuid(),
            "John Doe",
            30,
            DateTime.UtcNow.AddYears(-30),
            new List<string> { "Developer", "Blogger", "Gamer" }
        );

        public static List<Person> CreatePeople(int count)
            => Enumerable.Range(0, count).Select(_ => CreatePerson()).ToList();
    }

}
