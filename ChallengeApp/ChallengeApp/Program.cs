using ChallengeApp;

var employee = new Employee("Adam", "Słodowy");
employee.AddGrade(65);
employee.AddGrade(23);
var statistics = employee.GetStatistics();

Console.WriteLine($"średnia wartość {statistics.Average:N2}");
Console.WriteLine($"Maks {statistics.Max}");
Console.WriteLine($"Minimum {statistics.Min}");