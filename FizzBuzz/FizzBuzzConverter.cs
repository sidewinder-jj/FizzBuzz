using System;

namespace FizzBuzzKata
{
    public class FizzBuzzConverter
    {
        public string Convert(int input)
        {
            if (input % 3 == 0) 
                return "Fizz";
            
            return input.ToString();
        }
    }
}
