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

        uint _width;
        uint _height;

        Dictionary<Vector2i, Hut> _grid;

        public Map(WindowRenderer window)
        {
            _window = window;

            Texture texture = new Texture("../../../../images/test.png");
            _sprite = new Sprite(texture);

            _width = texture.Size.X;
            _height = texture.Size.Y;
            Console.WriteLine("Width : " + _width);
            Console.WriteLine("Height : " + _height);
        }

        public void PrintMap()
        {
            _window.Draw(_sprite);
        }

        public WindowRenderer GetWindow
        {
            get { return _window; }
        }
        public uint MapHeight() => _height;
        public uint MapWidth() => _width;

        public void CreateGrid()
        {
            int l = -23;
            for (int i = 0; i < 460; i += 10)
            {
                int h = -16;
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
