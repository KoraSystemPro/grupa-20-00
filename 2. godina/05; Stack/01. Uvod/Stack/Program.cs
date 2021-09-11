using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stek = new Stack();
            int unet;
            do
            {
                unet = Convert.ToInt32(Console.ReadLine());

                stek.Push(unet);
            }
            while (unet != 0);


            int dubina_steka = stek.Count;
            for (int i = 0; i < dubina_steka; i++)
            {
                Console.Write(stek.Peek() + " ");
                stek.Pop();
            }

            Console.ReadKey();
        }
    }
}
