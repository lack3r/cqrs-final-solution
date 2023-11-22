using NUnit.Framework;

namespace WebFrontend
{
    public static class StaticData
    {
        public class MenuItem
        {
            public int MenuNumber;
            public string Description;
            public decimal Price;
            public bool IsDrink;
        }

        private static List<MenuItem> menu =
        [
            new()
            {
                MenuNumber = 1,
                Description = "Coke",
                Price = 1.50M,
                IsDrink = true
            },
            new()
            {
                MenuNumber = 2,
                Description = "Cyprus Coffee",
                Price = 1.20M,
                IsDrink = true
            },
            new()
            {
                MenuNumber = 3,
                Description = "Freddo Espresso",
                Price = 2.50M,
                IsDrink = true
            },
            new()
            {
                MenuNumber = 4,
                Description = "KEO Tsakrin",
                Price = 3.50M,
                IsDrink = true
            },
            new()
            {
                MenuNumber = 5,
                Description = "Leon Beer",
                Price = 4.50M,
                IsDrink = true
            },
            new()
            {
                MenuNumber = 10,
                Description = "Mix - Souvlaki Sheftalies",
                Price = 6.50M
            },
            new()
            {
                MenuNumber = 11,
                Description = "Sikotakia",
                Price = 9.50M
            },
            new()
            {
                MenuNumber = 12,
                Description = "Patatoues Tianites gia to moron",
                Price = 3.50M
            },
            new()
            {
                MenuNumber = 13,
                Description = "Ofton Kleftiko",
                Price = 8.00M
            },
            new()
            {
                MenuNumber = 14,
                Description = "Sushi se Kipriaki Pitta",
                Price = 25.50M
            },
        ];
        private static readonly List<string> value = [
            "Nicolas Iacovides",
            "Haris Cannas",
            "Anastasis Anastasi",
            "Panos Achilleos",
            "Giannis Christodoulou",
            "Michalis Tsaeras"
                ];
        private static List<string> waitStaff = value;

        public static List<MenuItem> Menu { get => menu; set => menu = value; }
        public static List<string> WaitStaff { get => waitStaff; set => waitStaff = value; }
    }
}