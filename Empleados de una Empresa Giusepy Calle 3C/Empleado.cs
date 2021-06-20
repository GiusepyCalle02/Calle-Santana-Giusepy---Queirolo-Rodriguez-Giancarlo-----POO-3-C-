using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_de_una_Empresa_Giusepy_Calle_3C
{
    public class Empleado
    {
        private string apellidos;
        private string nombres;
        private int edad;
        private string departamento;

        public Empleado(string apellidos, string nombres, int edad, string departamento)
        {
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.edad = edad;
            this.departamento = departamento;
        }

        public string getapellidos()
        {
            return apellidos;
        }
        public void setapellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public string getnombres()
        {
            return nombres;
        }
        public void setnombres(string nombres)
        {
            this.nombres = nombres;
        }

        public int getedad()
        {
            return edad;
        }
        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public string getdepartamento()
        {
            return departamento;
        }
        public void setdepartamento(string departamento)
        {
            this.departamento = departamento;
        }

        public override string ToString()
        {
            return "Apellidos: " +apellidos + "Nombre: " +nombres + "Edad: " +edad + "Departamento: " +departamento;
        }

    }
}
