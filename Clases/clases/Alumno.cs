using System;
using Enumeradores;

namespace Clases
{
    public class Alumno : Persona
    {

        public Alumno()
        {
            this.Activo=true;
        } 

        public Alumno(int id, string nombre,Sexo sexo)
        {
            this.Id=id;
            this.Nombre=nombre;
            this.Sexo=sexo;
            this.Activo=true;
        } 


        public int Id { get; set; }

        public bool Activo { get; set; }

    }
}