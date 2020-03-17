using System;

namespace ConsoleApp8
{
    class Plant
    {
        double growth;
        int photosensitivity;
        int frostresistance;

        public Plant(double growth, int frostresistance, int photosensitivity)
        {
            Growth = growth;
            Frostresistance = frostresistance;
            Photosensitivity = photosensitivity;
        }

        public double Growth { get => growth; set => growth = value; }

        public int Frostresistance
        {
            get => frostresistance;
            set
            {
                if (value >= 0 & value <= 100)
                    frostresistance = value;
                else throw new PlantException("Frostresistance shold be between 0 and 100");
            }
        }
        public int Photosensitivity
        {
            get => photosensitivity;
            set
            {
                if (value >= 0 & value <= 100)
                    photosensitivity = value;
                else throw new PlantException("Photosensitivity should be between 0 and 100");
            }
        }

        public override string ToString() => $"Growth: {Growth:f3}; " +
            $"\nFrostresistance: {Frostresistance}; " +
            $"\nPhotosensitivity: {Photosensitivity}\n ";

        public static void ShowInfo(Plant x)
        {
            Console.WriteLine(x.ToString());
        }
    }
    class Program
    {
        public static int isEven(Plant a, Plant b)
        {
            if (a.Photosensitivity % 2 != 0 & b.Photosensitivity % 2 == 0) return 1;
            if (a.Photosensitivity == b.Photosensitivity) return 0;
            return -1;
        }

        public static Plant changeFrostresistance(Plant a)
        {
            if (a.Frostresistance % 2 == 0) a.Frostresistance /= 3;
            if (a.Frostresistance % 2 != 0 & a.Frostresistance < 50) a.Frostresistance *= 2;
            return a;
        }

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Plant[] plants = new Plant[n];
            for (int i = 0; i < plants.Length; i++)
            {
                plants[i] = new Plant(rnd.Next(25, 100) + rnd.NextDouble(),
                    rnd.Next(0, 80), rnd.Next(0, 100));
            }

            Action<Plant> Print = new Action<Plant>(Plant.ShowInfo);
            Array.ForEach(plants, Print);

            Console.WriteLine("\n***\nSorted by the lowest growth:\n");
            Array.Sort(plants, delegate (Plant a, Plant b)
            {
                if (a.Growth > b.Growth) return 1;
                if (a.Growth == b.Growth) return 0;
                return -1;
            });
            Array.ForEach(plants, Print);

            Console.WriteLine("\n***\nSorted by the highest fostresistance:\n");
            Array.Sort(plants, (a, b) =>
            {
                if (a.Frostresistance < b.Frostresistance) return 1;
                if (a.Frostresistance == b.Frostresistance) return 0;
                return -1;
            });
            Array.ForEach(plants, Print);

            Console.WriteLine("\n***\nSorted by the parity of photosensitivity:\n");
            Array.Sort(plants, isEven);
            Array.ForEach(plants, Print);

            Console.WriteLine("\n***\nChanged frostresistance:\n");
            Array.ConvertAll(plants, new Converter<Plant, Plant>(changeFrostresistance));
            Array.ForEach(plants, Print);

            Console.ReadKey();
        }
    }
}
