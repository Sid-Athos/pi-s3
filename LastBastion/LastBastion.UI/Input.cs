using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
//{}
namespace test
{
    class Input
    {
        Game _game;

        public Input(Game game)
        {
            _game = game;
        }

        public void IsKeyPressed(object sender, KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.Unknown:
                    break;
                case Keyboard.Key.A:
                    _game.Close();
                    break;
                case Keyboard.Key.B:
                    break;
                case Keyboard.Key.C:
                    break;
                case Keyboard.Key.E:
                    break;
                case Keyboard.Key.F:
                    break;
                case Keyboard.Key.G:
                    break;
                case Keyboard.Key.H:
                    break;
                case Keyboard.Key.I:
                    break;
                case Keyboard.Key.J:
                    break;
                case Keyboard.Key.K:
                    break;
                case Keyboard.Key.L:
                    break;
                case Keyboard.Key.M:
                    break;
                case Keyboard.Key.N:
                    break;
                case Keyboard.Key.O:
                    break;
                case Keyboard.Key.P:
                    break;
                case Keyboard.Key.R:
                    break;
                case Keyboard.Key.T:
                    break;
                case Keyboard.Key.U:
                    break;
                case Keyboard.Key.V:
                    break;
                case Keyboard.Key.W:
                    break;
                case Keyboard.Key.X:
                    break;
                case Keyboard.Key.Y:
                    break;
                case Keyboard.Key.Num0:
                case Keyboard.Key.Numpad0:
                    break;
                case Keyboard.Key.Num1:
                case Keyboard.Key.Numpad1:
                    break;
                case Keyboard.Key.Num2:
                case Keyboard.Key.Numpad2:
                    break;
                case Keyboard.Key.Num3:
                case Keyboard.Key.Numpad3:
                    break;
                case Keyboard.Key.Num4:
                case Keyboard.Key.Numpad4:
                    break;
                case Keyboard.Key.Num5:
                case Keyboard.Key.Numpad5:
                    break;
                case Keyboard.Key.Num6:
                case Keyboard.Key.Numpad6:
                    break;
                case Keyboard.Key.Num7:
                case Keyboard.Key.Numpad7:
                    break;
                case Keyboard.Key.Num8:
                case Keyboard.Key.Numpad8:
                    break;
                case Keyboard.Key.Num9:
                case Keyboard.Key.Numpad9:
                    break;
                case Keyboard.Key.Escape:
                    break;
                case Keyboard.Key.LControl:
                    break;
                case Keyboard.Key.LShift:
                    break;
                case Keyboard.Key.LAlt:
                    break;
                case Keyboard.Key.LSystem:
                    break;
                case Keyboard.Key.RControl:
                    break;
                case Keyboard.Key.RShift:
                    break;
                case Keyboard.Key.RAlt:
                    break;
                case Keyboard.Key.RSystem:
                    break;
                case Keyboard.Key.Menu:
                    break;
                case Keyboard.Key.LBracket:
                    break;
                case Keyboard.Key.RBracket:
                    break;
                case Keyboard.Key.SemiColon:
                    break;
                case Keyboard.Key.Comma:
                    break;
                case Keyboard.Key.Period:
                    break;
                case Keyboard.Key.Quote:
                    break;
                case Keyboard.Key.Slash:
                    break;
                case Keyboard.Key.BackSlash:
                    break;
                case Keyboard.Key.Tilde:
                    break;
                case Keyboard.Key.Equal:
                    break;
                case Keyboard.Key.Dash:
                    break;
                case Keyboard.Key.Space:
                    break;
                case Keyboard.Key.Return:
                    break;
                case Keyboard.Key.BackSpace:
                    break;
                case Keyboard.Key.Tab:
                    break;
                case Keyboard.Key.PageUp:
                    break;
                case Keyboard.Key.PageDown:
                    break;
                case Keyboard.Key.End:
                    break;
                case Keyboard.Key.Home:
                    break;
                case Keyboard.Key.Insert:
                    break;
                case Keyboard.Key.Delete:
                    break;
                case Keyboard.Key.Add:
                    break;
                case Keyboard.Key.Subtract:
                    break;
                case Keyboard.Key.Multiply:
                    break;
                case Keyboard.Key.Divide:
                    break;
                case Keyboard.Key.Left:
                case Keyboard.Key.Q:
                    _game.GetWindow.GetViews.ViewLeft();
                    break;
                case Keyboard.Key.Right:
                case Keyboard.Key.D:
                    _game.GetWindow.GetViews.ViewRight();
                    break;
                case Keyboard.Key.Up:
                case Keyboard.Key.Z:
                    _game.GetWindow.GetViews.ViewUp();
                    break;
                case Keyboard.Key.Down:
                case Keyboard.Key.S:
                    _game.GetWindow.GetViews.ViewDown();
                    break;
                case Keyboard.Key.F1:
                    break;
                case Keyboard.Key.F2:
                    break;
                case Keyboard.Key.F3:
                    break;
                case Keyboard.Key.F4:
                    break;
                case Keyboard.Key.F5:
                    break;
                case Keyboard.Key.F6:
                    break;
                case Keyboard.Key.F7:
                    break;
                case Keyboard.Key.F8:
                    break;
                case Keyboard.Key.F9:
                    break;
                case Keyboard.Key.F10:
                    break;
                case Keyboard.Key.F11:
                    break;
                case Keyboard.Key.F12:
                    break;
                case Keyboard.Key.F13:
                    break;
                case Keyboard.Key.F14:
                    break;
                case Keyboard.Key.F15:
                    break;
                case Keyboard.Key.Pause:
                    break;
                case Keyboard.Key.KeyCount:
                    break;
                default:
                    break;
            }
        }
    }
}
