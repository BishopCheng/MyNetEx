using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
        public void InsertLstNum(out string result)
        {
            for (int i = 1; i <=100; i++)
            {
                lstNum.Add(i+"");
            }            
            result= lstNum.Count == 100 ? "学号添加成功" : "学号添加失败"; 
        }

        /// <summary>
        /// 初始化姓名数据
        /// </summary>
        public void InitNameData()
        {
            
        }

        /// <summary>
        /// 获取名字列表
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        public List<string> GetGivenNameLst(string filepath) {
            
        }


    }
}
