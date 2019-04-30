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

        public void Run()
        {
            _sprites = new SpritesManager();
            _sprites.Initialized();

            _input = new Input(this);
            _map = new Map(this);
            _window = new WindowRenderer(this);

            _window.Render.KeyPressed += _input.IsKeyPressed;
            
            Gameloop();
        }

        public void Gameloop()
        {
            while (_window.Render.IsOpen)
            {
                _window.Render.DispatchEvents();
                _window.Render.Clear();

                _map.PrintMap(50,50);
                _map.GetVillage.DrawCastle();
                _map.GetVillage.DrawBuilding();
                _window.Render.View = _window.GetView.Render;
                _window.PrintCursor();
                
                _window.Render.Display();
            }

        }
        public SpritesManager Sprites { get { return _sprites; } }
        public WindowRenderer GetWindow { get { return _window; } }
        public Map GetMap { get { return _map; } }
        public void Close() { _window.Render.Close(); }
    }
}
