using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti.Unagi
{
    public class Emprendedor
    {
        //Dato BD
        public int Id_Emprendedor;
        //Datos Generales
        public string Nombre;
        public string Apellido;
        public string Dni;

        //Datos de contactar
        public string Correo;
        public string Telefono;

        //Datos para pagar 
        //public string CUIT_CUIL;
        //public string Alias;
        //public string CBU_CVU;
        //public string Entidad_Bancarias;

        public Emprendedor()
        {
                
        }

        public Emprendedor(int id_Emprendedor, string nombre, string apellido,
            string dni, string correo, string telefono)
        {
            Id_Emprendedor = id_Emprendedor;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Correo = correo;
            Telefono = telefono;
        }

        public string NombreCompleto => $"{Nombre} {Apellido}";

    }
}
