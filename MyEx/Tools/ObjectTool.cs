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
        public static Dictionary<string,string> GetProperties(object obj)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            if (obj == null) { return Dic; }
            Type types = obj.GetType();   //获取所有对象属性和值的集合
            foreach (PropertyInfo item in types.GetProperties())
            {
                Dic.Add(item.Name.ToString(), item.GetType().GetProperty(item.Name).GetValue(item,null).ToString());
            }
            return Dic;
        }
    }
}
