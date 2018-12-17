using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;
using MyEx.Tools;

namespace MyEx
{
    /// <summary>
    /// 重载练习类
    /// </summary>
    /// 


    public class OverLoad
    {
        private int flag = 0;
        public enum Positon
        {
             职员=0,
             经理=1
        }

        public enum Department {
            销售部 =0,
            研发部=1,
            人事部=2
        }


        private IList<Employee> employeesList = new List<Employee>()
        {
            new Employee{ Number=1,Name="张三",Position=0 },
            new Employee{ Number=2,Name="李四",Position=0 },
            new Employee{ Number=3,Name="王五",Position=0 },
            new Employee{ Number=4,Name="赵六",Position=0 }
        };

        private IList<Manager> managersList = new List<Manager>()
        {
            new Manager{ Number=1,Name="王可",Position=1, Department ="研发部" },
            new Manager{ Number=2,Name="李四",Position=1, Department ="销售部" }
        };

        //定义字典
        Dictionary<string, string> Dic = new Dictionary<string, string>() {
            { "Number","工号" },{ "Name","姓名" },{ "Position","职位" },{ "Department","部门" }
        };
        
        

        public class Employee
        {
            private int number_;
            private string name_;
            private int position_;

            public int Number {
                get { return number_; }
                set {
                    if (number_ == 0) { number_ = value; }
                }
            }

            public string Name
            {
                get {
                    return name_;
                }
                set
                {
                    name_ = value;
                }
            }

            public int Position
            {
                get { return position_; }
                set { position_ = value; }
            }
        }

        public class Manager
        {
            private int number_;
            private string name_;
            private int position_;
            private string department_;

            public int Number
            {
                get { return number_; }
                set
                {
                    if (number_ == 0) { number_ = value; }
                    
                }
            }

            public string Name
            {
                get { return name_; }
                set { name_ = value; }
            }

            public int Position
            {

                get { return position_; }
                set { position_ = value; }
            }

            public string Department
            {
                get { return department_; }
                set { department_ = value; }
            }
        }

        

        //设计两个人员，一个员工，1个经理，员工有2个属性：姓名和职务，经理有3个属性：姓名，职务和部门，给定员工类和经理类，输入员工编号，给出他们的信息， 使用重载方法输出

           public void PrintMember()
         {
            Dictionary<string, string> dicGetList = new Dictionary<string, string>();
            List<Object> listGet = new List<object>();
            Ag: if (flag == 0) { Console.WriteLine("程序开始"); }
            else { Console.WriteLine("程序继续"); }
            Console.WriteLine("请输入参数：输入一个编号，查询员工；输入编号和部门，查询经理");
            string S1 = Console.ReadLine();
            Console.WriteLine("您是否还要继续输入参数？是按Y，否按N");
            string S2 = Console.ReadLine();
            string S3 = "";
            if (S2.Equals("N"))
            {
                
                listGet = GetEmployee(S1);
            }
            else
            {
                Console.WriteLine("请输入部门参数,编号范围为0-2");
                S3 = Console.ReadLine();
                listGet = GetEmployee(S1, S3);
            }

            //获取ListGet中各项属性的键和值
            dicGetList = ObjectTool.GetProperties(listGet[0]);
            if (dicGetList != null)
            {
                Console.WriteLine("您输入的员工编号为：" + S1 +",该员工的资料为：");
                foreach (var item in dicGetList)
                {
                    var containItemKey = Dic.Where(c => c.Key.ToString() == item.Key).FirstOrDefault().Value;
                    string containItemValue = "";
                    if (item.Key.Contains("Postion"))
                    {
                        containItemValue = (string)Enum.Parse(typeof(Positon), item.Value.ToString());
                    }
                    else { containItemValue = item.Value; }
                    Console.WriteLine(containItemKey + "  " + containItemValue);   
                }
                Console.ReadKey();
            }   
            else {
                Console.WriteLine("没有找到符合条件的员工资料！");
                
            }
            flag += 1;
            Console.WriteLine("是否需要重新查询？？是按Y，否按N");
            string key = Console.ReadLine();
            if (key.Contains("Y") || key.Contains("y"))
            {
                //跳转执行
                goto Ag;
            }
            else if (key.Contains("N") || key.Contains("n"))
            {
                Console.WriteLine("谢谢使用,程序结束！");
                
            }
            else {
                Console.WriteLine("输入错误！");

            }
            Console.ReadKey();
        }
          
        private List<Object> GetEmployee(string params1)
        {
            //一个参数,查找员工
            int pa = Convert.ToInt32(params1);
            List<Employee> employee = employeesList.Where(c => c.Number == pa).ToList();
            //将Employee类转换成object类
            return employee.ConvertAll(s=>(object)s);
        }

        private List<Object>GetEmployee(string params1,string params2)
        {
            //两个参数,查找经理
            int pa1 = Convert.ToInt32(params1);
            string pa2 = params2;
            List<Manager> managers = managersList.Where(c => c.Number == pa1 && c.Name == pa2).ToList();
            return managers.ConvertAll(s => (object)s);
        }
             
    }
}

