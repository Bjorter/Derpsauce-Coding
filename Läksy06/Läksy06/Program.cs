using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Läksy06
{
    class Program
    {
        static void Main(string[] args)
        {
            Album diver = new Album { Name = "Holy Diver", Artist = "Dio" };
            diver.songs = new List<Song>();

            Song song1 = new Song { Name = "Holy Diver", Duration = "4:20" };
            Song song2 = new Song { Name = "Pot of Gold", Duration = "3:57" };

            diver.AddSong(song1);
            diver.AddSong(song2);

            diver.PrintAlbum();
        }
    }
}
