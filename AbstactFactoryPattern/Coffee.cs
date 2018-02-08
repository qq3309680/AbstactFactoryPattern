using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 14:36:52
    /// Mail : tanz01@haid.com.cn
    /// Description : 饮料类1，咖啡
    /// </summary>
    public class Coffee : KFCDrink
    {
        public override void Display()
        {
            Console.WriteLine("咖啡+1");
        }
    }
}
