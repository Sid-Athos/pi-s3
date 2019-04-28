using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}

namespace test
{
    class Hut
    {
        Vector2f _pos;

        public Hut(Vector2f pos)
        {
            _pos = pos;
        }

        public Vector2f GetVecHut
        {
            get { return _pos; }
        }
    }
}
