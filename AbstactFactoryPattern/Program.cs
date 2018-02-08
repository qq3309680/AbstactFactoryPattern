using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KFC廉价套餐:");
            IKFCFactory cheapOne = new CheapPackageFactory();
            KFCFood cheapFood = cheapOne.CreateFood();
            KFCDrink cheapDrink = cheapOne.CreateDrink();
            cheapFood.Display();
            cheapDrink.Display();
            Console.WriteLine("KFC豪华套餐:");
            IKFCFactory luxuryOne = new LuxuryPackageFactory();
            KFCFood luxuryFood = luxuryOne.CreateFood();
            KFCDrink luxuryDrink = luxuryOne.CreateDrink();
            luxuryFood.Display();
            luxuryDrink.Display();
            Console.ReadLine();
        }
    }
}
