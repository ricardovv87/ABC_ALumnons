using Examen.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Examen.Client.Servicios
{
    public class ServiciosAlumnos:IServiciosAlumnos
    {
        private readonly HttpClient _httpClient;

        public ServiciosAlumnos(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task BorrarAlumno(int id)
        {
            await _httpClient.DeleteAsync($"api/Alumnos/{id}");
        }

        public async Task<Alumnos> DetalleAlumno(int id)
        {
            return await _httpClient.GetFromJsonAsync<Alumnos>($"api/Alumnos/{id}");
        }

        public async Task GuardarAlumno(Alumnos alumno)
        {
            if (alumno.Id == 0)
            {
                await _httpClient.PostAsJsonAsync<Alumnos>($"api/Alumnos", alumno);
            }
            else 
            {
                await _httpClient.PutAsJsonAsync<Alumnos>($"api/Alumnos/{alumno.Id}", alumno);
            }
        }

        public async Task<IEnumerable<Alumnos>> ListarAlumnos()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Alumnos>>($"api/Alumnos");
        }
    }
}
