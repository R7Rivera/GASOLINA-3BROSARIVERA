using System;
using System.Collections.Generic;
using System.Text;

namespace _3_GASOLINA_FACTURA_CLIENTE.CLASES
{
     public class GASOLINA
    {
        public GASOLINA(string tipogasolina, int cantgalones, double preciodeventa)
        {
            this.tipogasolina = tipogasolina;
            this.cantgalones = cantgalones;
            this.preciodeventa = preciodeventa;
        }
        private string tipogasolina;

        public string TIPOGASOLINA 
        {
            get { return tipogasolina; }
            set { tipogasolina = value; }
        }
        private int cantgalones;

        public int CANTGALONES
        {
            get { return cantgalones; }
            set { cantgalones = value; }
        }
        private double preciodeventa;

        public double PRECIODEVENTA
        {
            get { return preciodeventa; }
            set { preciodeventa = value; }
        }
        public double TOTALDECOMPRA
        {
            get { return PRECIODEVENTA * CANTGALONES; }
        }

        public double IVA
        {
            get { return TOTALDECOMPRA * 0.12; }
        }

        public double TOTALAPAGAR
        {
            get { return TOTALDECOMPRA + IVA; }
        }

       
    }
}
