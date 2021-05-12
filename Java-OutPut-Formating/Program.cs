using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_OutPut_Formating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe tres entradas");
            for (int i = 0; i < 3; i++)
            {
                String tam1 = Console.ReadLine();
                int tam2 = Int32.Parse(Console.ReadLine());
                if (Convert.ToString(tam2).Length == 3)
                {
                    Console.WriteLine(tam1 + "  " + tam2);
                }
                else if (Convert.ToString(tam2).Length < 3)
                {
                    Console.WriteLine(tam1 + "  " + "0" + tam2);
                }
            }
        }
    }
}
