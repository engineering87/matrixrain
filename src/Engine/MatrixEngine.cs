// (c) 2025 Francesco Del Re <francesco.delre.87@gmail.com>
// This code is licensed under MIT license (see LICENSE.txt for details)
using MatrixRain.Renderer;

namespace MatrixRain.Engine
{
    public class MatrixEngine
    {
        private readonly RainRenderer _renderer;

        static async Task Main()
        {
            var engine = new MatrixEngine();
            await engine.StartAsync();
        }

        public MatrixEngine()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
            Console.Clear();

            _renderer = new RainRenderer();
        }

        public async Task StartAsync()
        {
            while (true)
            {
                _renderer.DrawRain();
                await Task.Delay(35);
            }
        }
    }
}

