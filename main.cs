using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter color");
   string color =  Console.ReadLine();
    if (color=="yellow" || color=="orange" || color=="red" || color=="gold" || color=="pink")
     {
       Console.WriteLine("The color is warm");
      }
    if (color=="blue" || color=="purple" || color=="magenta" ||color=="green")
     {
       Console.WriteLine("The color is cool");
      }
    if (color=="black" || color=="white" || color=="ivory" || color=="brown" || color=="beige")
     {
       Console.WriteLine("The color is natural ");
     }
     else
     {
       Console.WriteLine("Unable to determine the color temperature for the color " + color);
     }
  }
}
