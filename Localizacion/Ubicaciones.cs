using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Localizacion
{
    public class Ubicaciones : Localidades
    {
        // Campos
        private int idUbicaciones = 0;
        private double latitud = 0.0;
        private double longitud = 0.0;

        // Propiedades - Getters y Setters
        public int IdUbicaciones { get => this.idUbicaciones; set => this.idUbicaciones = value; }
        public double Latitud { get => this.latitud; set => this.latitud = value; }
        public double Longitud { get => this.longitud; set => this.longitud = value; }

        public Localizaciones Localizaciones
        {
            get => default;
            set
            {
            }
        }
    }
}