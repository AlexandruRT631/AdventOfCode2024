using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day3
{
    public class Part1 : Part
    {
        public override void Solve()
        {
            var fileContent = ReadFile("../../../Day3/input.txt");

            var matches = Regex.Matches(fileContent, @"mul\(\d+,\d+\)");
            var result = matches.Select(match => 
                match.Value.Substring(4, match.Length - 5).Split(',')
                    .Select(int.Parse)
                    .Aggregate((a, b) => a * b)
            ).Sum();

            Console.WriteLine(result);
        }
    }
}
