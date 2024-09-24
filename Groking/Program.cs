namespace Groking;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new DateTime(2024, 1, 1).ToString("dd.MM.yyyy"));
    }

    static List<int> SelectionSort(List<int> arrayToSort)
    {
        int length = arrayToSort.Count;
        List<int> newArray = [];
        for (int i = 0; i < length; i++)
        {
            int smallest = GetSmallest(arrayToSort);
            newArray.Add(arrayToSort[smallest]);
            arrayToSort.RemoveAt(smallest);
        }

        return newArray;

        int GetSmallest(List<int> array)
        {
            int smallest = array[0];
            int smallestIndex = 0;
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
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
