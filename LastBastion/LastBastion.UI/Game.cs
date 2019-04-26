using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
//[]
namespace test
{
    class Game
    {
        string _name = "MY Litle Test";

        WindowRenderer _window;
        Input _input;

        ViewRenderer _view0;

        public void Run()
        {
            SFML.WindowNative.Load();
            SFML.GraphicsNative.Load();

            _input = new Input(this);
            _window = new WindowRenderer(VideoMode.DesktopMode.Height/2,VideoMode.DesktopMode.Width/2,_name);

            _window.KeyPressed += _input.IsKeyPressed;
            
            Gameloop();
        }

        public void Gameloop()
        {
            while (_window.IsOpen)
            {
                _window.DispatchEvents();
                _window.Clear();

                _window.GetMap.PrintMap();
                _window.View = _window.GetViews;

                _window.Display();
            }

        }

        public WindowRenderer GetWindow
        {
            get { return _window; }
        }

        public void Close()
        {
            _window.Close();
        }
    }
}
