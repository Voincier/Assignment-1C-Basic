using System;

public class Assignment_3{
    public static void Main(string[] args){
        int input, factorial=1;
        Console.Write("Enter any Number: ");
        input = int.Parse(Console.ReadLine());

        for(int i=1; i<=input; i++){
            factorial = factorial * i;
        }

        Console.Write($"Factorial of {input} is: {factorial}");
    }
}