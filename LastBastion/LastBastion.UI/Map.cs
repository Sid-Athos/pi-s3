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
                _window.GetWindow.Draw(_tile);
            }
        }
        public void PrintCursor()
        {
            _Curse.Position = _window.GetViewRenderer.GetView.Center;
            _window.GetWindow.Draw(_Curse);
        }
        public WindowRenderer GetWindow
        {
            get { return _window; }
        }
        public uint MapHeight() => _height;
        public uint MapWidth() => _width;

        public void CreateGrid(int x, int y)
        {
            int l = -1*(x/2);
            for (int i = 0; i < 460; i += 10)
            {
                int h = -1*(y/2);
                for (int j = 0; j < 320; j += 10)
                {
                    Hut NewH = new Hut(new Vector2f(i+5.5f,j+5.5f));
                    _grid.Add(new Vector2i(l,h), NewH);
                    h++;
                }
                l++;
            }
        }
    }
}
