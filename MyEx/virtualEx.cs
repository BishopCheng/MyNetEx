using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 虚函数练习
    /// </summary>
     public class virtualEx
    {
        public class Property
        {
            public int length { get; set; }

            public int width { get; set; }

            public int height { get; set; }
        }


        public class Cal {
            public virtual void Calculate(int lenghtInput,int widthInput,int heightInput) {
                Console.WriteLine("The triangle's Area is " + lenghtInput*heightInput*0.5);
            }

        }

        public class CalPerimete : Cal
        {
            public override void Calculate(int lenghtInput, int widthInput, int heightInput)
            {
                Console.WriteLine("The triangle's Perimeter is " + (lenghtInput + widthInput + heightInput));
            }
        }

        
    }
}
