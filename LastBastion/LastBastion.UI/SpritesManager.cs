using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
//[]

namespace LastBastion.UI
{
    class SpritesManager
    {
        Dictionary<string, Sprite> _sprites;

        public SpritesManager()
        {
            _sprites = new Dictionary<string, Sprite>();
            Initialized();
        }

        public void Initialized()
        {
            Texture texture;

            texture = new Texture("../../../../images/test.png");
            _sprites.Add("Map",new Sprite(texture));

            texture = new Texture("../../../../images/tile.png");
            _sprites.Add("Tile", new Sprite(texture));

            texture = new Texture("../../../../images/wood.png");
            _sprites.Add("Wood", new Sprite(texture));

            texture = new Texture("../../../../images/CursorFont.png");
            _sprites.Add("CursorFont", new Sprite(texture));

            texture = new Texture("../../../../images/CursorBoard.png");
            _sprites.Add("CursorBoard", new Sprite(texture));
        }
    }
}
