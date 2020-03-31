using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion song1 = new Cancion("Reggaeton", "Lunay", "Llegale", "Llegale");
            Cancion song2 = new Cancion("Trap", "Paulo Londra", "Homerun", "Solo pienso en ti");
            Cancion song3 = new Cancion("Trap", "KAROL G", "Culpables", "Culpables");
            Espotifai s1 = new Espotifai(song1, song2, song3);

            Console.WriteLine("Bienvenido a Espotifai.");
            Console.WriteLine("Presione [1] si quiere ver todas las canciones, [2] si es que desea agreagr una nueva canción,[3] para ver canciones por criterio o [4] para salir:");
            string option = Console.ReadLine();
            if (option == "1")
            {
                s1.VerCanciones();
            }
            else if (option == "2")
            {
                Console.WriteLine("Ingrese el nombre de la canción:");
                string newName = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del artista:");
                string newArtist = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del álbum:");
                string newAlbum = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del género:");
                string newGenre = Console.ReadLine();
                Cancion song4 = new Cancion(newGenre, newArtist, newAlbum, newName);
                Console.WriteLine(s1.AgregarCancion(song4));
            }
            else if (option == "3")
            {
                Console.WriteLine("Ingrese un criterio válido:");
                string crit = Console.ReadLine();
                Console.WriteLine("Ingrese un valor válido:");
                string value = Console.ReadLine();
                Console.WriteLine(s1.CancionesPorCriterio(crit, value));
            }
            else if (option == "4")
            {
                Console.WriteLine("Hasta luego.");
            }
            Console.ReadKey();

        }
    }
}
