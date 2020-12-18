using System;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            var random = new Random(seed);
            double x = 1;
            double y = 0;
            pixels.SetPixel(x, y);
            for (var i = 1; i <= iterationsCount; i++)
            {
                var nextNumber = random.Next(2);
                double x1;
                double y1;
                if (nextNumber == 0)
                {
                    x1 = (x * Math.Cos(0.785398) - y * Math.Sin(0.785398)) / Math.Sqrt(2);
                    y1 = (x * Math.Sin(0.785398) + y * Math.Cos(0.785398)) / Math.Sqrt(2);
                }
                else
                {
                    x1 = (x * Math.Cos(2.356194) - y * Math.Sin(2.356194)) / Math.Sqrt(2) + 1;
                    y1 = (x * Math.Sin(2.356194) + y * Math.Cos(2.356194)) / Math.Sqrt(2);
                }
                pixels.SetPixel(x1, y1);
                x = x1;
                y = y1;
            }
        }
	}
}