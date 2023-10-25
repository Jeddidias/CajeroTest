using System;

namespace Aplicacion_cajero
///simular la función de un cajero automático en donde el cliente debe autenticarse ante el sistema para que le permita realizar cualquier tipo de operación.
///Las operaciones disponibles en el cajero corresponden a:
///1. Consulta de saldo. 
///2.Retiros, solo si el saldo es mayor a la cantidad solicitada y si no supera el tope diario de retiros establecidos por el banco. 
///Es decir que no podrá retirar más de dos millones de pesos diarios.
///Transferencias entre cuentas del mismo banco, para ello debe validar si existe la cuenta destino.
///Consulta de puntos ViveColombia Canje de puntos ViveColombia
///Jorge Esteban Dawson
///grupo 112
///Ingenieria Multimedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(); // lo primero que hago, como en el ejercicio pasado, son las diferentes calses dentro del programa, de donde almacenare los metodos
            Opciones opt = new Opciones(); // para este ejercicio y segun lo visto en varios tutoriales, es mejor 2 clases, una de ususario y otra de opciones
            int cedula, clave, vali = -1, vali2 = -1;
            do
            {
                try
                {
                    opt.titulo(); // este metodo lo aprendí recientemente, para generar un encabezado, que le da más estilo al programa
                    Console.WriteLine("por favor digite el numero de ceula: ");
                    cedula = int.Parse(Console.ReadLine()); // guardo el valor que ingresa el usuario
                    Console.WriteLine("Por favor ingresa la calve del usuario que ingresó: ");
                    clave = int.Parse(Console.ReadLine()); // guardo el valor que ingresa el usuario
                    vali = usuario.valCed(cedula); // dentro de la clase usuario e generado un metodo de validacion para la cedula y lo mismo para la clave
                    vali2 = usuario.valPass(clave); // lo ideal seria que esto se hiciera en una base de datos, pero la verdad el tutorial ahí se puso un poco complejo, entonces decidi hacerlo en el programa

                    if (vali != -1 && vali2 != -1 && vali == vali2)//se hace la validación de los datos
                    {
                        Console.Clear();
                        Console.WriteLine("usuario autenticado");
                        opt.optioUsuars(vali); // este para cuando el usuario está dentro de la lista selecionada e ingresar a la clase opciones
                    }
                    else
                    {
                        Console.WriteLine("No fue posible autenticar este usuario \n"); // este para cuando no esta el usuario
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("dato no valido en pestaña de datos"); // y este es para cuando se ingresa alguna letra o valor no valido
                    vali = -1;
                }
            } while (vali != -1);
        }
    }
}
