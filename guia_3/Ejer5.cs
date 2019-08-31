using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class Ejer5
    {
        public void ejerCinco()
        {
            int num;
            do
            {
            Console.WriteLine("Ingrese un numero entre 1 y 10");
                int.TryParse(Console.ReadLine(), out num);
            } while (num<1 && num>10);
            if (num==1)
            {
                Console.WriteLine("Numero: Uno");
            }
            else
            {
                if (num == 2)
                {
                    Console.WriteLine("Numero: Dos");
                }
                else
                {
                    if (num == 3)
                    {
                        Console.WriteLine("Numero: Tres");
                    }
                    else
                    {
                        if (num == 4)
                        {
                            Console.WriteLine("Numero: Cuatro");
                        }
                        else
                        {
                            if (num == 5)
                            {
                                Console.WriteLine("Numero: Cinco");
                            }
                            else
                            {
                                if (num == 6)
                                {
                                    Console.WriteLine("Numero: Seis");
                                }
                                else
                                {
                                    if (num == 7)
                                    {
                                        Console.WriteLine("Numero: Siete");
                                    }
                                    else
                                    {
                                        if (num == 8)
                                        {
                                            Console.WriteLine("Numero: Ocho");
                                        }
                                        else
                                        {
                                            if (num == 9)
                                            {
                                                Console.WriteLine("Numero: Nueve");
                                            }
                                            else
                                            {
                                                if (num == 10)
                                                {
                                                    Console.WriteLine("Numero: Diez");
                                                }
                                                else
                                                {

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Presione <ENTER> para continuar.");
            Console.ReadKey();
        }
    }
}
