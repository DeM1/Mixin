using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixinExample
{
    class Program
    {
        static ConsoleBehavior Console;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            var d = new Dog();
            d.Bark();

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}

