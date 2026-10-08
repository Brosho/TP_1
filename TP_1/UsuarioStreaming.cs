using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//hacer 1 archivo por cada clase :vvvvv
namespace TP_1
{
    public class UsuarioStreaming
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }
        private DateTime fechaSuscripcion;
        public DateTime FechaSuscripcion
        {
            get { return fechaSuscripcion; }
            set
            {
                if (value >= DateTime.Now)
                {
                    throw new ArgumentException("La fecha de su suscripcion es invalida.");
                }
                else
                {
                    fechaSuscripcion = value;
                }
            }
        }

        /* public void SetNombre(string nombre)
         {
             Nombre = nombre;
         }

         public string GetNombre()
         {
             return Nombre;
         }

        */
        //De esta manera se hace en otros lenguajes de programacion el set y get. Basicamente asignarle valores a las variables.


        //Metodos(void) o Funciones(int,string,bool. Hay que poner return.)
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Fecha de Suscripcion: " + FechaSuscripcion);
            Console.WriteLine("DNI: " + DNI);
        }

        public override bool Equals(object obj)
        {
            if (obj is UsuarioStreaming otrousuario)
            {
                return
                    this.DNI == otrousuario.DNI;
                       
            }
            return false;
        }
        public override int GetHashCode()
        {
            return DNI.GetHashCode();
        }

        public static bool operator ==(UsuarioStreaming usuario1, UsuarioStreaming usuario2)
        {
            if (ReferenceEquals(usuario1, null) && ReferenceEquals(usuario2, null))
            {
                return true;
            }
            if (ReferenceEquals(usuario1, null) || ReferenceEquals(usuario2, null))
            {
                return false;
            }
            return usuario1.Equals(usuario2);
        }

        public static bool operator !=(UsuarioStreaming usuario1, UsuarioStreaming usuario2)
        {
            return !(usuario1 == usuario2);
        }
    }
    
}
