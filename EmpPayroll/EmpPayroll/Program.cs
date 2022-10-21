class Program
{
    static void Main(string[] args)
    {
        //Uc1
        Random r = new Random();
        int value = r.Next(0, 2);

        if (value == 0)
        {
            Console.WriteLine("emp is present");
        }
        else
        {
            Console.WriteLine("emp is absent");

        }
    }
}

