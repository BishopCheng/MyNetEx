using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 接口练习
    /// </summary>
     public class InterfaceEx
    {
        public interface Mixed {
            string Mix();
        }

        public class Milk : Mixed {

            public int Id { get; set; }
            public string Name { get { return "牛奶"; } }

            public string Mix()
            {
               return "混合";
            }
        }

        public class Coffee : Mixed {

            public int Id { get; set; }
            public string Name { get { return "咖啡"; } }

            public  string Mix()
            {
                return "混合";
            }
        }


        public void GetMixed ()
        {
            Milk mI = new Milk();
            Coffee Co = new Coffee();

            object s = "巧克力";

            Console.WriteLine(string.Format("{0}{1}{2},得到{3}", mI.Name, Co.Name, mI.Mix(),s));
            Console.ReadKey();
        }
    }
}
