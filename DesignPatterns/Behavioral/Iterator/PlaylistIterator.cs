using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class PlaylistIterator : IIterator<string>
    {
        private readonly PlaylistCollection playlist;
        private int index = 0;
        public PlaylistIterator(PlaylistCollection playlist)
        {
            this.playlist = playlist;
        }
        public bool HasNext()
        {
            return index < playlist.GetSize();
        }
        public string Next()
        {
            return playlist.GetSongAt(index++);
        }
    }
}
