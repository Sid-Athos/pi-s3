using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace test
{
    class ViewRenderer
    {
        WindowRenderer _window;
        View _view;

        Vector2f _dim;
        Vector2i _pos;

        float _XDim;
        float _YDim;
        int _XPos;
        int _YPos;

        public ViewRenderer(WindowRenderer window,float Xdim, float Ydim, float XPos, float YPos)
        {
            _window = window;
            _view = new View();
            _XDim = 7.5f + 20*15;
            _YDim = 7.5f + 20*15;
            _dim = new Vector2f(_XDim, _YDim);
            _view.Size = new Vector2f(_XDim, _YDim);

            _pos = new Vector2i(_XPos, _YPos);
            _view.Center = new Vector2f(_window.GetMap.GetGrid()[_pos].GetVecHut.X + 7.5f, _window.GetMap.GetGrid()[_pos].GetVecHut.Y + 7.5f);
            _XPos = 0;
            _YPos = 0;

            Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetName);
        }
        public View GetView => _view;
        public void ViewUp()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos, _YPos -1)))
            {
                _YPos -= 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = new Vector2f(_window.GetMap.GetGrid()[_pos].GetVecHut.X + 7.5f, _window.GetMap.GetGrid()[_pos].GetVecHut.Y + 7.5f);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetVecHut.X + " : " + _window.GetMap.GetGrid()[_pos].GetVecHut.Y);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetName);
            }
        }
        public void ViewDown()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos, _YPos + 1)))
            {
                _YPos += 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = new Vector2f(_window.GetMap.GetGrid()[_pos].GetVecHut.X + 7.5f, _window.GetMap.GetGrid()[_pos].GetVecHut.Y + 7.5f);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetVecHut.X + " : " + _window.GetMap.GetGrid()[_pos].GetVecHut.Y);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetName);
            }
        }
        public void ViewRight()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos + 1, _YPos)))
            {
                _XPos += 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = new Vector2f(_window.GetMap.GetGrid()[_pos].GetVecHut.X + 7.5f, _window.GetMap.GetGrid()[_pos].GetVecHut.Y + 7.5f);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetVecHut.X + " : " + _window.GetMap.GetGrid()[_pos].GetVecHut.Y);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetName);
            }
        }
        public void ViewLeft()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos - 1, _YPos)))
            {
                _XPos -= 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = new Vector2f(_window.GetMap.GetGrid()[_pos].GetVecHut.X + 7.5f, _window.GetMap.GetGrid()[_pos].GetVecHut.Y + 7.5f);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetVecHut.X + " : " + _window.GetMap.GetGrid()[_pos].GetVecHut.Y);
                Console.WriteLine(_window.GetMap.GetGrid()[_pos].GetName);
            }
        }
        public void zoom()
        {
            _XDim += 15;
            _YDim += 15;
            _dim = new Vector2f(_XDim,_YDim);
            _view.Size = _dim;
        }
        public void dezoom()
        {
            _XDim -= 15;
            _YDim -= 15;
            _dim = new Vector2f(_XDim, _YDim);
            _view.Size = _dim;
        }
        public Vector2i GetPos => _pos;
        public Vector2f GetDim => _dim;
    }
}
