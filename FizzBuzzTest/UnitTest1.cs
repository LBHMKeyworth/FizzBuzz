using Xunit;
using FirstTestApp;
using Moq;

namespace Tests
{
    public class FactTests
    {

        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3_Mock()
        {
            var mock = new Mock<IFB>();
            mock.Setup(x => x.FizzBuzz(3)).Returns("Fizz");
            FB fb = new FB(mock.Object);
        }


        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            FB fizzBuzz = new FB();
            Assert.Equal("fizz", fizzBuzz.FizzBuzz(3));
            Assert.Equal("fizz", fizzBuzz.FizzBuzz(6));
            Assert.Equal("fizz", fizzBuzz.FizzBuzz(9));
        }
        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            FB fizzBuzz = new FB();
            Assert.Equal("buzz", fizzBuzz.FizzBuzz(5));
            Assert.Equal("buzz", fizzBuzz.FizzBuzz(10));
            Assert.Equal("buzz", fizzBuzz.FizzBuzz(20));
        }

        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            FB fizzBuzz = new FB();
            Assert.Equal("fizzbuzz", fizzBuzz.FizzBuzz(15));
            Assert.Equal("fizzbuzz", fizzBuzz.FizzBuzz(30));
            Assert.Equal("fizzbuzz", fizzBuzz.FizzBuzz(45));
        }

        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            FB fizzBuzz = new FB();
            Assert.Equal("1", fizzBuzz.FizzBuzz(1));
            Assert.Equal("7", fizzBuzz.FizzBuzz(7));
            Assert.Equal("11", fizzBuzz.FizzBuzz(11));
        }
    }

    public class TheoryTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3_Theory(int valueIn)
        {
            FB fizzBuzz = new FB();
            Assert.Equal("fizz", fizzBuzz.FizzBuzz(valueIn));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5_Theory(int valueIn)
        {
            FB fizzBuzz = new FB();
            Assert.Equal("buzz", fizzBuzz.FizzBuzz(valueIn));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5_Theory(int valueIn)
        {
            FB fizzBuzz = new FB();
            Assert.Equal("fizzbuzz", fizzBuzz.FizzBuzz(valueIn));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(11)]
        public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5_Theory(int valueIn)
        {
            FB fizzBuzz = new FB();
            Assert.Equal(valueIn.ToString(), fizzBuzz.FizzBuzz(valueIn));
        }

    }
}
