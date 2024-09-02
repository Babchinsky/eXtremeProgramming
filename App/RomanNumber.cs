namespace App
{
    public record RomanNumber(int Value)
    {
        private readonly int _value = Value;
        public int Value => _value;

        public static RomanNumber Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new RomanNumber(0);

            var numeralMap = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;
            int prevValue = 0;

            foreach (char c in input.ToUpper())
            {
                if (numeralMap.TryGetValue(c, out int value))
                {
                    if (value > prevValue)
                        total += value - 2 * prevValue;
                    else
                        total += value;

                    prevValue = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid Roman numeral character: {c}");
                }
            }

            return new RomanNumber(total);
        }
    }
}