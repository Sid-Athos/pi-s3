using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}

namespace LastBastion.UI
{
    class Map
    {
        Game _game;

        Village _village;

        uint _width;
        uint _height;

        Dictionary<Vector2i, Hut> _grid;

        public Map(Game game)
        {
            _game = game;

            _grid = new Dictionary<Vector2i, Hut>();

            _width = 50;
            _height = 50;
            //Console.WriteLine("Width : " + _width);
            //Console.WriteLine("Height : " + _height);
            
            CreateGrid(50,50);
            
            _village = new Village(this);
        }
        
        public void PrintMap(int x, int y)
        {
            foreach (var item in _grid)
            {
                _game.Sprites.GetSprite("Tile").Position = item.Value.GetVecHut;
                _game.GetWindow.Render.Draw(_game.Sprites.GetSprite("Tile"));
            }
        }

        public Game GetGame => _game;
        public Village GetVillage { get { return _village; } }
        public uint MapHeight => _height;
        public uint MapWidth => _width;
        public Dictionary<Vector2i, Hut> GetGrid => _grid;

        public void CreateGrid(int x, int y)
        {
            int l = -1*(x/2);
            for (float i = 7.5f; i < 50 * 15; i += 15)
            {
                int h = -1*(y/2);
                for (float j = 7.5f; j < 50 * 15; j += 15)
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
