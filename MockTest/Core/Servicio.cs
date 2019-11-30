using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Servicio : IServicio
    {
        Random rmd = new Random();
        public List<Alumno> GetAlumnos()
        {
            List<Alumno> result = new List<Alumno>();
            result.Add(new Alumno() { CI = 6677, Nombre = "Pedro juares" });
            result.Add(new Alumno() { CI = 1177, Nombre = "Maria Peres" });
            result.Add(new Alumno() { CI = 2277, Nombre = "Juan Alarcon" });
            result.Add(new Alumno() { CI = 3377, Nombre = "Marcelo Paredes" });
            result.Add(new Alumno() { CI = 4477, Nombre = "Julia Flores" });
            return result;
        }

        public int GetNota(int CI)
        {
            int nota = rmd.Next(1, 100);
            return nota; 
        }

        public void Validar(string token)
        {
            if (String.IsNullOrEmpty(token))
            {
                throw new Exception("token invalido");
            }
        }
    }
}
