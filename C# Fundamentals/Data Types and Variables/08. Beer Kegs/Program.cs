using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            double maxVolume = 0;
            string maxVolumeKegsModel = string.Empty;


            for (int i = 0; i < n; i++)
            {
                // int num = int.Parse(Console.ReadLine());
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxVolumeKegsModel = model;
                }

            }
            Console.WriteLine(maxVolumeKegsModel);
        }
    }
}
