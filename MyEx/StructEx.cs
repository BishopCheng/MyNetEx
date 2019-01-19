using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

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

        //按字典规则随机生成100个学生,并按照学号从高到低排队

        Dictionary<int, string> DicName = new Dictionary<int, string>();
        Dictionary<int, string> FirstName = new Dictionary<int, string>();
        List<string> lstNum = new List<string>();
        List<Student> StuLst = new List<Student>();
        
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
            Console.WriteLine(result);
        }

        /// <summary>
        /// 初始化学生数据
        /// </summary>
        public void InitNameData()
        {
            Random rd = new Random();

            //从学号中随机选择一个，从姓中随机选择一个字，从名字中随机选择一或两个字 写入对象集合
            #region 学号生成
            int num = 0;
            num = rd.Next(1, 100);
            lstNum.Remove(num.ToString());
            #endregion

            #region 姓生成
            
            #endregion
        }

        /// <summary>
        /// 获取名字列表
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        public List<string> GetGivenNameLst(string filepath) {
            List<string> NameLst = new List<string>();
            using (StreamReader sr = new StreamReader(filepath,Encoding.UTF8))
            {
                string line = "";
                while(sr.ReadLine() != null)
                {
                    line = sr.ReadLine();

                    //将line中的文字存入list
                    line = line.Replace(" ", "");
                    for (int i = 0; i < line.Length; i++)
                    {
                        NameLst.Add(line.Substring(i, i + 1));
                    }
                }
            }
            return NameLst;
        }

        /// <summary>
        /// 将名字集合写入Json文件
        /// </summary>
        /// <param name="path"></param>
        public void ConvertToJsonFile(string path,List<string>NameLst)
        {
            int Count = NameLst.Count;
            var jsonStr= JsonConvert.SerializeObject(NameLst);
            string FilePath = path + "allName.json";
            try
            {
                //先判断文件是否存在，再创建文件
                if (!File.Exists(FilePath))
                {
                    FileStream fs = new FileStream(FilePath, FileMode.Create);
                    if (File.Exists(path + "allName.json"))
                    {
                        Console.WriteLine("姓名文件创建成功！");
                        fs.Close();
                        fs.Dispose();
                        //将jsonStr写入文件
                        using (StreamWriter sw = new StreamWriter(FilePath, true))
                        {
                            sw.WriteLine(jsonStr);
                            Console.WriteLine("共写入字个数 " + Count + " 个");
                            sw.Close();
                            sw.Dispose();
                        }
                       

                    }
                    else
                    {
                        Console.WriteLine("姓名文件创建失败,程序中止！");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
           
        }


    }
}
