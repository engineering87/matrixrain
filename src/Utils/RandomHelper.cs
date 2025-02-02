// (c) 2025 Francesco Del Re <francesco.delre.87@gmail.com>
// This code is licensed under MIT license (see LICENSE.txt for details)
namespace MatrixRain.Utils
{
    public static class RandomHelper
    {
        private static readonly Random random = new();

        public static int GetRandomInt(int min, int max) => random.Next(min, max);
    }
}