namespace Prime
{
    public class Primal : PrimeNumbers
    {
        protected int ToNumber;

        public void SetToNumber(int number)
        {
            if (number < 2)
            {
                throw new Exception("Number must be greater than 1");
            }
            ToNumber = number;
        }

        public override void Process()
        {
            // Simple prime number generator

            primeNumbers.Clear();

            for (int i = 2; i <= ToNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }
        }
    }
}