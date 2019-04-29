using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}

namespace test
{
    class Village
    {
        Map _map;
        Dictionary<Vector2i, Hut> _grid;

        WindowRenderer _window;

        Sprite _sprite;
        Sprite _castle;
        Sprite _house;
        Sprite _sawmill;

        List<Hut> _nearby;
        int _area;

        Random _random = new Random();

        public Village(Map map, Dictionary<Vector2i, Hut> grid, WindowRenderer window)
        {
            _map = map;
            _grid = grid;
            _window = window;
            _nearby = new List<Hut>();
            _area = 3;
            BuilingRenderer();
            SetNearby();
            Console.WriteLine(_nearby.Count);
        }

        public void SetNearby()
        {
            for (int i = -1*_area+1; i < _area; i++)
            {
                for (int j = -1*_area+1; j < _area; j++)
                {
                    if(!_grid[new Vector2i(i, j)].IsBusy())
                    {
                        _nearby.Add(_grid[new Vector2i(i, j)]);
                    }
                }
            }
        }

        public int RandomNumber(int min, int max) => _random.Next(min, max);

        public void CreateBuilding(string name)
        {
            if (_nearby.Count > 0)
            {
                int _random = RandomNumber(0, _nearby.Count - 1);
                foreach (var item in _grid)
                {
                    if (item.Value == _nearby[_random])
                    {
                        item.Value.SetBuilding(name);
                    }
                }
                _nearby.Remove(_nearby[_random]);
                _nearby = RebuildeMegaGreatConstructor();
            }
            if (_nearby.Count == 0)
            {
                _area++;
                SetNearby();
            }
            Console.WriteLine(_nearby.Count);
        }

        public List<Hut> RebuildeMegaGreatConstructor()
        {
            List<Hut> newList = new List<Hut>();
            foreach (var item in _nearby)
            {
                newList.Add(item);
            }
            return newList;
        }

        public void BuilingRenderer()
        {
            Texture texture = new Texture("../../../../images/test.png");
            _sprite = new Sprite(texture);

            texture = new Texture("../../../../images/castle.png");
            _castle = new Sprite(texture);
            _grid[new Vector2i(-1, 0)].SetBuilding("Castle");
            _grid[new Vector2i(-1, 1)].SetBuilding("Castle");
            _grid[new Vector2i(-1, -1)].SetBuilding("Castle");
            _grid[new Vector2i(0, 0)].SetBuilding("Castle");
            _grid[new Vector2i(0, 1)].SetBuilding("Castle");
            _grid[new Vector2i(0, -1)].SetBuilding("Castle");
            _grid[new Vector2i(1, 0)].SetBuilding("Castle");
            _grid[new Vector2i(1, 1)].SetBuilding("Castle");
            _grid[new Vector2i(1, -1)].SetBuilding("Castle");
            texture = new Texture("../../../../images/house.png");
            _house = new Sprite(texture);
            texture = new Texture("../../../../images/sawmill.png");
            _sawmill = new Sprite(texture);
        }
        public void DrawBuilding()
        {
            foreach (var item in _grid)
            {
                if (item.Value.IsBusy())
                {
                    if (item.Value.GetName == "House")
                    {
                        _house.Position = item.Value.GetVecHut;
                        _window.GetWindow.Draw(_house);
                    }
                    if (item.Value.GetName == "Sawmill")
                    {
                        _sawmill.Position = item.Value.GetVecHut;
                        _window.GetWindow.Draw(_house);
                    }
                }
            }
        }

        public void DrawCastle()
        {
            _castle.Position = _grid[new Vector2i(-1, -1)].GetVecHut;
            _window.GetWindow.Draw(_castle);
        }
    }
}
