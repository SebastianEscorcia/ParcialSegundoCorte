using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClsServicioPersona
    {
		private readonly DatosPersona datosPersona;
        public ClsServicioPersona()
        {
            datosPersona = new DatosPersona();	
        }
        public string Guardar (ClsPersona clsPersona)
        {
			try
			{
				if (datosPersona.BuscarPersona(clsPersona.Id) == null ) 
				{
					datosPersona.Guardar(clsPersona);
					return $"Se han guardado los datos correctamente de la persona: {clsPersona.Nombre}";

				}
				else
				{
					return $"No se puede guardar {clsPersona.Id} Ya está registrada";
				}
			}
			catch (Exception e)
			{

				return $"Error en la aplicacion: {e.Message}";

			}
        }
    }
}
