using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


//{}

namespace LastBastion.UI
{
    class Hut
    {


        Vector2f _pos;
        Vector2i _posG;
        String _name;
        string _building;
        

        public Hut(Vector2f pos, string name, Vector2i posG)
        {
            _posG = posG;
            _pos = pos;
            _building = "Empty";
            _name = name;
        }
        public Vector2i GetVector { get { return _posG; } }
        public Vector2f GetVecHut{get { return _pos; }}
        public String GetName{get { return _building; }}
        public String StringVec => _name;
        public bool IsBusy()
        {
            if (_building != "Empty")
            {
                return true;
            }
            return false;
        }
        public void SetBuilding(string a){_building = a;}
    }
}
