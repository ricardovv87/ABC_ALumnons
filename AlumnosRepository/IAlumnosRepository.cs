using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Shared;

namespace AlumnosRepository
{
    public interface IAlumnosRepository
    {
        Task<bool> InsertarAlumno(Alumnos alumno);

        Task<bool> ActualizarAlumno(Alumnos alumno);

        Task BorrarAlumno(int Id);


        Task<IEnumerable<Alumnos>> TotalAlumnos();

        Task<Alumnos> DetallesAlumno(int Id);

    }
}
