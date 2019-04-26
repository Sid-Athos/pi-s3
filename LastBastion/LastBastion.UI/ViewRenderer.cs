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

        Vector2f _dim;
        Vector2f _pos;

        float _XDim;
        float _YDim;
        float _XPos;
        float _YPos;

        public ViewRenderer(WindowRenderer window,float Xdim, float Ydim, float XPos, float YPos) : base (new Vector2f(100, 100), new Vector2f(200, 200))
        {
            _window = window;
            _XDim = 200;
            _YDim = 200;
            _XPos = 100;
            _YPos = 100;

            _dim = new Vector2f(200,200);
            _pos = new Vector2f(100, 100);
        }

        public void ViewUp()
        {
            _YPos -= 10;
            _pos = new Vector2f(_XPos,_YPos);
            this.Center = _pos;
        }
        public void ViewDown()
        {
            _YPos += 10;
            _pos = new Vector2f(_XPos, _YPos);
            this.Center = _pos;
        }
        public void ViewRight()
        {
            _XPos += 10;
            _pos = new Vector2f(_XPos, _YPos);
            this.Center = _pos;
        }
        public void ViewLeft()
        {
            _XPos -= 10;
            _pos = new Vector2f(_XPos, _YPos);
            this.Center = _pos;
        }
        public Vector2f GetPos => _pos;
    }
}
