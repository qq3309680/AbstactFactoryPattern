using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 14:47:11
    /// Mail : tanz01@haid.com.cn
    /// Description : 豪华型套餐，包括鸡腿和咖啡
    /// </summary>
    public class LuxuryPackageFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Chicken();
        }

        public KFCDrink CreateDrink()
        {
            return new Coffee();
        }
    }
}
