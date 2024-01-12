using System;

public class Assignment_2
{

    public static void Main(string[] args)
    {
        int input;
        Console.Write("Enter the Range = ");
        input = int.Parse(Console.ReadLine());

        char ch = '1';
        int i, j, k, m;
        for (i = 1; i <= input; i++)
        {
            for (j = 5; j >= i; j--)
                Console.Write(" ");
            for (k = 1; k <= i; k++)
                Console.Write(ch++);
            ch--;
            for (m = 1; m < i; m++)
                Console.Write(--ch);
            Console.Write("\n");
            ch = '1';
        }
    }
}