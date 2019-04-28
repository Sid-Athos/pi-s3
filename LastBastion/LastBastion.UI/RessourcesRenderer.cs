using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace test
{
    class RessourcesRenderer
    {
        Map _map;
        WindowRenderer _window;

        uint _height;
        uint _width;

        Sprite _sprite;

        public RessourcesRenderer(Map map, WindowRenderer window,string ressource)
        {
            _map = map;
            _window = window;

            switch (ressource)
            {
                case "Wood":
                    Texture texture = new Texture("../../../../images/Wood.png");
                    _sprite = new Sprite(texture);

                    _width = texture.Size.X;
                    _height = texture.Size.Y;
                    break;
                default:
                    break;
            }
        }
    }
}
