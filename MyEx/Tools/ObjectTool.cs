using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MyEx.Tools
{
    /// <summary>
    /// Object工具类
    /// </summary>
    public static class ObjectTool
    {

        public static IEnumerable<CharEntity> GetJsonObjectListFromJsonFile(string filePath)
        {
            IList<CharEntity> CharList = new List<CharEntity>();
            
        }

        public static Dictionary<string,string> GetProperties(object obj)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            if (obj == null) { return Dic; }
            Type types = obj.GetType();   //获取所有对象属性和值的集合
            foreach (PropertyInfo item in types.GetProperties())
            {
                Dic.Add(item.Name.ToString(), item.GetValue(obj, null).ToString());
            }
            return Dic;
        }

        public static Dictionary<int,Object> GetCharDictionary(object obj)
        {
            Dictionary<int, Object> Dic = new Dictionary<int, Object>();
            if (obj == null) { return Dic; }
            Type types = obj.GetType();
            foreach (PropertyInfo item in types.GetProperties())
            {
                Dic.Add(Convert.ToInt32(item.Name), item.GetValue(obj, null).ToString());
            }
            return Dic;
        }


    }
}
