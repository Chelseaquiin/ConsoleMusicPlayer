using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class PlayList
    {
        public string Name { get; set; }
        public Songs Songs { get; set; }

        public PlayList(string name, Songs songs)
        {
            Name = name;
            Songs = songs;
        }
    }
}
