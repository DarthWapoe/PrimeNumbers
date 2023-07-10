using Xunit;

namespace Prime.Tests
{
    public class PrimalTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void SetToNumber_ThrowsException_WhenNumberIsLessThan2(int value)
        {
            var primal = new Primal();
            var ex = Assert.Throws<Exception>(() => primal.SetToNumber(value));
            Assert.Equal("Number must be greater than 1", ex.Message);
        }

        [Fact]
        public void Process_ReturnsCorrectPrimeNumbers_WhenToNumberIs100()
        {
            var primal = new Primal();
            primal.SetToNumber(100);
            primal.Process();

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97 }, primal.GetPrimeNumbers());
        }

        [Fact]
        public void Process_ReturnsCorrectSum_WhenToNumberIs100()
        {
            var primal = new Primal();
            primal.SetToNumber(100);
            primal.Process();

            Assert.Equal(1060, primal.GetSum());
        }

        [Fact]
        public void Process_ReturnsCorrectAverage_WhenToNumberIs100()
        {
            var primal = new Primal();
            primal.SetToNumber(100);
            primal.Process();

            Assert.Equal((float)1060 / 25, primal.GetAverage());
        }
    }
}