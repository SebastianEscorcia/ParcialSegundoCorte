using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatosPersona
    {
        public void Guardar (ClsPersona persona)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\Desktop\Personas.txt",true);
            escribir.WriteLine($"{persona.Nombre} ; {persona.Apellido}; {persona.Ciudad} ; {persona.Id}") ;
            escribir.Close() ;  
        }
        public ClsPersona BuscarPersona( string identificacion)
        {
            List<ClsPersona> personas = new List<ClsPersona>();
            foreach (var item in personas)
            {
                if (EsEncontrado (item.Id, identificacion))
                {
                    return item;
                }
            }
            return null; 
        }
        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        public List<ClsPersona> ConsultarTodos()
        {
            List<ClsPersona> personas = new List<ClsPersona>(); //mochila
            StreamReader reader = new StreamReader(@"C:\Users\User\Desktop\Personas.txt", true);
            string linea = string.Empty;
            while (!reader.EndOfStream) // while ((linea = reader.ReadLine()) != null)
            {
                linea = reader.ReadLine();
                ClsPersona persona = Map(linea);
                personas.Add(persona);
            }
            reader.Close();
            // file.Close();
            return personas;
        }
        private ClsPersona Map(string linea)
        {
            ClsPersona persona = new ClsPersona();
            char delimiter = ';';
            var matrizPersona = linea.Split(delimiter);
            persona.Nombre = matrizPersona[0];
            persona.Apellido = matrizPersona[1];
            persona.Ciudad = matrizPersona[2];
            persona.Id = matrizPersona[3];
            return persona;
        }
    }
}
