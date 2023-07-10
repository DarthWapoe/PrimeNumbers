using Prime;

// Init both prime number generators
var primal = new Primal();
primal.SetToNumber(1000);
primal.Process();

var sieveOfEratosthenes = new SieveOfEratosthenes();
sieveOfEratosthenes.SetToNumber(1000);
sieveOfEratosthenes.Process();

// Output both prime number generators
Console.WriteLine("Primal:");
Console.WriteLine("Prime Numbers: " + string.Join(", ", primal.GetPrimeNumbers()));
Console.WriteLine("Sum: " + primal.GetSum());
Console.WriteLine("Average: " + primal.GetAverage());

Console.WriteLine();

Console.WriteLine("SieveOfEratosthenes:");
Console.WriteLine("Prime Numbers: " + string.Join(", ", sieveOfEratosthenes.GetPrimeNumbers()));
Console.WriteLine("Sum: " + sieveOfEratosthenes.GetSum());
Console.WriteLine("Average: " + sieveOfEratosthenes.GetAverage());

Console.WriteLine();

// Benchmark both prime number generators
primal.SetToNumber(10000);
Console.WriteLine("Benchmark Primal:");
benchmark(primal, 100);

Console.WriteLine();

sieveOfEratosthenes.SetToNumber(10000);
Console.WriteLine("Benchmark SieveOfEratosthenes:");
benchmark(sieveOfEratosthenes, 100);

static void benchmark(PrimeNumbers primeGenerator, int iterations)
{
    System.Diagnostics.Stopwatch stopwatch = new();
    stopwatch.Start();

    for (int i = 0; i < iterations; i++)
    {
        primeGenerator.Process();
    }

    stopwatch.Stop();
    Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds + "ms");
}