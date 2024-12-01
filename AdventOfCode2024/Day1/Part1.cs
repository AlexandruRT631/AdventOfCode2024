using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day1
{
    public class Part1 : Part
    {
        public override void Solve()
        {
            var sortedList1 = new List<int>();
            var sortedList2 = new List<int>();
            var lines = ReadFileByLines("../../../Day1/input.txt");

            foreach (var line in lines)
            {
                var values = Regex.Replace(line, @"\s+", " ").Split(' ');
                sortedList1.Add(int.Parse(values[0]));
                sortedList2.Add(int.Parse(values[1]));
            }
            sortedList1.Sort();
            sortedList2.Sort();

            var result = 0;
            for (var i = 0; i < sortedList1.Count; i++)
            {
                result += Math.Abs(sortedList1[i] - sortedList2[i]);
            }

            Console.WriteLine(result);
        }
    }
}
