using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 14:35:32
    /// Mail : tanz01@haid.com.cn
    /// Description : 食物类2，鸡翅
    /// </summary>
    public class Wings : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡翅+1");
        }
    }
}
