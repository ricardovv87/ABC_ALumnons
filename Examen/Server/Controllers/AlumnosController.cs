using AlumnosRepository;
using Examen.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {

        private readonly IAlumnosRepository _alumnosRepository;

        public AlumnosController(IAlumnosRepository alumnosrepository)
        {
            _alumnosRepository = alumnosrepository;
        }



        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Alumnos alumno)
            {

            await _alumnosRepository.InsertarAlumno(alumno);
            return NoContent();
            }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id,[FromBody]Alumnos alumnos )
        {
            await _alumnosRepository.ActualizarAlumno(alumnos);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task Borrar(int id)
        {
            await _alumnosRepository.BorrarAlumno(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Alumnos>> Get()
        {
            return await _alumnosRepository.TotalAlumnos();
        }

        [HttpGet("{id}")]
        public async Task<Alumnos> detalleAlumno(int id) 
        {
            return await _alumnosRepository.DetallesAlumno(id);
        }


    }
}
