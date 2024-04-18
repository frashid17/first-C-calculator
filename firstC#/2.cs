using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("ENTER FIRST NUMBER: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ENTER SECOND NUMBER: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ENTER THE OPERATOR: ");
        char op = Console.ReadLine()[0];

        int res = 0;

        if (op == '+')
        {
            res = n1 + n2;
        }
        else if (op == '-')
        {
            res = n1 - n2;
        }
        else if (op == '*')
        {
            res = n1 * n2;
        }
        else
        {
            res = 0;
        }
        Console.WriteLine("RESULT: " + res);
    }
}