namespace Prime
{
    abstract class PrimeNumbers
    {
        protected List<int> primeNumbers = new();

        public List<int> GetPrimeNumbers()
        {
            return primeNumbers;
        }

        public int GetSum()
        {
            return primeNumbers.Sum();
        }

        public float GetAverage()
        {
            return (float)GetSum() / primeNumbers.Count;
        }

        public abstract void Process();
    }
}