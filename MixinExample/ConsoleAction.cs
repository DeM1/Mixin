using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixinExample
{
    public static class ConsoleAction
    {
        public static void WriteLine(
         this ConsoleBehavior consoler,
         string output) { }



        public static void ReadKey(
          this ConsoleBehavior consoler)
        {
            Console.ReadKey();
        }
    }
}
