using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Espotifai
    {
        private List<string> names = new List<string>();
        private List<string> albums = new List<string>();
        private List<string> artists = new List<string>();
        private List<string> genres = new List<string>();

        public Espotifai(Cancion c1, Cancion c2, Cancion c3)
        {
            names.Add(c1.Name());
            names.Add(c2.Name());
            names.Add(c3.Name());
            albums.Add(c1.Album());
            albums.Add(c2.Album());
            albums.Add(c3.Album());
            artists.Add(c1.Artist());
            artists.Add(c2.Artist());
            artists.Add(c3.Artist());
            genres.Add(c1.Genre());
            genres.Add(c2.Genre());
            genres.Add(c3.Genre());
        }
        public List<string> Names()
        {
            return names;
        }
        public List<string> Albums()
        {
            return albums;
        }
        public List<string> Artists()
        {
            return artists;
        }
        public List<string> Genres()
        {
            return genres;
        }
        public bool AgregarCancion(Cancion c2)
        {
            if (names.Contains(c2.Name()) == true)
            {
                return false;
            }
            if (artists.Contains(c2.Artist()) == true)
            {
                return false;
            }
            if (albums.Contains(c2.Album()) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void VerCanciones()
        {
            for (int i = 0; i < names.Count; ++i)
            {
                Console.WriteLine("Género: " + genres[i] + " Álbum: " + albums[i] + " Artista: " + artists[i] + " Nombre: " + names[i]);
            }
        }
    }
}
