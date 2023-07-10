using Xunit;

namespace Prime.Tests
{
    public class SieveOfEratosthenesTests
    {
        [Fact]
        public void Process_ReturnsCorrectPrimeNumbers_WhenToNumberIs100()
        {
            var sieveOfEratosthenes = new SieveOfEratosthenes();
            sieveOfEratosthenes.SetToNumber(100);
            sieveOfEratosthenes.Process();

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97 }, sieveOfEratosthenes.GetPrimeNumbers());
        }
    }
}