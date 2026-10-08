using System;
using System.Collections.Generic;
using System.Text;

namespace TP_1
{
    internal class MonederoDigital
    {
        private string idUsuario; 
        private decimal saldo;

        public string idUsuario1
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set
            {
                if(saldo >= 0)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("El saldo no puede ser negativo.");
                }
            }
        }
    }
}
