namespace Prime
{
    public class SieveOfEratosthenes : Primal
    {
        public override void Process()
        {
            // Implemented Sieve of Eratosthenes algorithm based on pseudocode:
            // https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes#Pseudocode

            primeNumbers.Clear();
            bool[] isPrimeList = Enumerable.Repeat(true, ToNumber + 1).ToArray();

            for (int i = 2; i <= (int)Math.Sqrt(ToNumber); i++)
            {
                if (isPrimeList[i])
                {
                    for (int j = i * i; j <= ToNumber; j += i)
                    {
                        isPrimeList[j] = false;
                    }
                }
            }

            for (int i = 2; i <= ToNumber; i++)
            {
                if (isPrimeList[i])
                {
                    primeNumbers.Add(i);
                }
            }
        }
    }
}