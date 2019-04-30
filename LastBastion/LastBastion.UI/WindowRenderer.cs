using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace LastBastion.UI
{
    class WindowRenderer
    {
        RenderWindow _window;

        Map _map;
        string _title;

        ViewRenderer _view0;

        Dictionary<Styles, bool> _styles;

        public WindowRenderer(uint height, uint width, string title)
        {
            _window = new RenderWindow(new VideoMode(1000, 1000), title, Styles.Default);
            //SetDStyles();
            _map = new Map(this);
            _view0 = NewView();
        }

        public ViewRenderer NewView()
        {
            ViewRenderer newV = new ViewRenderer(this,1f,1f,_map.MapWidth(),_map.MapHeight());
            return newV;
        }

        public Map GetMap
        {
            get { return _map; }
        }
        public RenderWindow GetWindow
        {
            get { return _window; }
        }
        public ViewRenderer GetViewRenderer
        {
            get { return _view0; }
        }

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
    }
}

