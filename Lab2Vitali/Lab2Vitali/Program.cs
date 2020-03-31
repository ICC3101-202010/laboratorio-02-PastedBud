using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab2CarloVitali
{
    class Cancion
    {
        public string Nombre;
        public string Album;
        public string Artista;
        public string Genero;
        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.Nombre = nombre;
            this.Album = album;
            this.Artista = artista;
            this.Genero = genero;

        }
        public string Informacion()
        {

            return ("genero: " + Genero + ", artista: " + Artista + ", album: " + Album + ". nombre:" + Nombre);

        }

    }
    class Espotifai
    {
        private List<Cancion> songsList;
        public Espotifai()
        {


        }
        public bool AgregarCancion(Cancion cancion)
        {
            foreach (var c in songsList)
            {
                Console.WriteLine(c);
            }
            return true;
        }
        public void VerCanciones()
        {


        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Cancion c1 = new Cancion("Lights", "Lights", "Ellie Goulding", "Pop");
            Console.WriteLine(c1.Informacion());
            bool A = true;
            while (A == true)
            {
                Console.WriteLine("Desea agregar una cancion? (Si/No):  ");
                string PrimeraRespuesta = (Console.ReadLine());
                if (PrimeraRespuesta == "Si")
                {
                    Console.WriteLine("Ingrese Nombre Cancion:  ");
                    string RespuestaNombre = (Console.ReadLine());
                    Console.WriteLine("Ingrese Album Cancion:  ");
                    string RespuestaAlbum = (Console.ReadLine());
                    Console.WriteLine("Ingrese Artista Cancion:  ");
                    string RespuestaArtista = (Console.ReadLine());
                    Console.WriteLine("Ingrese Genero Cancion:  ");
                    string RespuestaGenero = (Console.ReadLine());
                    List<Cancion> songsList = new List<Cancion>();
                    songsList.Add(new Cancion(RespuestaNombre, RespuestaAlbum, RespuestaArtista, RespuestaGenero));
                    Console.WriteLine(songsList[0].Informacion());
                }
                else
                {
                    A = false;

                }
            }





        }






    }

}
