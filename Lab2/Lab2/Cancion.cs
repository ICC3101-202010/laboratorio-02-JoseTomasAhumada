using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Cancion
    {
        private string name;
        private string album;
        private string artist;
        private string genre;

        public Cancion(string name, string album, string artist, string genre)
        {
            this.name = name;
            this.album = album;
            this.artist = artist;
            this.genre = genre;
        }
        public string informacion()
        {
            return ("nombre: "+ name + ",álbum: " + album + ",artista: " + artist + ",género: " + genre);
        }
    }
}
