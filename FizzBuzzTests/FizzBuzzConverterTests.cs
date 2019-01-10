using System;
using System.Collections.Generic;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzConverterTests
    {
        private readonly FizzBuzzConverter fizzBuzzConverter;
        public FizzBuzzConverterTests()
        {
            fizzBuzzConverter = new FizzBuzzConverter();
        }
        const string fizz = "Fizz";
        const string buzz = "Buzz";
        const string lucky = "Lucky";
        
        [Fact]
        public void FizzBuzzConverter_ReturnsFizz_MultipleOfThreeNotContainingAThree()
        {
            var multipleOfThree = 9;
            var result = fizzBuzzConverter.Convert(multipleOfThree);
            
            Assert.Equal(fizz, result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsInputNumber_NotMultipleOfThreeOrFiveAndNotContainingAThree()
        {
            var numberWhichIsntMultiple = 2;
            var result = fizzBuzzConverter.Convert(numberWhichIsntMultiple);

            Assert.Equal(numberWhichIsntMultiple.ToString(), result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsBuzz_MultipleOfFiveNotContainingAThree()
        {
            var multipleOfFive = 5;
            var fizzBuzzConverter = new FizzBuzzConverter();

            var result = fizzBuzzConverter.Convert(multipleOfFive);

            Assert.Equal(buzz, result);
        }

        [Fact]
        public void FizzBuzzConverter_ReturnsFizzBuzz_MultipleOfThreeAndFive()
        {
            var multipleOfThreeAndFive = 15;
            var fizzBuzzConverter = new FizzBuzzConverter();

            var result = fizzBuzzConverter.Convert(multipleOfThreeAndFive);

            Assert.Equal(fizz + buzz, result);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(3)]
        [InlineData(30)]
        public void FizzBuzzConverter_ReturnsLucky_ContainsAThree(int testCase)
        {
            var fizzBuzzConverter = new FizzBuzzConverter();

            var result = fizzBuzzConverter.Convert(testCase);

            Assert.Equal(lucky, result);
        }
    }
}
