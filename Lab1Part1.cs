using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ogNum1, ogNum2, ones, tens, hundreds, ones2, tens2, hundreds2;

            Console.WriteLine("Please input a 3 digit number.");
            String userInput1 = Console.ReadLine();
            ogNum1 = int.Parse(userInput1);

            hundreds = ogNum1 / 100;
            tens = (ogNum1 / 10) % 10;
            ones = ogNum1 % 10;

            Console.WriteLine(hundreds);
            Console.WriteLine(tens);
            Console.WriteLine(ones);

            Console.WriteLine("Please input your second 3 digit number.");
            String userInput2 = Console.ReadLine();
            ogNum2 = int.Parse(userInput2);

            hundreds2 = ogNum2 / 100;
            tens2 = (ogNum2 / 10) % 10;
            ones2 = ogNum2 % 10;

            Console.WriteLine(hundreds2);
            Console.WriteLine(tens2);
            Console.WriteLine(ones2);

            Console.WriteLine(TestProject(ones, ones2, tens, tens2, hundreds, hundreds2).ToString());

            Console.ReadKey();
        }

        static bool TestProject(int iOnes, int iOnes2, int iTens, int iTens2, int iHundreds, int iHundreds2)
        {

            if (iOnes + iOnes2 == iTens + iTens2 && iTens + iTens2 == iHundreds + iHundreds2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
