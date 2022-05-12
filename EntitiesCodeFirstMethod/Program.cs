using EntitiesCodeFirstMethod.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCodeFirstMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(GameDataBaseContext context = new GameDataBaseContext())
            {
                
            }
            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
