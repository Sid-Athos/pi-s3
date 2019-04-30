using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;
//{}

namespace test
{
    class SoundManager
    {
        Game _game;
        //Dictionary<string, Sprite> _sprites;
        Sound _sound;

        public SoundManager(Game game)
        {
            //_sprites = new Dictionary<string, Sprite>();
            
            Initialized();
        }

        public void Initialized()
        {
            SoundBuffer _buffer;
            _buffer = new SoundBuffer("../../../../font/414.wav");

            _sound = new Sound(_buffer);
        }
    }
}
