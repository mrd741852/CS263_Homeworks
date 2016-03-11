using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            student someone =
                new student
                {
                    name = "小陳",
                    phone = "0912345672",
                    email = "abc@gmail.com", 
                    Add="台北市"

                };
            Console.WriteLine(someone.name);
            Console.WriteLine(someone.phone);
            Console.WriteLine(someone.email);
            Console.WriteLine(someone.Add);
        }
    }
}
