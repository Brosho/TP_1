using TP_1;

UsuarioStreaming usuario1;
usuario1 = new UsuarioStreaming();

UsuarioStreaming usuario2;
usuario2 = new UsuarioStreaming();

//usuario1.Nombre "Santiago"; otra manera de hacer lo de abajo. La de abajo es mejor.
//usuario1.SetNombre("Santiago"); esto es en la mayoria de programas. En C# hacemos de otra forma.

usuario1.Apellido = "Brollo";//parece variable pero lo trabajamos como set o get.
usuario1.FechaSuscripcion = DateTime.Now.AddDays(-1);
usuario1.Email = "brollo.lautaro07@gmail.com";
usuario1.Nombre = "Santiago";

usuario2.FechaSuscripcion = DateTime.Now.AddDays(-2);//si es mayor a la fecha actual tira un error no en la consola, si no q nos muestra el parametro q pusimos al objeto.
usuario2.Email = "perez.juan@gmail.com";
usuario2.Nombre = "Juan";
usuario2.Apellido = "Perez";

/*
usuario1.MostrarInformacion();
usuario2.MostrarInformacion();
*/


UsuarioStreaming variable1;
UsuarioStreaming variable2;

variable1 = new UsuarioStreaming();
variable1.Nombre = "Santiago";
variable1.Apellido = "Brollo";
variable1.Email = "algo@gmail.com";

variable2 = new UsuarioStreaming();
variable2.Nombre = "Juan";
variable2.Apellido = "Perez";
variable2.Email = "perez.juan@gmail.com";

if (variable1 == variable2)
{
    Console.WriteLine("Son objetos iguales");
}
else
{
    Console.WriteLine("Son objetos distintos");
}

MonederoDigital m= new MonederoDigital();
m.Saldo = 1000000;

Console.WriteLine("El saldo es: " + m.Saldo);