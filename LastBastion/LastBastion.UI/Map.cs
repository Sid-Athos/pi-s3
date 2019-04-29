using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}

namespace test
{
    class Map
    {
        WindowRenderer _window;
        Sprite _sprite;

        Sprite _tile;

        Sprite _Curse;
        Sprite _CurseFont;
        Sprite _CurseBoard;

        uint _width;
        uint _height;

        Dictionary<Vector2i, Hut> _grid;

        public Map(WindowRenderer window)
        {
            _window = window;
            _grid = new Dictionary<Vector2i, Hut>();
            //AAA
            Texture texture = new Texture("../../../../images/test.png");
            _sprite = new Sprite(texture);

            _width = 50*15;
            _height = 50*15;
            Console.WriteLine("Width : " + _width);
            Console.WriteLine("Height : " + _height);
            //AAA

            texture = new Texture("../../../../images/tile.png");
            _tile = new Sprite(texture);
            CreateGrid(50,50);

            texture = new Texture("../../../../images/wood.png");
            _Curse = new Sprite(texture);
            _Curse.Color = new Color(30, 144, 255, 128);

            texture = new Texture("../../../../images/CursorFont.png");
            _CurseFont = new Sprite(texture);
            _CurseFont.Color = new Color(30, 144, 255, 128);

            texture = new Texture("../../../../images/CursorBoard.png");
            _CurseBoard = new Sprite(texture);

        }

        public void PrintMap()
        {
            _window.GetWindow.Draw(_sprite);
        }
        public void PrintMap(int x, int y)
        {
            foreach (var item in _grid)
            {
                _tile.Position = item.Value.GetVecHut;
                _tile.Scale = new Vector2f(1f,1f);
                _window.GetWindow.Draw(_tile);
            }
        }
        public void PrintCursor()
        {
            //_Curse.Position = _window.GetViewRenderer.GetView.Center;
            _CurseFont.Position = _window.GetViewRenderer.GetView.Center;
            _CurseBoard.Position = _window.GetViewRenderer.GetView.Center;
            _window.GetWindow.Draw(_CurseFont);
            _window.GetWindow.Draw(_CurseBoard);
        }
        public WindowRenderer GetWindow
        {
            get { return _window; }
        }
        public uint MapHeight() => _height;
        public uint MapWidth() => _width;

        public Dictionary<Vector2i, Hut> GetGrid() => _grid;

        public void CreateGrid(int x, int y)
        {
            int l = -1*(x/2);
            for (float i = 0; i < 50 * 15; i += 15)
            {
                int h = -1*(y/2);
                for (float j = 0; j < 50 * 15; j += 15)
                {
                    Hut NewH = new Hut(new Vector2f(i,j), "[ " +l + " ; " + h + " ]");
                    _grid.Add(new Vector2i(l,h), NewH);
                    h++;
                }
                l++;
            }
        }
    }
}
