using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 匿名类使用
    /// </summary>
    public class Anonymous
    {
        //匿名内部类使用 
        

        public void Say()
        {
            var Student = new { ID = "0001", Name = "WANG", Sex = "男" };
            Console.WriteLine("我是 " + Student.Name + ",我的编号是 " + Student.ID);
        }

        public class Employee
        {
            string ID { get; set; }
            string Name { get; set; }

            string Sex { get; set; }
            
        }
    }
}
