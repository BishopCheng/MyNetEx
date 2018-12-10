using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
     public  class LoopEx
    {
        //循环练习
        public void GetLoopWrite()
        {
            for (int i = 0; i < 100; i+=10)
            {
                for (int j = i; j < 10+i; j++)
                {
                    Console.Write(j.ToString() + "  ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
