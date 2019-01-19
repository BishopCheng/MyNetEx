using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 扩展方法类
    /// </summary>
    public static class ExtendMethod
    {
        public static int GetCount(this string s) =>
              s.Split().Length;
       
    }
}
