using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song[] songs = new Song[]
            {
                new Song("사이렌", "호미들", 230),
                new Song("Sweet&Sour", "수스", 280),
            };

            foreach (var song in songs)
            {
                Console.WriteLine(@"Title : {0}, ArtistName : {1}, Length : {2:m\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length)); 
            }
        }


        
        
    }
}
