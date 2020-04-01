using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class passworddoor : Door, Ipassword
    {
        int _word;

        public int Word { get => _word; set => _word = value; }
        public void password()
        {
            Console.WriteLine("警告！！非法入侵");
        }

    }
}
