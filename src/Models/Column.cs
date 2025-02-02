// (c) 2025 Francesco Del Re <francesco.delre.87@gmail.com>
// This code is licensed under MIT license (see LICENSE.txt for details)
using MatrixRain.Utils;

namespace MatrixRain.Models
{
    public class Column
    {
        private readonly int _x;
        private int _y;
        private readonly int _length;
        private static readonly char[] chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz@#$%^&*()".ToCharArray();

        public Column(int x, int startY)
        {
            _x = x;
            _y = startY;
            _length = RandomHelper.GetRandomInt(15, 30);
        }

        public void Update(int height)
        {
            Console.SetCursorPosition(_x, _y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(chars[RandomHelper.GetRandomInt(0, chars.Length)]);

            for (int i = 1; i < _length; i++)
            {
                int fadePos = (_y - i + height) % height;
                Console.SetCursorPosition(_x, fadePos);
                Console.Write(chars[RandomHelper.GetRandomInt(0, chars.Length)]);
            }

            int erasePos = (_y - _length + height) % height;
            Console.SetCursorPosition(_x, erasePos);
            Console.Write(' ');

            _y = (_y + 1) % height;
        }
    }
}
