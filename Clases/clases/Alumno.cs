using System;
using System.Collections.Generic;
using Enumeradores;

namespace Clases
{
    public class Alumno : Persona
    {

        public Alumno()
        {
            this.Activo = true;
        }

        public Alumno(int id, string nombre, Sexo sexo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Activo = true;
        }


        public int Id { get; set; }

        public int IdMateria { get; set; }
        public bool Activo { get; set; }


        public List<Materia> Materias { get; set; }

    }
}