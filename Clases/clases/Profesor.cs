using System.Collections.Generic;

namespace Clases
{
    public class Profesor : Persona
    {

        public int IdProfesor { get; set; }

        public List<Materia>  Materias { get; set; }
    }
}