using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            passworddoor passworddoor = new passworddoor();
            Console.WriteLine("please input password：");
            string mima = Console.ReadLine();
            int Mima = int.Parse(mima);
            passworddoor.Word = 123456;
            if (Mima == 123456)
            {
                passworddoor.open();
            }
            else
            {
                passworddoor.close();
                passworddoor.password();
            }
        }
    }
}
