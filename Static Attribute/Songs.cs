using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    internal class Songs
    {
        public string title ;
        public string artist ;
        public int duration;

        public static int songcount;// declared a static attribute
        public Songs(string aTitle, string aArtist, int aDuration) // Constructor
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songcount++;

        }

    }
}
