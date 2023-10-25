using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_cajero
{
    class Usuario
    {
        public int[] id = { 123456, 456789, 987654 }; //todo basado en listados, como decia en el programa general, lo ideal seria que fuera una base de datos pero aun no sé como hacer eso
        public int[] password = { 123, 456, 789 }; // cada posicion corresponde al mismo usuario en todas los metodos
        public int[] saldo = { 3000000, 4000000, 5000000 };
        public int[] points = { 100000, 20000, 30000 };
        public int valCed(int cedula)
        {
            int respuesta = -1; //este es el metodo de validacion de la cedula 
            for(int i = 0; i < id.Length; i++)
            {
                if (id[i] == cedula)
                {
                    respuesta = i;
                }
            }
            return respuesta;
        }
        public int valPass (int clave) //ambos metodos procuran que lo ingresado por el usuario y transformado a int sea igual a lo que está almacenado
        {
            int respuesta = -1; //igual con el metodo de validacion de clave
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == clave)
                {
                    respuesta = i;
                }
            }
            return respuesta;
        }
    }
}
