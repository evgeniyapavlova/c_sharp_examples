int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; 
}

int a = 123, b=3378, c=5, d=9144 , e=3, f=47, g=6, h=22, i=8;

int max1 = Max(a, b, c);
int max2 = Max(d, e, f);
int max3 = Max(g, h, i);
int max = Max(max1, max2, max3);

Console.WriteLine(max);