// See https://aka.ms/new-console-template for more information
class Assignment6
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the value for n:");
        int n = int.Parse(Console.ReadLine());
        if(n%2== 0)
        {
            Console.WriteLine($"{n} is a even number");
        }
        else
        {
            Console.WriteLine($"{n} is a odd number");
        }
    }
}
