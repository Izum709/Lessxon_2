int[] arrey ={41, 24, 35, 4, 75, 60, 7, 88, 94, 140};
int n = arrey.Length;
int find = 140;
int index = 0;
while (index < n)
{
    if (arrey[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}