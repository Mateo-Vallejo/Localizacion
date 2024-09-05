using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Localizacion
{
    public class Localizaciones
    {
        private int idLocalizaciones = 0;
        private Personas? personas = null;
        private Ubicaciones? ubicaciones =null;
        private Imagenes? imagenes =null;

        public void Ejecutar()
        {
            Console.WriteLine("\"Clases - Modelos, Entidades, Enumerables\"");
            this.Localizacion();
        }

        public void Localizacion()
        {
            Console.WriteLine("Ejemplo complejo");

            List<Personas> personas = obtenerPersonas();
            List<Ubicaciones> ubicaciones = obtenerUbicaciones();
            List<Imagenes> imagenes = obtenerImagenes();
            var localizaciones = obtenerLocalizacion();

            ImprimirLocalizaciones(localizaciones);

            // Consultas
           // var consulta = localizaciones.Where(x => x.Persona?.Cedula == "123456789").ToList();
           // console.WriteLine(/n);
              

        }

        private Localizaciones CrearLocalizacion(int id, Personas persona, Ubicaciones ubicacion,
            Imagenes imagen)
        {
            var localizacion = new Localizaciones()
            {
                idLocalizaciones = id,
                personas = persona,
                ubicaciones=ubicacion,
                imagenes = imagen,
            };
            return localizacion;
        }

        private Ubicaciones CrearDetalle(int id, Ubicaciones ubicaciones)
        {
            var detalles = new Ubicaciones();
            detalles.IdLocalidades = id;
            detalles.CodigoPostal = 050001;
            return detalles;
        }

        private void ImprimirLocalizaciones(IEnumerable<Localizaciones> localizaciones)
        {
            foreach (var localizacion in localizaciones)
            {
                Console.WriteLine("|" + localizacion.idLocalizaciones +
                    "|" + localizacion.personas?.Cedula +
                    "|" + localizacion.personas?.Nombre +
                    "|" + localizacion.ubicaciones?.Pais +
                    "|" + localizacion.ubicaciones?.Ciudad);
            }
        }

/*
        private IEnumerable<Localizaciones> AsignarLocalizacion(List<Personas> obtenerPersonas, 
            List<Ubicaciones> obtenerUbicaciones, List<Imagenes> obtenerImagenes)
        {
            var localizacion = new List<Localizaciones>();
            localizacion.Add(
                //CrearLocalizacion(
                    1,
                   // personas[0],
                   // Ubicaciones[1],
                   // Imagenes[0],
                    [

                        ]

                    );
            return localizacion;
        }
*/
        private List<Personas> obtenerPersonas()
        {
            List<Personas> lista = new List<Personas>();
            lista.Add(new Personas()
            {
                IdPersonas = 1,
                Nombre = "Luis Enrique",
                Cedula = "123456789",
                Edad = 18,
            });
            lista.Add(new Personas()
            {
                IdPersonas = 2,
                Nombre = "Sebastian",
                Cedula = "987654321",
                Edad = 19,
            });
            lista.Add(new Personas()
            {
                IdPersonas = 3,
                Nombre = "Samuel",
                Cedula = "246813579",
                Edad = 20,
            });
            lista.Add(new Personas()
            {
                IdPersonas = 4,
                Nombre = "Mateo",
                Cedula = "135792468",
                Edad = 18,
            });
            return lista;
        }

        private List<Ubicaciones> obtenerUbicaciones()
        {
            List<Ubicaciones> lista = new List<Ubicaciones>();
            lista.Add(new Ubicaciones()
            {
                IdUbicaciones = 1,
                Latitud = 6.244487,
                Longitud = -75.55093,
                CodigoPostal = 050001,
                Pais = "Colombia",
                Departamento = "Antioquia",
                Ciudad = "Medellin",
                Barrio = "Villa Hermosa",
            });
            lista.Add(new Ubicaciones()
            {
                IdUbicaciones = 2,
                Latitud = 6.273443,
                Longitud = -75.588732,
                CodigoPostal = 050001,
                Pais = "Colombia",
                Departamento = "Antioquia",
                Ciudad = "Medellin",
                Barrio = "Robledo",
            });
            return lista;
        }

        private List<Imagenes> obtenerImagenes()
        {
            List<Imagenes> lista = new List<Imagenes>();
            lista.Add(new Imagenes()
            {
                IdImagenes = 1,
                RutaImagen = "https://www.itm.edu.co//wp-content/uploads/2021/11/Untitled-1fraternidad-1920x700-1.jpg",
                Descripcion = "Campus Universitario Fraternidad",
                Fecha = DateTime.Now,
            });
            lista.Add(new Imagenes()
            {
                IdImagenes = 1,
                RutaImagen = "https://www.itm.edu.co//wp-content/uploads/campus/Robledo/fotos_campusRobledo00.jpg",
                Descripcion = "Campus Universitario Robledo",
                Fecha = DateTime.Now,
            });
            return lista;
        }
        private List<Localizaciones> obtenerLocalizacion()
        {
            List<Localizaciones> lista = new List<Localizaciones>();
            return lista;
        }
        //Futuro metodo menu
        /*
        private void menu()
        {
            do
            {
                int opcion = 0;
                // Menu
                // 

                switch (opcion)
                {
                    case 1: opcion = 1; break;
                }
            } while (true);
        }
        */

    }
}