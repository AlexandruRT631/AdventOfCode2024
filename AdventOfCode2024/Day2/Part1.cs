namespace AdventOfCode2024.Day2
{
    public class Part1 : Part
    {
        public override void Solve()
        {
            var lines = ReadFileByLines("../../../Day2/input.txt");
            var safeReports = 0;

            foreach (var line in lines)
            {
                var levels = line.Split(' ').Select(int.Parse).ToList();
                var direction = Math.Sign(levels[1] - levels[0]);
                var isSafe = levels.Skip(1).Select((level, index) => level - levels[index]).All(diff => diff * direction >= 1 && diff * direction <= 3);
                safeReports += isSafe ? 1 : 0;
            }

            Console.WriteLine(safeReports);
        }
    }
}
