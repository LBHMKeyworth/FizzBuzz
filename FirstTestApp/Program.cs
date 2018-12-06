using System;

namespace FirstTestApp
{
    class FizzBangTest
    {
        static void Main(string[] args)
        {
            FB fizzBuzz = new FB();
            for (int i = 1; i <= 100; i ++)
            {
                Console.WriteLine(fizzBuzz.FizzBuzz(i));
            }
            Console.Read(); 

        }
    }
    public class FB : IFB
    { 
        public string FizzBuzz(int valueIn)
        {
            string returnVal = string.Empty;
            switch (valueIn)
            {
                case int val when (valueIn % 3 == 0 && valueIn % 5 == 0):
                    returnVal = "fizzbuzz";
                    break;
                case int val when valueIn % 3 == 0:
                    returnVal = "fizz";
                    break;
                case int val when valueIn % 5 == 0:
                    returnVal = "buzz";
                    break;
                default:
                    returnVal = valueIn.ToString();
                    break;
            }
            return returnVal;
        }
    }
}



