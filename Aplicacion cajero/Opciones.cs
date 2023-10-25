using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_cajero
{
    class Opciones
    {
        int selUser, tope = 2000000; // se guarda la seleccion del usuario y el tope que como indica el ejercicio es de 2000000
        int Saldo = 0, Puntos = 0; // el contador de saldo y de puntos que se setean a 0
        Usuario us = new Usuario(); // y llamamos a la clase usuario

        public void optioUsuars(int vali) // el primer metodo es de la opcion que escoge el usuario
        {
            do //Cuando el usuario pasa la autenticación llega a un menu do - while 
            {
                titulo(); //Nuevamente el metodo titulo para mantenerlo en pantalla, porque la verdad me parecio mega cool
                Console.WriteLine("--------Menu de opciones---------- \n"); // este menu es basciamente una copia de lo generado en el ejercicio pasado
                Console.WriteLine("1. Consultar saldo ");
                Console.WriteLine("2. Retirar ");
                Console.WriteLine("3. Hacer Transferencia ");
                Console.WriteLine("4. Consultar Puntos ViveColombia ");
                Console.WriteLine("5. Usar puntos ViveColombia ");
                Console.WriteLine("6. Salir \n");

                selUser = int.Parse(Console.ReadLine()); // para guardar la seleccion del usuario

                switch (selUser)//Como me parecio muy efectico el metodo switch lo vuelvo a utilizar
                {
                    case 1:
                        Console.Clear();
                        conSaldo(vali); // cada una de estas me va a generar un metodo nuevo
                        Console.WriteLine("Presione cualquier telca para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        optioUsuars(vali); // para validar la opción del usuario
                        break;
                    case 2:
                        Console.Clear();
                        retiro(vali);
                        break;
                    case 3:
                        Console.Clear();
                        trans(vali);
                        break;
                    case 4:
                        Console.Clear();
                        contPuntos(vali);
                        Console.WriteLine("Presione cualquier telca para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        usarPuntos(vali);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                } 
            } while (selUser != 6);
        }
        public void conSaldo(int vali) // este sera el metodo para consultar el saldo
        {
            titulo();
            Console.WriteLine("CONSULTA DE SALDO \n");
            Console.WriteLine($"Su saldo es ${us.saldo[vali]} \n"); // aqui segun el usuario selecionado se hace uso de la lista para validar el saldo, es un metodo bastante simple
        }

        public void retiro(int vali) // en el de retiro basandome en pues el tutorial y lo que se ve en un cajero hago un submenu
        {
            Console.WriteLine("------RETIROS------\n");
            Console.WriteLine("Monto a retirar");
            Console.WriteLine("1. 50.000");
            Console.WriteLine("2. 100.000 ");
            Console.WriteLine("3. 200.000 ");
            Console.WriteLine("4. 300.000 ");
            Console.WriteLine("5. 400.000 ");
            Console.WriteLine("6. Otro valor ");
            int selMon = int.Parse(Console.ReadLine()); // todo el switch va a estar basado en esta seleccion de monto selMon

            switch (selMon)
            {
                case 1:
                    if (50000 <= us.saldo[vali])
                    {
                        Puntos += 50000;
                        Saldo += 50000;
                        if (Saldo <= tope)
                        {
                            us.saldo[vali] -= 50000; //y la resta del saldo del usuario que estara en cada selección
                            Console.WriteLine("Retire su dinero\n\n"); //el promp de pantalla para retirar el dinero
                            Console.WriteLine($"Su saldo ahora es ${us.saldo[vali]} \n");
                        }
                        else
                        {
                            Console.WriteLine("El monto maximo de retiro en cajero es de $2.000.000 /d ");
                            Saldo -= 50000;
                            Puntos -= 50000;
                        }
                    }
                    else 
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione cualquier telca para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    optioUsuars(vali);
                    break;
                case 2:
                    if (100000 <= us.saldo[vali])
                    {
                        Puntos += 100000;
                        Saldo += 100000;
                        if (Saldo <= tope)
                        {
                            us.saldo[vali] -= 100000;
                            Console.WriteLine("Retire su dinero\n\n");
                            Console.WriteLine($"Su saldo ahora es ${us.saldo[vali]} \n");
                        }
                        else
                        {
                            Console.WriteLine("El monto maximo de retiro en cajero es de $2.000.000 /d ");
                            Saldo -= 100000;
                            Puntos -= 100000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione cualquier telca para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    optioUsuars(vali);
                    break;
                case 3:
                    if (200000 <= us.saldo[vali])
                    {
                        Puntos += 200000;
                        Saldo += 200000;
                        if (Saldo <= tope)
                        {
                            us.saldo[vali] -= 200000;
                            Console.WriteLine("Retire su dinero\n\n");
                            Console.WriteLine($"Su saldo ahora es ${us.saldo[vali]} \n");
                        }
                        else
                        {
                            Console.WriteLine("El monto maximo de retiro en cajero es de $2.000.000 /d ");
                            Saldo -= 200000;
                            Puntos -= 200000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione cualquier telca para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    optioUsuars(vali);
                    break;
                case 4:
                    if (300000 <= us.saldo[vali])
                    {
                        Puntos += 300000;
                        Saldo += 300000;
                        if (Saldo <= tope)
                        {
                            us.saldo[vali] -= 300000;
                            Console.WriteLine("Retire su dinero\n\n");
                            Console.WriteLine($"Su saldo ahora es ${us.saldo[vali]} \n");
                        }
                        else
                        {
                            Console.WriteLine("El monto maximo de retiro en cajero es de $2.000.000 /d ");
                            Saldo -= 300000;
                            Puntos -= 300000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione cualquier telca para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    optioUsuars(vali);
                    break;
                case 5:
                    if (400000 <= us.saldo[vali])
                    {
                        Puntos += 400000;
                        Saldo += 400000;
                        if (Saldo <= tope)
                        {
                            us.saldo[vali] -= 400000;
                            Console.WriteLine("Retire su dinero\n\n");
                            Console.WriteLine($"Su saldo ahora es ${us.saldo[vali]} \n");
                        }
                        else
                        {
                            Console.WriteLine("El monto maximo de retiro en cajero es de $2.000.000 /d ");
                            Saldo -= 400000;
                            Puntos -= 400000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione cualquier telca para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    optioUsuars(vali);
                    break;
                case 6:
                    Console.WriteLine("Ingrese el saldo a retirar sin puntos ni comas: "); //la cosa cambia un poco para la opcion 6 en esto solo genero una variable que se llama valor
                    int valor = int.Parse(Console.ReadLine()); // donde almacenare la cantidad ingresada por el usuario
                    if (valor <= us.saldo[vali])
                    {
                        Puntos += valor; // trato entonces esta cantidad como una cifra concreta como las dadas en el menu
                        Saldo += valor;
                        if (Saldo <= tope) 
                        {
                            us.saldo[vali] -= valor;
                            Console.WriteLine("Retire su dinero\n\n");
                            Console.WriteLine($"Su saldo ahora es ${us.saldo[vali]} \n");
                        }
                        else
                        {
                            Console.WriteLine("El monto maximo de retiro en cajero es de $2.000.000 /d ");
                            Saldo -= valor;
                            Puntos -= valor;
                        }
                    }
                    else
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione cualquier telca para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    optioUsuars(vali);
                    break;
            }
        }
        public void trans(int vali)
        {
            titulo();
            Console.WriteLine("Digite el documento de identificación del titular de la cuenta a transferir");
            int tran1 = int.Parse(Console.ReadLine());
            int valCuentaExistente = us.valCed(tran1);

            if (valCuentaExistente != -1) Console.WriteLine("Inciando proceso de trasnferencia...");
            else Console.WriteLine("Cuenta ingresada no existe\n");

            Console.WriteLine("Monto a trasnferir");
            Console.WriteLine("1. 100.000 ");
            Console.WriteLine("2. 200.000 ");
            Console.WriteLine("3. 300.000 ");
            Console.WriteLine("4. 400.000 ");
            Console.WriteLine("5. Otro valor ");
            int tran2 = int.Parse(Console.ReadLine());
            int verificacion = us.valCed(tran1);


            switch (tran2)
            {
                case 1:
                    if (100000 <= us.saldo[vali])
                    {
                        Console.WriteLine("Tranferencia exitosa\n");
                        us.saldo[vali] -= 100000;
                        Console.WriteLine($"Se ha enviado el monto de $100.000 a numero de cuenta: {us.id[verificacion]}\n\n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(vali);
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
                case 2:
                    if (200000 <= us.saldo[vali])
                    {
                        Console.WriteLine("Tranferencia exitosa\n");
                        us.saldo[vali] -= 200000;
                        Console.WriteLine($"Se ha enviado el monto de $200.000 a numero de cuenta: {us.id[verificacion]}\n\n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(vali);
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
                case 3:
                    if (300000 <= us.saldo[vali])
                    {
                        Console.WriteLine("Tranferencia exitosa\n");
                        us.saldo[vali] -= 300000;
                        Console.WriteLine($"Se ha enviado el monto de $300.000 a numero de cuenta: {us.id[verificacion]}\n\n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(vali);
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
                case 4:
                    if (400000 <= us.saldo[vali])
                    {
                        Console.WriteLine("Tranferencia exitosa\n");
                        us.saldo[vali] -= 400000;
                        Console.WriteLine($"Se ha enviado el monto de $400.000 a numero de cuenta: {us.id[verificacion]}\n\n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(vali);
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
                case 5:
                    Console.WriteLine("Ingrese el saldo a transferir sin puntos ni comas: ");
                    int valor = int.Parse(Console.ReadLine());
                    if (valor <= us.saldo[vali])
                        if (valor <= us.saldo[vali])
                    {
                        Console.WriteLine("Tranferencia exitosa\n");
                        us.saldo[vali] -= valor;
                        Console.WriteLine($"Se ha enviado el monto de {valor} a numero de cuenta: {us.id[verificacion]}\n\n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(vali);
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
            }
        }
        public void contPuntos(int vali)
        {
            titulo();
            Console.WriteLine("---CONSULTA DE PUNTOS VIVECOLOMBIA---\n");
            Console.WriteLine($"Su saldo en puntos ViveColombia es de: {us.points[vali]}\n");

        }
        public void usarPuntos(int vali)
        {
            Console.WriteLine("------CANJE DE PUNTOS------\n");
            Console.WriteLine("Monto a Canjear");
            Console.WriteLine("1. 500 ");
            Console.WriteLine("2. 1000 ");
            Console.WriteLine("3. 5000 ");
            Console.WriteLine("4. 10000 ");
            Console.WriteLine("5. 30000 ");
            Console.WriteLine("6. Otro valor ");
            int selPuntos = int.Parse(Console.ReadLine());

            switch (selPuntos)
            {
                case 1:
                    if (500 <= us.points[vali])
                    {
                        us.points[vali] -= 500;
                        us.saldo[vali] -= 500;
                        Console.WriteLine("Los puntos han sido canjeados");
                        Console.WriteLine($"Su saldo ahora es ${us.points[vali]} \n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Saldo de puntos insuficiente");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 2:
                    if (1000 <= us.points[vali])
                    {
                        us.points[vali] -= 1000;
                        us.saldo[vali] -= 1000;
                        Console.WriteLine("Los puntos han sido canjeados");
                        Console.WriteLine($"Su saldo ahora es ${us.points[vali]} \n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Saldo de puntos insuficiente");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 3:
                    if (5000 <= us.points[vali])
                    {
                        us.points[vali] -= 5000;
                        us.saldo[vali] -= 5000;
                        Console.WriteLine("Los puntos han sido canjeados");
                        Console.WriteLine($"Su saldo ahora es ${us.points[vali]} \n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Saldo de puntos insuficiente");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 4:
                    if (10000 <= us.points[vali])
                    {
                        us.points[vali] -= 10000;
                        us.saldo[vali] -= 10000;
                        Console.WriteLine("Los puntos han sido canjeados");
                        Console.WriteLine($"Su saldo ahora es ${us.points[vali]} \n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Saldo de puntos insuficiente");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 5:
                    if (30000 <= us.points[vali])
                    {
                        us.points[vali] -= 30000;
                        us.saldo[vali] -= 30000;
                        Console.WriteLine("Los puntos han sido canjeados");
                        Console.WriteLine($"Su saldo ahora es ${us.points[vali]} \n");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Saldo de puntos insuficiente");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Ingrese los puntos a canjear: ");
                    int valor = int.Parse(Console.ReadLine());
                    if (valor <= us.saldo[vali])
                        if (valor <= us.points[vali])
                    {
                        us.points[vali] -= valor;
                        us.saldo[vali] -= valor;
                        Console.WriteLine("Los puntos han sido canjeados");
                            Console.WriteLine($"Su saldo ahora es ${us.points[vali]} \n");
                            Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                    else Console.WriteLine("Saldo de puntos insuficiente");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("opcion invalida");
                    break;
            }
        }
        public void titulo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("●▬▬▬▬▬๑⇩⇩๑▬▬▬▬▬●●▬▬▬▬▬๑⇩⇩๑▬▬▬▬▬●●▬▬▬▬▬๑⇩⇩๑▬▬▬▬▬●●▬▬▬▬▬๑⇩⇩๑▬▬▬▬▬●");
            Console.WriteLine("                CAJERO JORGE ESTEBAN DAWSON                     ");
            Console.WriteLine("                          GRUPO  112                            ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("●▬▬▬▬▬๑⇧⇧๑▬▬▬▬▬●●▬▬▬▬▬๑⇧⇧๑▬▬▬▬▬●●▬▬▬▬▬๑⇧⇧๑▬▬▬▬▬●●▬▬▬▬▬๑⇧⇧๑▬▬▬▬▬●");
        }

    }
}
