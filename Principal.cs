using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
   public class Principal
    {
     
        public void Bienvenida()
        {
            Console.WriteLine("=======BIENVENIDO A MI BANCO EN LINEA======");
            Menu();
        }
        public void Menu()
        {
            Modelo_Inversion modelo = new Modelo_Inversion();

            Console.WriteLine("Elige una de los modelos de inversión:\n1-.A corto plazo\n2-.A largo plazo\n3-.Salir");
            Console.WriteLine("======================================");
            switch (Console.ReadLine())
            {
                case "1":
                    modelo.Cortoplazo();
                    break;

                case "2":
                    modelo.Largoplazo();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Valor no encontrado");
                    Console.ReadKey();
                    Console.Clear();
                    Bienvenida();
                    break;
            }
        }
     
    }
}
