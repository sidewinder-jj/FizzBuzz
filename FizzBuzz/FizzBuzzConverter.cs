using System;

namespace FizzBuzzKata
{
    public class FizzBuzzConverter
    {
        public string Convert(int input)
        {
            var fizz = "Fizz";
            var buzz = "Buzz";
            var DivisibleByThree = (input % 3 == 0);
            var DivisibleByFive = (input % 5 == 0);
                
            if (DivisibleByThree && DivisibleByFive)
                return fizz+buzz;
            
            if (DivisibleByThree) 
                return fizz;

            if (DivisibleByFive)
                return buzz;
            
            return input.ToString();
        }
    }
}
