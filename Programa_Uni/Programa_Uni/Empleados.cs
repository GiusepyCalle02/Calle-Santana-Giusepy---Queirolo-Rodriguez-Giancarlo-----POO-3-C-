using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Uni
{
    public class Empleados : Usuarios
    {
        private int Incorporacion;
        private int Despacho;
        public Empleados(String Nombre, String Apellidos, long ID, String Civil, int Incorporacion, int Despacho) : base(Nombre, Apellidos, ID, Civil)
        {
            this.Incorporacion = Incorporacion;
            this.Despacho = Despacho;
        }
        public int getIncorporacion()
        {
            return Incorporacion;
        }
        public void setIncorporacion(int Incorporacion)
        {
            this.Incorporacion = Incorporacion;
        }
        public int getDespacho()
        {
            return Despacho;
        }
        public void setDespacho(int Despacho)
        {
            this.Despacho = Despacho;
        }
    }
}
