using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Songs
    {
        public string SongName { get; set; }
        public string Artist { get; set; }

        public Songs()
        {

        }
        public Songs(string songName, string artist)
        {
            SongName = songName;
            Artist = artist;
        }

    }
}
