using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {


        private readonly ClsServicioPersona servicioPersona;
        public Form1()
        {
            InitializeComponent();
            servicioPersona = new ClsServicioPersona() ; 
        }
        private string Guardar()
        {
            ClsPersona persona = MapearTextoPersona();
            string mensaje = servicioPersona.Guardar(persona);
            return mensaje;
        }
        private ClsPersona MapearTextoPersona()
        {
           var ClsPersona = new ClsPersona();
            ClsPersona.Nombre = txt_Nombre.Text;
            ClsPersona.Apellido = txt_Apellido.Text;
            ClsPersona.Ciudad = txt_Ciudad.Text;
            ClsPersona.Id = txt_Id.Text;
            return ClsPersona;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = Guardar();
            MessageBox.Show(mensaje, "Información de guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
