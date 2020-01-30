using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
   public class Modelo_Inversion
    {
        Cliente cliente = new Cliente();
        List<Cliente> clientes = new List<Cliente>();
        Principal principal = new Principal();
        public void Cortoplazo()
        {
          Console.WriteLine("Inversión a corto plazo, en el cual le dará un 3 % por cada mes\nque el cliente invierta la cantidad mínima de 3000 pesos.");
            ObtenerInformacion();
            cliente.Total = cliente.Inversion*(1 + cliente.Tiempo*(0.03));
            foreach(var us in clientes)
            {
                Console.WriteLine("usuario:" + us.Nombre);
                Console.WriteLine("Tipo inversion:" + us.ModoInversion);
                Console.WriteLine("Monto:" + us.Inversion);
                Console.WriteLine("final:" + us.Total);
                Console.ReadKey();
            }
            Console.Clear();
            principal.Bienvenida();
        }
        public void Largoplazo()
        {
            Console.WriteLine("Inversión a largo plazo, en el cual le dará un 11% por cada 1000 pesos\n que el cliente invierta durante un año.\n");
            ObtenerInformacion();
            foreach (var us in clientes)
            {
                if (us.Inversion >= 1000)
                {
                    cliente.Total = cliente.Inversion * (1 + cliente.Tiempo * (0.11));

                     Console.WriteLine("usuario:" + us.Nombre);
                     Console.WriteLine("Tipo inversion:" + us.ModoInversion);
                     Console.WriteLine("Monto:" + us.Inversion);
                     Console.WriteLine("final:" + us.Total);
                     Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("usuario:" + us.Nombre);
                    Console.WriteLine("Tipo inversion:" + us.ModoInversion);
                    Console.WriteLine("Monto:" + us.Inversion);
                    Console.WriteLine("final:" + us.Total);
                    Console.ReadKey();
                }
            }
            Console.Clear();
            principal.Bienvenida();

        }
        public void ObtenerInformacion()
        {
            Console.WriteLine("Ingresa tu nombre completo:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Confirma tu modelo de inversion:");
            cliente.ModoInversion = Console.ReadLine();
            Console.WriteLine("Ingresa la cantidad que desees invertir:");
            cliente.Inversion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cuanto tiempo deseas tener nuestro modelo de inversión?");
            cliente.Tiempo = Convert.ToInt32(Console.ReadLine());
            clientes.Add(cliente);
        }
    }
}
