using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 结构体练习
    /// </summary>
    public class StructEx
    {
        //任务  定义一个结构体，创建一个学生类 做一个报数器

        public struct Student
        {
            public string ID;
            public string Name;
          
        }

        //按字典规则随机生成50个学生,并按照学号从高到低排队

        Dictionary<string, string> DicName = new Dictionary<string, string>();
        List<string> lstNum = new List<string>();
        
        /// <summary>
        /// 写入学号
        /// </summary>
        /// <returns></returns>
        public int InsertLstNum()
        {

        }
    }
}
