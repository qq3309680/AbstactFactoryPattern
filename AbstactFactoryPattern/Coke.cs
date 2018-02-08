using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 14:37:57
    /// Mail : tanz01@haid.com.cn
    /// Description : 饮料类2，可乐
    /// </summary>
    public class Coke : KFCDrink
    {
        public override void Display()
        {
            Console.WriteLine("可乐+1");
        }
    }
}
