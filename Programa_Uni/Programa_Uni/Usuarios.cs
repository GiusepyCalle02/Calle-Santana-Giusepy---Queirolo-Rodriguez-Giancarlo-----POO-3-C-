using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Uni
{
    public class Usuarios
    {
        private String Nombre;
        private String Apellidos;
        private long ID;
        private String  Civil;
        public Usuarios(String Nombre, String Apellidos, long ID, String Civil)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.ID = ID;
            this.Civil = Civil;
        }
        public String getNombre()
        {
            return Nombre;
        }
        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public String getApellidos()
        {
            return Apellidos;
        }
        public void setApellidos(String Apellidos)
        {
            this.Apellidos = Apellidos;
        }
        public long getID()
        {
            return ID;
        }
        public void setID(long ID)
        {
            this.ID = ID;
        }
        public String getCivil()
        {
            return Civil;
        }
        public void setCivil(String Civil)
        {
            this.Civil = Civil;
        }
    }
}
