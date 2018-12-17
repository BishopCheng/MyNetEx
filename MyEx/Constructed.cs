using System;
using System.Collections.Generic;
using System.Text;

namespace MyEx
{
    /// <summary>
    /// 构造函数练习
    /// </summary>
    public class Constructed
    {
        /// <summary>
        /// 汽车类
        /// </summary>
        public class Vehicle {
            private string description_;  //描述
            private uint nWheels_;        //轮子

            public Vehicle(string description,uint nWheels)
            {
                description_ = description;
                nWheels_ = nWheels;

                Console.WriteLine("这是一辆  " + description + " 牌汽车，有"+ nWheels+ "个轮子");
                Console.Read();
            }

            public Vehicle(string description) 
            {
                Console.WriteLine("这是一辆  " + description+ " 牌摩托车，有2个轮子");
                Console.Read();
            }
        }

        
    }
}
