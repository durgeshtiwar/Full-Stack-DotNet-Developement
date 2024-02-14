// using System;
// namespace Helloworld
// {
//     class Praogram{
//         public static void Main(string[] args)
//         {
//             int x;
//             int y;
//             x = 5;
//             y = 59;
//             Console.WriteLine(x);
//             Console.WriteLine(y);
//         }
//     }
// }

using System;
namespace OddorEvenApp{
    class  Praogram{
        public static void Main(string[] args)
        {
            Console.Write("Enter the no.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 == 0){
                Console.WriteLine("the no is even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}