int[] getArr(int NArr)
{

    int[] A = new int[NArr];

    for(int i = 0; i < A.Length; i++ )
    {
           A[i] = new Random().Next(0, 100);
    }

    return A;
}

foreach (int item in getArr(8) )
{
    Console.Write(item + "  ");
}