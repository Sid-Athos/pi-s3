using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace test
{
    class WindowRenderer : RenderWindow
    {
        Map _map;

        uint _height;
        uint _width;
        string _title;

        ViewRenderer _view0;

        Dictionary<Styles, bool> _styles;
        Dictionary<int, ViewRenderer> _views;

        public WindowRenderer(uint height, uint width, string title)
            : base (new VideoMode(width,height), title, Styles.Default)
        {
            _height = height;
            _width = width;
            _title = title;

            //SetDStyles();

            _map = new Map(this);
            _views = new Dictionary<int, ViewRenderer>();
            _view0 = NewView();
            

        }

        public ViewRenderer NewView()
        {
            ViewRenderer newV = new ViewRenderer(this,1f,1f,_map.MapWidth(),_map.MapHeight());
            if (!_views.ContainsKey(0))
            {
                _views.Add(0, newV);
            }
            return newV;
        }

        public ViewRenderer GetViews => _view0;

        /*
        public void SetDStyles()
        {
            _styles = new Dictionary<Styles, bool>();
            _styles.Add(Styles.Close, false);
            _styles.Add(Styles.Default, false);
            _styles.Add(Styles.Fullscreen, false);
            _styles.Add(Styles.None, false);
            _styles.Add(Styles.Resize, false);
            _styles.Add(Styles.Titlebar, false);
        }

        public void AddStyles(Styles style)
        {
            foreach (var item in _styles)
            {
                if (item.Key == style)
                {
                    if (item.Value == false)
                    {
                        _styles.Add(style,true);
                    }
                }
            }
        }
        */
        public Map GetMap
        {
            get { return _map; }
        }
    }
}

