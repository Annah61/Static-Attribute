using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs song1 = new Songs("Holiday", "Green Day", 115);
            Songs song2 = new Songs("Billy", "MJ",200);
            Console.WriteLine(song1.title);
            Console.WriteLine(Songs.songcount);

            //freeze
            Console.ReadLine();
        }
    }
}
