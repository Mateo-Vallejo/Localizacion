using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Localizacion
{
    public class Imagenes : DetallesImagenes
    {
        // Campos
        private int idImagenes = 0;
        private string rutaImagen = " ";

        // Propiedades - Getters y Setters
        public int IdImagenes { get => this.idImagenes; set => this.idImagenes = value; }
        public string RutaImagen { get => this.rutaImagen; set => this.rutaImagen = value; }

        public Localizaciones Localizaciones
        {
            get => default;
            set
            {
            }
        }
    }
}