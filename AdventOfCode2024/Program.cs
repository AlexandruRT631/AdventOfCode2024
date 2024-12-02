using AdventOfCode2024;
using System.Reflection;

while (true)
{
    var assembly = Assembly.GetExecutingAssembly();

    var parts = assembly.GetTypes()
        .Where(t => t.IsClass && !t.IsAbstract && typeof(Part).IsAssignableFrom(t))
        .ToList();

    parts = parts.OrderBy(p =>
    {
        var namespaceParts = p.Namespace?.Split('.');
        var dayName = namespaceParts?.LastOrDefault();
        return dayName;
    }).ThenBy(p => p.Name).ToList();

    Console.WriteLine("Select a day and a part to run:");
    for (int i = 0; i < parts.Count; i++)
    {
        var namespaceParts = parts[i].Namespace?.Split('.');
        var dayName = namespaceParts?.LastOrDefault() ?? "Unknown";
        var partName = parts[i].Name;

        Console.WriteLine($"{i + 1}) {dayName} - {partName}");
    }

    Console.Write("Enter the number of your choice: ");
    int.TryParse(Console.ReadLine(), out int choice);
    if (choice == 0)
    {
        break;
    }
    else if (choice >= 1 && choice <= parts.Count)
    {
        var selectedPart = Activator.CreateInstance(parts[choice - 1]) as Part;
        selectedPart?.Solve();
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }

    Console.WriteLine();
}