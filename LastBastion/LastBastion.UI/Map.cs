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
            CreateMap();
        }
        
        public void PrintMap(int x, int y)
        {
            foreach (var item in _grid)
            {
                if (_game.GetTimer >= 180)
                {
                    _game.Sprites.GetSprite("TileWinter").Scale = new Vector2f(_game.Sprites.GetSprite("TileWinter").Scale.X, _game.Sprites.GetSprite("TileWinter").Scale.Y);
                    _game.Sprites.GetSprite("TileWinter").Position = item.Value.GetVecHut;
                    _game.GetWindow.Render.Draw(_game.Sprites.GetSprite("TileWinter"));
                }
                else
                {
                    _game.Sprites.GetSprite("Tile").Scale = new Vector2f(_game.Sprites.GetSprite("Tile").Scale.X, _game.Sprites.GetSprite("Tile").Scale.Y);
                    _game.Sprites.GetSprite("Tile").Position = item.Value.GetVecHut;
                    _game.GetWindow.Render.Draw(_game.Sprites.GetSprite("Tile"));
                }
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
            for (float i = 0; i < 50 * 15; i += 15)
            {
                int h = -1*(y/2);
                for (float j = 0f; j < 50 * 15; j += 15)
                {
                    Hut NewH = new Hut(new Vector2f(i,j), "[ " +l + " ; " + h + " ]", new Vector2i(l,h));
                    _grid.Add(new Vector2i(l,h), NewH);
                    h++;
                }
                l++;
            }
        }
        public void CreateMap()
        {
            foreach (var item in _grid)
            {
                if (item.Value.GetName == "Empty")
                {
                    string choice = NearbyHutOk(item.Value);
                    int spawnC = 15;
                    int RDM = _game.RandomNumber(0, 100);
                    if (choice == "Empty")
                    {
                        if (RDM <= spawnC)
                        {
                            RDM = _game.RandomNumber(0, 100);
                            if (RDM <= 33)
                            {
                                item.Value.SetBuilding("Wood");
                            }
                            if (RDM >= 66)
                            {
                                item.Value.SetBuilding("Stone");
                            }
                            if (RDM < 66 && RDM > 33)
                            {
                                item.Value.SetBuilding("Bush");
                            }
                        }
                    }
                    else
                    {
                        if (choice != "Bad")
                        {
                            RDM = _game.RandomNumber(0, 100);
                            if (RDM <= spawnC + spawnC/2)
                            {
                                item.Value.SetBuilding(choice);
                            }
                        }
                    }
                }
            }
        }
        public string NearbyHutOk(Hut hut)
        {
            string result = "Empty";
            if (_grid.ContainsKey(new Vector2i(hut.GetVector.X - 1, hut.GetVector.Y)) && _grid[new Vector2i(hut.GetVector.X - 1, hut.GetVector.Y)].GetName != "Empty")
            {
                result = _grid[new Vector2i(hut.GetVector.X - 1, hut.GetVector.Y)].GetName;
            }
            if (_grid.ContainsKey(new Vector2i(hut.GetVector.X + 1, hut.GetVector.Y)) && _grid[new Vector2i(hut.GetVector.X + 1, hut.GetVector.Y)].GetName != "Empty")
            {
                if (result != _grid[new Vector2i(hut.GetVector.X + 1, hut.GetVector.Y)].GetName && result != "Empty")
                {
                    return "Bad";
                }
                else
                {
                    result = _grid[new Vector2i(hut.GetVector.X + 1, hut.GetVector.Y)].GetName;
                }
            }
            if (_grid.ContainsKey(new Vector2i(hut.GetVector.X, hut.GetVector.Y - 1)) && _grid[new Vector2i(hut.GetVector.X, hut.GetVector.Y - 1)].GetName != "Empty")
            {
                if (result != _grid[new Vector2i(hut.GetVector.X, hut.GetVector.Y - 1)].GetName && result != "Empty")
                {
                    return "Bad";
                }
                else
                {
                    result = _grid[new Vector2i(hut.GetVector.X, hut.GetVector.Y - 1)].GetName;
                }
            }
            if (_grid.ContainsKey(new Vector2i(hut.GetVector.X, hut.GetVector.Y + 1)) && _grid[new Vector2i(hut.GetVector.X, hut.GetVector.Y + 1)].GetName != "Empty")
            {
                if (result != _grid[new Vector2i(hut.GetVector.X, hut.GetVector.Y + 1)].GetName && result != "Empty")
                {
                    return "Bad";
                }
                else
                {
                    result = _grid[new Vector2i(hut.GetVector.X, hut.GetVector.Y + 1)].GetName;
                }
            }
            return result;
        }
    }
}
