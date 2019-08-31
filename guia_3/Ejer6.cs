using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class Ejer6
    {
        public void ejerSeis()
        {
            decimal compra = 0.00M, desc = 0.00M, total=0.00M;
            Console.WriteLine("Ingrese monto de compra: ");
            decimal.TryParse(Console.ReadLine(), out compra);
            if (compra>=0M && compra<=100M)
            {
                desc = 0.00M;
            }
            else
            {
                if (compra >= 100.01M && compra <= 200M)
                {
                    desc = compra * 0.12M;
                }
                else
                {
                    if (compra >= 200.01M && compra <= 500M)
                    {
                        desc = compra * 0.15M;
                    }
                    else
                    {
                        if (compra >= 0M && compra <= 100M)
                        {
                            desc = compra * 0.12M;
                        }
                        else
                        {
                            if (compra >= 500.01M)
                            {
                                desc = compra * 0.20M;
                            }
                        }
                    }
                }
            }
            total = compra - desc;
            Console.WriteLine("Descuento: "+desc);
            Console.WriteLine("Total a pagar: "+total);
        }
    }
}
