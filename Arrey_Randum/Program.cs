void FillArrey(int[] Collection) 
{
    int Length = Collection.Length;
    int index = 0;
    while (index < Length) 
    {
        Collection[index] = new Random().Next(1, 10);

        index++;

    }
}

void PrintArrey( int[] col) 
{
    int count = col.Length;
    int position = 0;
    while(position <count)
    {
        Console.Write(col[position]);
        position++;
    }
}
 
 int[] arrey = new int[10];
 FillArrey(arrey);
 PrintArrey(arrey);
