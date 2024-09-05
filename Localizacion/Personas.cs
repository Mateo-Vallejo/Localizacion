using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Localizacion
{
    public class Personas
    {
        // Campos
        private int idPersonas = 0;
        private string cedula = " ";
        private string nombre = " ";
        private int edad = 0;

        // Propiedades - Getters y Setters
        public int IdPersonas { get => this.idPersonas; set => idPersonas = value; }
        public string Cedula { get => this.cedula; set => cedula = value; }
        public string Nombre { get => this.nombre; set => nombre = value; }
        public int Edad { get => this.edad; set => edad = value; }

        public Localizaciones Localizaciones
        {
            get => default;
            set
            {
            }
        }
    }
}