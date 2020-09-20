
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma1 = 0;
            int soma2 = 0;
            Console.WriteLine("As corridas vão começar:");
            for (int i=0; i < Convert.ToInt32(args[4]); i++) {


                Random valor0 = new Random();
                Random valor1 =new Random(valor0.Next(i*58996));
            Random valor2 = new Random(valor0.Next(i*58758));
            int jog1 = valor1.Next(Convert.ToInt32(args[1]));
            int jog2 = valor2.Next(Convert.ToInt32(args[3]));
                soma1 = (jog1 > jog2) ? (soma1 + 1): (soma1 + 0);
                soma2 = (jog2 > jog1) ? (soma2 + 1) : (soma2 + 0);

                string vencedor = (jog1 > jog2) ? args[0]: args[2];

            Console.WriteLine(" {0}:{1} km/h e {2}:{3} km/h vencedor é {4}", args[0],jog1,args[2],jog2,vencedor);
            

            }


            string gdeVencedor = (soma1 > soma2) ? args[0] : args[2];
            int nrVitorias = (soma1 > soma2) ? soma1 : soma2;
            Console.WriteLine("O Grande Vencedor das {2} corridas é {0} por {1} Vitorias", gdeVencedor,nrVitorias, args[4]);



        }
    }
}
