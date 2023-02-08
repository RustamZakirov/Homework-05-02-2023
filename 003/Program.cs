Console.Clear();
Console.WriteLine("Введите количество учеников");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int[] array = new int[a];
while (b <= a-1)
{
    Console.WriteLine("Введите рост ученика");
    array[b] = Convert.ToInt32(Console.ReadLine());
    b++;
}
b = 0;
Console.WriteLine($"Результат = {string.Join(", ", array)}");
Console.WriteLine("Введите рост нового ученика");
int c = Convert.ToInt32(Console.ReadLine());
if (array[a-1] > c)
    Console.WriteLine($"Новый ученик встанет на место: {a + 1}");
else
{
while (array[b] > c)
    {
        int count = b;
        b++;
    }
    Console.WriteLine($"Новый ученик встанет на место: {b+1}");
}
