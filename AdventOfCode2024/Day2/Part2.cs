namespace AdventOfCode2024.Day2
{
    public class Part2 : Part
    {
        private class Report
        {
            public int Level { get; set; }
            public int Index { get; set; }
        }

        public override void Solve()
        {
            var lines = ReadFileByLines("../../../Day2/input.txt");
            var safeReports = 0;

            foreach (var line in lines)
            {
                var levels = line.Split(' ').Select(int.Parse).ToList();

                var isSafe = false;
                for (int i = 0; i < levels.Count && !isSafe; i++) {
                    var testList = new List<int>(levels);
                    testList.RemoveAt(i);
                    var direction = Math.Sign(testList[1] - testList[0]);
                    isSafe = testList.Skip(1).Select((level, index) => level - testList[index]).All(diff => diff * direction >= 1 && diff * direction <= 3);
                }

                safeReports += isSafe ? 1 : 0;
            }

            Console.WriteLine(safeReports);
        }
    }
}
