using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Localizacion
{
    public class Localidades
    {
        // Campos
        private int idLocalidades = 0;
        private int codigoPostal = 0;
        private string pais = " ";
        private string departamento = " ";
        private string ciudad = " ";
        private string barrio = " ";

        // Propiedades - Getters y Setters
        public int IdLocalidades { get => this.idLocalidades; set => this.idLocalidades = value; }
        public int CodigoPostal { get => this.codigoPostal; set => this.codigoPostal = value; }
        public string Pais { get => this.pais; set => this.pais = value; }
        public string Departamento { get => this.departamento; set => this.departamento = value; }
        public string Ciudad { get => this.ciudad; set => this.ciudad = value; }
        public string Barrio { get => this.barrio; set => this.barrio = value; }


    }
}