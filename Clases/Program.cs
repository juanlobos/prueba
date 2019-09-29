using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //float variable = 4.52f;
            //Console.Write("La variable es:{0}", variable);
            //Console.ReadLine();
            //Console.Write("Ingrese decimal:");
            //float n =Convert.ToSingle(Console.ReadLine());
            //Console.Write("el numero ingresado es:{0}", n);
            //Console.ReadLine();

            //Console.Write("Ingrese numero:");
            //int n =Convert.ToInt32(Console.ReadLine());

            //switch (n)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        {
            //            Console.Write("numero del 1 al 3");
            //            break;
            //        }
            //    case 4:
            //    case 5:
            //    case 6:
            //        {
            //            Console.Write("numero del 4 al 6");
            //            break;
            //        }
            //    case 7:
            //    case 8:
            //    case 9:
            //        {
            //            Console.Write("numero del 7 al 9");
            //            break;
            //        }
            //}
            Console.Write("Ingrese nombre:");
            string s=Console.ReadLine();
            switch (s)
            {
                case "juan":
                    {
                        Console.Write("bienvenido juan");
                        break;
                    }
                case "pedro":
                    {
                        Console.Write("bienvenido pedro");
                        break;
                    }
                default:
                    {
                        Console.Write("desconocido");
                    }
                    break;
            }
        }
    }
}
