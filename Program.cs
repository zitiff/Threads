class Program
{
    static void Main()
    {
        Counter counter = new Counter(0); // начальное значение 0

        for (int i = 0; i < 5000; i++)
        {
            counter.Increment();
        }

        int result = counter.GetValue();
        Console.WriteLine($"Результат: {result}");

        if (result == 5000)
        {
            Console.WriteLine("Тест пройден");
        }
        else
        {
            Console.WriteLine("Тест провален");
        }
    }
}