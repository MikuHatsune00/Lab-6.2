using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            char[] chars = { ' ' };
            string[] stringArray = startString.Split(chars);
            string resultString = "";
            foreach (string s in stringArray)
            {
                resultString += s.Substring(0, 1).ToLower() + s.Substring(1);

            }
            char[] stringArrayBack = resultString.ToCharArray();
            string resultString2 = "";
            int last = stringArrayBack.Length - 1;
            for (int i = last; i >= 0; i--)
            {
                resultString2 += stringArrayBack[i];
            } 
                if (resultString==resultString2)
            {

                Console.WriteLine("Слово является палиндромом");
            }


            else { Console.WriteLine("Слово НЕ является палиндромом"); 
            }
           
            Console.ReadKey();
        }
    }
}
