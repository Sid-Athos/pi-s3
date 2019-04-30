using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace LastBastion.UI
{
    class ViewRenderer : View
    {
        WindowRenderer _window;
        View _view;

        int _x;
        int _y;

        public ViewRenderer(WindowRenderer window)
        {
            _window = window;
            _view = new View(new Vector2f(100, 100), new Vector2f(200, 200));

            _view.Center = _window.GetGame.GetMap.GetGrid[new Vector2i(0,0)].GetVecHut;
            _x = 0;
            _y = 0;
            //Console.WriteLine(_window.GetGame.GetMap.GetGrid[new Vector2i(0, 0)].GetName);
        }
        public View Render => _view;
        public void ViewUp()
        {
            if (_window.GetGame.GetMap.GetGrid.ContainsKey(new Vector2i(_x, _y -1)))
            {
                _y -= 1;
                _view.Center = _window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetVecHut;
                Console.WriteLine(_window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetName);
            }
        }
        public void ViewDown()
        {
            if (_window.GetGame.GetMap.GetGrid.ContainsKey(new Vector2i(_x, _y + 1)))
            {
                _y += 1;
                _view.Center = _window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetVecHut;
                Console.WriteLine(_window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetName);
            }
        }
        public void ViewRight()
        {
            if (_window.GetGame.GetMap.GetGrid.ContainsKey(new Vector2i(_x + 1, _y)))
            {
                _x += 1;
                _view.Center = _window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetVecHut;
                Console.WriteLine(_window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetName);
            }
        }
        public void ViewLeft()
        {
            if (_window.GetGame.GetMap.GetGrid.ContainsKey(new Vector2i(_x - 1, _y)))
            {
                _x -= 1;
                _view.Center = _window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetVecHut;
                Console.WriteLine(_window.GetGame.GetMap.GetGrid[new Vector2i(_x, _y)].GetName);
            }
        }
        public void zoom()
        {
            _view.Size = new Vector2f(_view.Size.X + 20, _view.Size.Y +20);
        }
        public void dezoom() { _view.Size = new Vector2f(_view.Size.X - 20, _view.Size.Y - 20); }
    }
}
