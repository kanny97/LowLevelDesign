using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class IteratorDemo
    {
        public static void Main(string[] args)
        {
            PlaylistCollection playlist = new PlaylistCollection();
            playlist.AddSong("Shape of You");
            playlist.AddSong("Bohemian Rhapsody");
            playlist.AddSong("Blinding Lights");

            IIterator<string> iterator = playlist.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}