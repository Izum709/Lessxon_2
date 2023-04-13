int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)   result = arg2;
    if (arg3 > result)   result = arg3;
    return  result;
}//            0  1  2  3  4  5  6  7  8
int[] arrey = {10,22,43,48,53,36,47,58,98};
arrey[0] = 10;
Console.WriteLine(arrey[7]);
