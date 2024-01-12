using System;
public class Assignment_4{
    public static void Main(string[] args){
        int input, reversed=0;
        Console.Write("Enter a Number: ");
        input = int.Parse(Console.ReadLine());

        while(input > 0){
            int digit = input % 10;
            reversed = reversed * 10 + digit;
            input = input / 10;
        }

        Console.Write("Reversed Number: " + reversed);
    }
}