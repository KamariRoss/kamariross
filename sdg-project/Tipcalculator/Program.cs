﻿using System;
namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      //Welcome the User
      Console.WriteLine("Welcome User!!!!");
      //Ask how much the bill
      Console.WriteLine("How much was your meal?");
      var total = Console.ReadLine();
      // how was the service
      Console.WriteLine("How was your service?");
      var service = Console.ReadLine();
      // Okay, good, great, default

      //calculate tip based on the level of service
      var tipPercentage = 0.15;
      if (service == "okay")
      {
        tipPercentage = 0.18;
      }
      else if (service == "good")
      {
        tipPercentage = 0.20;
      }
      else if (service == "great")
      {
        tipPercentage = 0.25
      }


      var tip = double.Parse(total) * tipPercentage;
      // add the tip to the total
      var grandTotal = tip + double.Parse(total);
      // add the tip to the total
      // display the result
      // tipPercent + 100 will give the correct value
      var tipToDisplay = tipPercentage * 100;
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("The" + tipToDisplay + "% tip is" + tip);
      Console.WriteLine("Grand total is " + grandTotal);
    }
  }
}