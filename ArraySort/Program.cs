int[] array = { 3, 4, 6, 7, 8, 23, 45, 56, 76 };

void ArraySort(int[] array)
{

    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPisition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]>array[maxPisition])
            {
                maxPisition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPisition];
        array[maxPisition] = temporary;

    }
}
    void ArrayPrint(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(array[i]);
            Console.Write(" ");
        }
    }
    ArraySort(array);
    ArrayPrint(array);