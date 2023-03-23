using Examen.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Client.Servicios
{
    public interface IServiciosAlumnos
    {

        Task GuardarAlumno(Alumnos alumno);

        Task BorrarAlumno(int id);

        Task<IEnumerable<Alumnos>>ListarAlumnos();

        Task<Alumnos> DetalleAlumno(int id);




    }
}
