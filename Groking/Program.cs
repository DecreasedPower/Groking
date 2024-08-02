namespace Groking;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(Factorial(-1));
        Console.WriteLine(Factorial(0));
        Console.WriteLine(Factorial(1));
        Console.WriteLine(Factorial(2));
        Console.WriteLine(Factorial(14));
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("incorrect number value", nameof(number));
        }

        if (number == 0)
        {
            return 0;
        }

        if (number == 1)
        {
            return 1;
        }

        return number * Factorial(number - 1);
    }

    static int BinarySearch(int[] array, int item)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = array[mid];

            if (guess < item)
            {
                low = mid + 1;
            }
            else if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}
