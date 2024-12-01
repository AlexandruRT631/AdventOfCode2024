namespace AdventOfCode2024
{
    public abstract class Part
    {
        public abstract void Solve();

        public static List<string> ReadFileByLines(string path)
        {
            return [.. File.ReadAllLines(path)];
        }
    }
}
