using System;
using System.Collections.Generic;
using System.Text;
//10-11-2019

namespace _3_GASOLINA_FACTURA_CLIENTE.CLASES
{
      public class CLIENTE
    {
        private String apellidos;

        public String APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string nombres;

        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }
        

        private String identificacioncliente;

        public String IDENTIFICACIONCLIENTE
        {
            get { return identificacioncliente; }
            set { identificacioncliente = value; }
        }
        private String direccion;

        public String DIRECCION
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public CLIENTE(string nombre, string apellidos, string identificacioncliente, string direccion)
        {
            this.nombres = nombre;
            this.apellidos = apellidos;
            this.identificacioncliente = identificacioncliente;
            this.direccion = direccion;
        }
    }
}
