using System;
public class Assignment_5{
    public static void Main(string[] args){
        string input;
        string[] print = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        Console.Write("Enter the Number= ");
        input = Console.ReadLine();


        Console.Write("Result: ");
        foreach(char digit in input){
            if(Char.IsDigit(digit)){
                int index = (int)Char.GetNumericValue(digit);
                Console.Write(print[index] + " ");
            }
        }
    }
}