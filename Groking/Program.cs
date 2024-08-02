namespace Groking;

class Program
{
    static void Main(string[] args)
    {
        int[] array = [1, 3, 5, 7, 9];
        Console.WriteLine(BinarySearch(array, 1));
        Console.WriteLine(BinarySearch(array, 3));
        Console.WriteLine(BinarySearch(array, 5));
        Console.WriteLine(BinarySearch(array, 7));
        Console.WriteLine(BinarySearch(array, 9));
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
