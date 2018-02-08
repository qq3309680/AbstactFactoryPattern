using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 14:44:00
    /// Mail : tanz01@haid.com.cn
    /// Description : 经济型套餐，包括鸡翅和可乐
    /// </summary>
    public class CheapPackageFactory : IKFCFactory
    {

        KFCFood IKFCFactory.CreateFood()
        {
            return new Wings();
        }

        KFCDrink IKFCFactory.CreateDrink()
        {
            return new Coke();
        }
    }
}
