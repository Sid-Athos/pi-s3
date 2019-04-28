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

        List<Hut> _nearby;
        int _area;

        public Village(Map map, Dictionary<Vector2i, Hut> grid, WindowRenderer window)
        {
            _map = map;
            _grid = grid;
            _window = window;
            _nearby = new List<Hut>();
            _area = 3;
            BuilingRenderer();
            SetNearby();
        }
        public void SetNearby()
        {
            _nearby.Clear();
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

        public void BuilingRenderer()
        {
            Texture texture = new Texture("../../../../images/test.png");
            _sprite = new Sprite(texture);

            texture = new Texture("../../../../images/castle.png");
            _castle = new Sprite(texture);

        }

        public void DrawCastle()
        {
            _castle.Position = _grid[new Vector2i(-1, -1)].GetVecHut;
            _window.GetWindow.Draw(_castle);
        }
    }
}
