using app01;
using System;



public class MainProgram
{
    public static void Main(string[] args)
    {
        Book book = new Book("The new book", 10,100,"Author 001");
        book.OrderCopies(10);
        book.Sellcopy();

        Magazine magazine = new Magazine("New Magazine", 20, 40, 10, 1);
        //Console.WriteLine(magazine.ToString());
        magazine.AdjustQty(10);
        magazine.AdjustQty(-5);
        magazine.Sellcopy();
        magazine.RecNewIssue();

    }
}