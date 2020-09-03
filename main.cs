using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter Item Name: ");
    string item = Console.ReadLine();
    Console.Write("Enter Quantity: ");
    int quant = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Price: ");
    double price = double.Parse(Console.ReadLine());
    double answer = price * quant;
    Console.WriteLine("Total Price Of " + item + ": " + answer);
  }
}