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
        /// <summary>
        /// Components
        /// </summary>
        WindowRenderer _window;
        Map _map;
        /// <summary>
        /// Game Timer Variables
        /// </summary>
        int _countTimer;
        int _sec;
        bool MinutePass = true;
        bool _pause;
        int _cycle;
        /// <summary>
        /// Managers
        /// </summary>
        SpritesManager _sprites;
        /// <summary>
        /// Other Ressources
        /// </summary>
        Random _random = new Random();
        Vector2f _cursorPosition;
        Input _input;

        public void Run()
        {
            _sprites = new SpritesManager();
            _sprites.Initialized();

            _countTimer = 300;
            _sec = DateTime.Now.Second;
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

                
                if (_pause)
                {
                    TimerUpdate();
                }
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

        public void Pause() { _pause = !_pause; Console.WriteLine(_pause); }

        public SpritesManager Sprites { get { return _sprites; } }
        public WindowRenderer GetWindow { get { return _window; } }
        public Map GetMap { get { return _map; } }
        public Random GetRDM => _random;
        public Vector2f CursorPosition => _cursorPosition;
        public int GetTimer => _countTimer;
        public bool IsStop => !_pause;
        
        public void MoveCursor(object sender, MouseMoveEventArgs e)
        {
            _cursorPosition = new Vector2f((float)e.X,(float)e.Y);
        }

        public void TimerUpdate()
        {
            if (DateTime.Now.Second == 1 && MinutePass == true)
            {
                _sec = 1;
                _countTimer += 2;
                MinutePass = false;
                Console.WriteLine(_countTimer);
            }
            else
            {
                if (_sec < DateTime.Now.Second)
                {
                    _sec = DateTime.Now.Second;
                    _countTimer++;
                    Console.WriteLine(_countTimer);
                }
                if (DateTime.Now.Second == 2 && MinutePass == false)
                {
                    MinutePass = true;
                }
            }
            if (_countTimer == 361)
            {
                _cycle++;
                _countTimer = 1;
            }
        }
    }
}
