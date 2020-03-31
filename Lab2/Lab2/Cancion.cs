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

        public Cancion(string genre, string artist, string album, string name)
        {
            this.genre = genre;
            this.artist = artist;
            this.album = album;
            this.name = name;
        }
        public string Name()
        {
            return name;
        }
        public string Album()
        {
            return album;
        }
        public string Artist()
        {
            return artist;
        }
        public string Genre()
        {
            return genre;
        }
        public string informacion()
        {
            return ("Género: "+ Genre() + ", Artista: " + Artist() + ", Álbum: " + Album() + ", Nombre: " + Name());
        }
    }
}
