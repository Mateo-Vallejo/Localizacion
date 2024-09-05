using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Localizacion
{
    public class DetallesImagenes
    {
        // Campos
        private int idDetallesImagenes = 0;
        private string descripcion = " ";
        private System.DateTime fecha = default(DateTime);

        // Propiedades - Getters y Setters
        public int IdDetallesImagenes { get => this.idDetallesImagenes; set => this.idDetallesImagenes = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }

        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
    }
}