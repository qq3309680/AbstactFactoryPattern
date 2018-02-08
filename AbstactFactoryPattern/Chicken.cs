using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 14:33:29
    /// Mail : tanz01@haid.com.cn
    /// Description : 食物类1，鸡腿
    /// </summary>
    public class Chicken : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡腿+1");
        }
    }
}
