Console.Clear();
int i = 0;
int count;
int t = 0;
Console.WriteLine("Сколько будет чисел в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int q = 0;
while (q <= n - 1)
{
    Console.WriteLine("введите число массива");
    array[q] = Convert.ToInt32(Console.ReadLine());
    q++;
}
Console.Clear();
Console.WriteLine(string.Join(",", array));
Console.WriteLine("введите число для смещения цикла");
int z = Convert.ToInt32(Console.ReadLine());
if (z > 0)
{
while (t < z)
{
    count = array[0];
        while (i < array.Length - 1)
        {
            array[i] = array[i + 1];
            i++;
        }
    array[array.Length - 1] = count;
    i = 0;
    t++;
}
Console.WriteLine(string.Join(",", array));
}
else if (z==0)
    Console.WriteLine(string.Join(",", array));

else if (z < 0)
{
    while (t > z)
    {
        count = array[array.Length - 1];
            while (i < array.Length - 1)
            {
                array[array.Length -i - 1] = array[array.Length - i - 2];
                i++;
            }
        array[0] = count;
        i = 0;
        t--;
    }
Console.WriteLine(string.Join(",", array));
}