using System;
using System.Collections.Generic;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzConverterTests
    {
        const string fizz = "Fizz";
        const string buzz = "Buzz";

        [Fact]
        public void FizzBuzzConverter_ReturnsFizz_MultipleOfThree()
        {
            var multipleOfThree = 3;
            var fizzBuzz = new FizzBuzzConverter();

            var result = fizzBuzz.Convert(multipleOfThree);
            
            Assert.Equal(fizz, result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsInputNumber_NotMultipleOfThreeOrFive()
        {
            var numberWhichIsntMultiple = 2;
            var fizzBuzz = new FizzBuzzConverter();

            var result = fizzBuzz.Convert(numberWhichIsntMultiple);

            Assert.Equal(numberWhichIsntMultiple.ToString(), result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsBuzz_MultipleOfFive()
        {
            var multipleOfFive = 5;
            var fizzBuzz = new FizzBuzzConverter();

            var result = fizzBuzz.Convert(multipleOfFive);

            Assert.Equal(buzz, result);
        }
    }
}
