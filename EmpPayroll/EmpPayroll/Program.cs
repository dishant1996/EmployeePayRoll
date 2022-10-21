class Program
{
    static void Main(string[] args)
    {
        //Uc2
        Random random = new Random();
        var value = random.Next(1, 3);

        int EmpHour;
        if (value == 1)
        {
            EmpHour = 0;
        }
        else
        {
            EmpHour = 8;

        }
        Console.WriteLine(EmpHour);
    }
}
