using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
//[]
namespace LastBastion.UI
{
    class Game
    {

        WindowRenderer _window;
        Map _map;

        Input _input;

        SpritesManager _sprites;
        Random _random = new Random();
        
        bool _pause;
        Vector2f _cursorPosition;

        public void Run()
        {
            _sprites = new SpritesManager();
            _sprites.Initialized();
            
            _pause = true;
            _input = new Input(this);
            _map = new Map(this);
            _window = new WindowRenderer(this);
            _window.Render.SetMouseCursorVisible(false);

            _window.Render.KeyPressed += _input.IsKeyPressed;
            _window.Render.MouseMoved += MoveCursor;
            
            Gameloop();
        }

        public void Gameloop()
        {
            while (_window.Render.IsOpen)
            {
                _window.Render.DispatchEvents();
                _window.Render.Clear();

                _map.PrintMap(50, 50);
                _map.GetVillage.DrawCastle();
                _map.GetVillage.DrawBuilding();
                _window.Render.View = _window.GetView.Render;
                _window.PrintCursor();

                _window.Render.Display();
            }

        }

        public int RandomNumber(int min, int max) => _random.Next(min, max);
        public void Close() { _window.Render.Close(); }

        public void Pause() { _pause = !_pause; }

        public SpritesManager Sprites { get { return _sprites; } }
        public WindowRenderer GetWindow { get { return _window; } }
        public Map GetMap { get { return _map; } }
        public Random GetRDM => _random;
        public Vector2f CursorPosition => _cursorPosition;
        
        public void MoveCursor(object sender, MouseMoveEventArgs e)
        {
            _cursorPosition = new Vector2f((float)e.X,(float)e.Y);
        }
    }
}
