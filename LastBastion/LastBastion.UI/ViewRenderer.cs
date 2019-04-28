using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace test
{
    class ViewRenderer : View
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
            _view = new View(new Vector2f(100, 100), new Vector2f(200, 200));
            _XDim = 200;
            _YDim = 200;

            _pos = new Vector2i(_XPos, _YPos);
            _view.Center = _window.GetMap.GetGrid()[_pos].GetVecHut;
            _XPos = 0;
            _YPos = 0;

            _dim = new Vector2f(_XDim, _YDim);
        }
        public View GetView => _view;
        public void ViewUp()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos, _YPos -1)))
            {
                _YPos -= 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = _window.GetMap.GetGrid()[_pos].GetVecHut;
            }
        }
        public void ViewDown()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos, _YPos + 1)))
            {
                _YPos += 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = _window.GetMap.GetGrid()[_pos].GetVecHut;
            }
        }
        public void ViewRight()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos + 1, _YPos)))
            {
                _XPos += 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = _window.GetMap.GetGrid()[_pos].GetVecHut;
            }
        }
        public void ViewLeft()
        {
            if (_window.GetMap.GetGrid().ContainsKey(new Vector2i(_XPos - 1, _YPos)))
            {
                _XPos -= 1;
                _pos = new Vector2i(_XPos, _YPos);
                _view.Center = _window.GetMap.GetGrid()[_pos].GetVecHut;
            }
        }
        public void zoom()
        {
            _XDim += 20;
            _YDim += 20;
            _dim = new Vector2f(_XDim,_YDim);
            _view.Size = _dim;
        }
        public void dezoom()
        {
            _XDim -= 20;
            _YDim -= 20;
            _dim = new Vector2f(_XDim, _YDim);
            _view.Size = _dim;
        }
        public Vector2i GetPos => _pos;
        public Vector2f GetDim => _dim;
    }
}
