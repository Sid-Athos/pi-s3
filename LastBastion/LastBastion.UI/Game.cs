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
        string _name = "Last Bastion";

        WindowRenderer _window;
        Input _input;
        

        public void Run()
        {
            //SFML.WindowNative.Load();
            //SFML.GraphicsNative.Load();

            _input = new Input(this);
            _window = new WindowRenderer(VideoMode.DesktopMode.Height/2,VideoMode.DesktopMode.Width/2,_name);
            
            _window.GetWindow.KeyPressed += _input.IsKeyPressed;
            //Console.WriteLine(_window.GetViewRenderer.GetDim.X);
            
            Gameloop();
        }

        public void Gameloop()
        {
            while (_window.GetWindow.IsOpen)
            {
                _window.GetWindow.DispatchEvents();
                _window.GetWindow.Clear();

                _window.GetMap.PrintMap(50,50);
                _window.GetWindow.View = _window.GetViewRenderer.GetView;
                _window.GetMap.PrintCursor();
                
                _window.GetWindow.Display();
            }

        }

        public WindowRenderer GetWindow
        {
            get { return _window; }
        }

        public void Close()
        {
            _window.GetWindow.Close();
        }
    }
}
