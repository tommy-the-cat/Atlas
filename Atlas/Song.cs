using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas
{
    public class Song
    {
        public Song() : base() { }

        public Song( string title, string path, string artist )
        {
            
            Title = title;
            Path = path;
            Artist = artist;
        }

        public string Title { get; set; }
        public string Path { get; set; }
        public string Artist { get; set; }
    }
}
