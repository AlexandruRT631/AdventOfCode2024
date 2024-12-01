using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day1
{
    public class Part2 : Part
    {
        public override void Solve()
        {
            var list = new List<int>();
            var similarity = new Dictionary<int, int>();
            var lines = ReadFileByLines("../../../Day1/input.txt");

            foreach (var line in lines)
            {
                var values = Regex.Replace(line, @"\s+", " ").Split(' ');
                list.Add(int.Parse(values[0]));
                similarity.TryGetValue(int.Parse(values[1]), out var value);
                similarity[int.Parse(values[1])] = value + 1;
            }

            var result = 0;
            foreach (var value in list)
            {
                similarity.TryGetValue(value, out var count);
                result += value * count;
            }

            Console.WriteLine(result);
        }
    }
}
