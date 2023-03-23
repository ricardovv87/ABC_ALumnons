using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Shared;


namespace AlumnosRepository
{
    public class AlumnoRepository : IAlumnosRepository
    {
        private readonly IDbConnection _dbConnection;

        public AlumnoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public async Task<bool> ActualizarAlumno(Alumnos alumno)
        {
            var sql = @"UPDATE alumno SET nombre =@nombre,
                                          apellidoP =@apellidoP,
                                            apellidoM =@apellidoM
                                            WHERE Id=@id";

            var result = await _dbConnection.ExecuteAsync(
                sql, new
                {
                
                    alumno.Nombre,
                    alumno.ApellidoP,
                    alumno.ApellidoM,
                    alumno.Id
                });
            return result > 0;
    
        }

        public async Task BorrarAlumno(int Id)
        {
            var sql = @"DELETE FROM alumno WHERE Id = @id";
            var resul = await _dbConnection.ExecuteAsync(sql, new { Id });
        }


        public async Task<bool> InsertarAlumno(Alumnos alumno)
        {
            var sql = @"INSERT INTO alumno(nombre,apellidoP,apellidoM)
                                        VALUES(@nombre,@apellidoP,@apellidoM)";

            var result = await _dbConnection.ExecuteAsync(
                sql, new
                {
                    alumno.Nombre,
                    alumno.ApellidoP,
                    alumno.ApellidoM
                }); return result > 0;

        }

        public async Task<IEnumerable<Alumnos>> TotalAlumnos()
        {
            var sql = @"SELECT id,nombre,apellidoP,apellidoM FROM alumno";

            return await _dbConnection.QueryAsync<Alumnos>(sql, new { });
        }

       public async Task<Alumnos> DetallesAlumno(int Id)
        {
            var sql = @"SELECT Id,
                              nombre,
                              apellidoP,
                              apellidoM
                                FROM alumno WHERE Id = @id";

            return await _dbConnection.QueryFirstOrDefaultAsync<Alumnos>(sql, new { Id = Id });
        }
    }
}
