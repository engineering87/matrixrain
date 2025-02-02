// (c) 2025 Francesco Del Re <francesco.delre.87@gmail.com>
// This code is licensed under MIT license (see LICENSE.txt for details)
using MatrixRain.Models;

namespace MatrixRain.Renderer
{
    public class RainRenderer
    {
        private static readonly Random random = new();
        private readonly Column[] _columns;
        private readonly int _width, _height;

        public RainRenderer()
        {
            _width = Console.WindowWidth;
            _height = Console.WindowHeight;
            _columns = new Column[_width / 2];

            for (int i = 0; i < _columns.Length; i++)
            {
                _columns[i] = new Column(i * 2, random.Next(_height));
            }
        }

        public void DrawRain()
        {
            foreach (var column in _columns)
            {
                column.Update(_height);
            }
        }
    }
}