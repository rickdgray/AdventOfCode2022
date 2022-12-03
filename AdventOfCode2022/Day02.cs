namespace AdventOfCode2022
{
    public class Day02
    {
        public static long Part1(List<string> data)
        {
            var roundLookup = new Dictionary<string, int>
            {
                { "A X", 3 + 1 }, //tie
                { "A Y", 6 + 2 }, //win
                { "A Z", 0 + 3 }, //loss
                { "B X", 0 + 1 }, //loss
                { "B Y", 3 + 2 }, //tie
                { "B Z", 6 + 3 }, //win
                { "C X", 6 + 1 }, //win
                { "C Y", 0 + 2 }, //loss
                { "C Z", 3 + 3 }  //tie
            };

            var score = 0L;
            foreach (var round in data)
            {
                score += roundLookup[round];
            }

            return score;
        }

        public static long Part2(List<string> data)
        {
            var roundLookup = new Dictionary<string, int>
            {
                { "A X", 0 + 3 }, //lose C
                { "A Y", 3 + 1 }, //tie A
                { "A Z", 6 + 2 }, //win B
                { "B X", 0 + 1 }, //lose A
                { "B Y", 3 + 2 }, //tie B
                { "B Z", 6 + 3 }, //win C
                { "C X", 0 + 2 }, //lose B
                { "C Y", 3 + 3 }, //tie C
                { "C Z", 6 + 1 }  //win A
            };

            var score = 0L;
            foreach (var round in data)
            {
                score += roundLookup[round];
            }

            return score;
        }
    }
}