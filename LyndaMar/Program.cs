using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyndaMar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region variables

            //Declarar variables
            string nombreUsuario, apellidosUsuario, perfil, direccionUsuario, celularUsuario, usuarioAcceso, contraseña, confirmarContraseña;
            byte edadUsuario;
            #endregion
            #region datos usuario

            //El usuario llena las variables con sus datos
            Console.WriteLine("Ingresa tu nombre, después presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, después presiona ENTER");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //Edad usuario menor o mayor de edad
            if (edadUsuario < 18)
            {
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("No podemos validar tu acceso, debes ser mayor de edad");

                }
            }
            else
            {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Ingresa tus apellidos");
                    apellidosUsuario = Console.ReadLine();
                    Console.WriteLine("Ingresa tu dirección");
                    direccionUsuario = Console.ReadLine();
                    Console.WriteLine("Ingresa tu número de celular");
                    celularUsuario = Console.ReadLine();
                    Console.WriteLine("Ingresa tu perfil de facebook");
                    perfil = Console.ReadLine();
                    Console.WriteLine("Ingresa tu nombre de usuario");
                    usuarioAcceso = Console.ReadLine();
                    Console.WriteLine("Ingresa tu contraseña");
                    contraseña = Console.ReadLine();
                    Console.WriteLine("Confirma tu contraseña");
                    confirmarContraseña = Console.ReadLine();

                //Código de Acceso
                if (contraseña == confirmarContraseña)
                {
                   // Resultados
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Resultados");
                    Console.WriteLine("\n Nombre: {0},\n Edad: {1},\n Apellidos {2},\n Dirección {3},\n Celular: {4},\n Perfil: {5},\n Usuario: {6},\n Contraseña: {7},", nombreUsuario, edadUsuario, apellidosUsuario, direccionUsuario, celularUsuario, perfil, usuarioAcceso, contraseña);

                    Random Aleatorio = new Random();
                    int codigoAcceso = Aleatorio.Next(1000, 9999);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n Código de acceso:" + codigoAcceso);
                    Console.ReadLine();
                    #endregion
                    
                }


            }
        }
    }
}