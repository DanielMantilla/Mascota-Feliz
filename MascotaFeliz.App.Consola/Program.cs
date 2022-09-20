using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioupdateDueno _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVistitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddDueno();
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Antonio",
                Apellidos = "Cuadros",
                Direccion = "Al lado",
                Telefono = "6554433",
                Correo = "antonio@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void DeleteDueno() //borra un dueno
        {
            _repoDueno.DeleteDueno(3);
        }

        private static void AddVeterinario() //agrega un veterinario
        {
            var veterinario = new Veterinario
            {
                //cedula = "1212",
                Nombres = "Daniel",
                Apellidos = "Cuadros",
                Direccion = "Bucaramanga",
                Telefono = "6554433",
                TarjetaProfesional = "sd123"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota() //agregar mascota
        {
            var mascota = new Mascota
            {
                Nombre = "Sasha",
                Color = "Blanca",
                Especie = "Canino",
                Raza = "Shitzu",
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2022,08,23)
            };
            _repoDueno.AddHistoria(historia);
        }
        private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = RepoHistoria.GetHistoria(idHistoria);
            if (hidtoria != null)
            {
                if (historia.VisitaPyP != null)
                {
                    
                }
            }
        }
    }
}
