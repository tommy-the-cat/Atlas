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

        public Song( string title, string path )
        {
            Title = title;
            Path = path;
        }

        public string Title { get; set; }
        public string Path { get; set; }
    }
}
