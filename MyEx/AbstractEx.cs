using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 抽象类练习
    /// </summary>
    public class AbstractEx
    {

        public abstract class Person
        {
            public abstract string Name { get; set; }

            public abstract string Area { get; set; }
        }

        public class Student : Person
        {
            private string name_;
            private string area_;
            private string school_;

            public override string Name { get { return name_; } set { name_ = value; } }
            public override string Area { get  { return area_; } set { area_ = value; } }

            public string School { get { return school_; }  set { school_ = value; } }
        }

        public class Teacher : Person
        {
            private string name_;
            private string area_;
            private string school_;
            private string position_;

            public override string Name { get { return name_; } set { name_ = value; } }
            public override string Area { get { return area_; } set { area_ = value; } }

            public string School { get { return school_; } set { school_ = value; } }
            public string Position { get { return position_; } set { position_ = value; } }
        }

        public void GetInfomation()
        {
            Student St = new Student();
            Teacher Ta = new Teacher();

            St.Name = "王二";
            St.Area = "福州";
            St.School = "城门中学";

            Ta.Name = "李三";
            Ta.Area = "漳州";
            Ta.School = "一中";
            Ta.Position = "高级教师";


            Console.WriteLine(string.Format("我叫 {0},我是{1} 人,我来自{2}", St.Name, St.Area, St.Area + " " + St.School));
            Console.WriteLine(string.Format("我叫 {0},我是{1} 人,我来自{2},我的职位是{3}", Ta.Name, Ta.Area, Ta.Area + " " + Ta.School, Ta.Position));
            Console.ReadKey();
        }
    }
}
