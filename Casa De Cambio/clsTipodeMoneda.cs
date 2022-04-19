using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_De_Cambio
{
    class clsTipodeMoneda
    {
        private double dinero;
        private double valordelcanje;
        private double dolar;
        private double euro;
        private double pesocolombiano;
         

        public double Dolar
        {
            get { return dolar; }
            set { dolar = value; }
        }
        public double Euro
        {
            get { return euro; }
            set { euro = value; }
        }
        public double PesoColombiano
        {
            get { return pesocolombiano; }
            set { pesocolombiano = value; } 
        }
        public double Valordelcanje
        {
            get { return valordelcanje; }
            set { valordelcanje = value; }  
        }
        public double Dinero
        {
            get { return dinero; }  
            set { dinero = value; } 
        }
        public string transaccion()
        {
            return ("su conversion se ha realizado con exito");
        }
    }
}
