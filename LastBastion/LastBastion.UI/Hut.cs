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
        String _name;

        public Hut(Vector2f pos, string name)
        {
            _pos = pos;
            _name = name;
        }

        public Vector2f GetVecHut
        {
            get { return _pos; }
        }
        public String GetName
        {
            get { return _name; }
        }
    }
}
