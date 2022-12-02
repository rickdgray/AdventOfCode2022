namespace AdventOfCode2022
{
    public class Day01
    {
        public static long Part1(List<string> data)
        {
            var index = 0;
            var elves = new List<long> { 0 };

            foreach (var item in data)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    index++;
                    elves.Add(0);
                    continue;
                }

                elves[index] += long.Parse(item);
            }

            return elves.Max();
        }

        public static long Part2(List<string> data)
        {
            var index = 0;
            var elves = new List<long> { 0 };

            foreach (var item in data)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    index++;
                    elves.Add(0);
                    continue;
                }

                elves[index] += long.Parse(item);
            }

            var heap = new PriorityQueue<long, long>();

            foreach (var elf in elves)
            {
                heap.Enqueue(elf, elf);

                if (heap.Count > 3)
                {
                    heap.Dequeue();
                }
            }

            return heap.UnorderedItems.Sum(e => e.Element);
        }
    }
}