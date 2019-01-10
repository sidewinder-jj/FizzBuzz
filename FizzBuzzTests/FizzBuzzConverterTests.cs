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
        const string lucky = "Lucky";

        [Fact]
        public void FizzBuzzConverter_ReturnsFizz_MultipleOfThree()
        {
            var multipleOfThree = 3;
            var converter = new FizzBuzzConverter();

            var result = converter.Convert(multipleOfThree);
            
            Assert.Equal(fizz, result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsInputNumber_NotMultipleOfThreeOrFive()
        {
            var numberWhichIsntMultiple = 2;
            var converter = new FizzBuzzConverter();

            var result = converter.Convert(numberWhichIsntMultiple);

            Assert.Equal(numberWhichIsntMultiple.ToString(), result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsBuzz_MultipleOfFive()
        {
            var multipleOfFive = 5;
            var converter = new FizzBuzzConverter();

            var result = converter.Convert(multipleOfFive);

            Assert.Equal(buzz, result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsFizzBuzz_MultipleOfThreeAndFive()
        {
            var multipleOfThreeAndFive = 15;
            var converter = new FizzBuzzConverter();

            var result = converter.Convert(multipleOfThreeAndFive);

            Assert.Equal(fizz + buzz, result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsLucky_ResultContainsAThree()
        {
            var numberContainingAThree = 3;
            var converter = new FizzBuzzConverter();

            var result = converter.Convert(numberContainingAThree);

            Assert.Equal(lucky, result);
        }
    }
}
