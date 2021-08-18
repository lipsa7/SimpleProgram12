using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            Console.WriteLine(UserProgramCode.testValid(input1, input2));
            Console.ReadKey();

        }
    }

    class UserProgramCode
    {
        public static string testValid(string input1, string input2)
        {
            if (input1.Substring(0, 4) == "CTS-")
                if (input1.Substring(4, 3) == input2.Substring(0, 3))
                    if (input1.Substring(7, 1) == "-")
                        if (int.Parse(input1.Substring(8, 4)) <= 9999 && int.Parse(input1.Substring(8, 4)) >= 0)
                            return "Valid";
                        else
                            return "Not Valid";



            return "a";
        }
    }
}
