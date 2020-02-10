using System;

namespace CoffeeTime
{
  class Program
  {
    static void Main(string[] args)
    {
      var fullName = "Kamari Ross";
      var numberOfCupsOfCoffee = 0;
      var today = "2/10/2020";

      Console.WriteLine(fullName + numberOfCupsOfCoffee + today);
      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      Console.WriteLine("Hello there" + user);

      Console.WriteLine("Please enter two numbers, enter the first");
      var operand1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Please write second number");
      var operand2 = double.Parse(Console.ReadLine());

      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var quotient = operand1 / operand2;
      var product = operand1 * operand2;
      var remainder = operand1 % operand2;

      Console.WriteLine("the subtracted " + difference);
      Console.WriteLine("The divided " + quotient);
      Console.WriteLine("The multiplied " + product);
      Console.WriteLine("The total " + sum);
      Console.WriteLine("The remainder " + remainder);








    }
  }
}
