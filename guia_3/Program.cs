using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("* Practica Nª 2 *");
                Console.WriteLine("\n* 1 * Ejercicio 1");
                Console.WriteLine("* 2 * Ejercicio 2");
                Console.WriteLine("* 3 * Ejercicio 3");
                Console.WriteLine("* 4 * Ejercicio 4");
                Console.WriteLine("* 5 * Ejercicio 5");
                Console.WriteLine("* 6 * Ejercicio 6");
                Console.WriteLine("* 7 * Ejercicio 7");
                Console.WriteLine("* 8 * Ejercicio 8");
                Console.WriteLine("* 9 * SALIR");
                Console.WriteLine("\nSeleccione ejercicio a ejecutar");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        ejer1 a = new ejer1();
                        a.ejerUno();                        
                        break;
                    case 2:
                        Console.Clear();
                        ejer2 b = new ejer2();
                        b.ejerDos();
                        
                        break;
                    case 3:
                        Console.Clear();
                        Ejer3 c = new Ejer3();
                        c.ejerTres();
                        break;
                    case 4:
                        Console.Clear();
                        Ejer4 d = new Ejer4();
                        d.ejerCuatro();
                        break;
                    case 5:
                        Console.Clear();
                        Ejer5 e = new Ejer5();
                        e.ejerCinco();
                        break;
                    case 6:
                        Console.Clear();
                        Ejer6 f = new Ejer6();
                        f.ejerSeis();
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }
            }
            while (op != 8);
            Console.WriteLine("Presione <ENTER> para continuar.");
            Console.ReadKey();         
        }
    }
}
