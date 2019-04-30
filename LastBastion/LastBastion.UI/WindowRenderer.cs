using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace LastBastion.UI
{
    class WindowRenderer
    {
        Game _game;

        RenderWindow _window;

        ViewRenderer _view0;

        public WindowRenderer(Game game)
        {
            _game = game;
            _window = new RenderWindow(new VideoMode(1000, 1000), "LastBastion" , Styles.Default);
            _view0 = NewView();
        }

        public ViewRenderer NewView() => new ViewRenderer(this);
        public Game GetGame { get { return _game; } }
        public RenderWindow Render { get { return _window; } }
        public ViewRenderer GetView { get { return _view0; } }

        public void PrintCursor()
        {
            _game.Sprites.GetSprite("CursorFont").Color = new Color(255, 255, 255, 128);
            _game.Sprites.GetSprite("CursorFont").Position = _window.View.Center;
            _game.Sprites.GetSprite("CursorBoard").Position = _window.View.Center;
            _window.Draw(_game.Sprites.GetSprite("CursorFont"));
            _window.Draw(_game.Sprites.GetSprite("CursorBoard"));
        }
    }
}

