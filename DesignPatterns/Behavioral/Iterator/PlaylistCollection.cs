using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class PlaylistCollection : IIterableCollection<string>
    {
        private readonly List<string> songs = new List<string>();
        public void AddSong(string song)
        {
            songs.Add(song);
        }
        public void RemoveSong(string song)
        {
            songs.Remove(song);
        }
        public string GetSongAt(int i)
        {
            return songs[i];
        }

        public int GetSize()
        {
            return songs.Count;
        }
        public IIterator<string> CreateIterator()
        {
            return new PlaylistIterator(this);
        }
    }
}
