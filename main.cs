using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter Wind Speed in MPH: ");
    double windSpeed = Convert.ToDouble(Console.ReadLine());
    if (windSpeed >= 157) {
      Console.WriteLine("Category 5 Hurricane");
    }
    else if (windSpeed >= 130) {
      Console.WriteLine("Catagory 4 Hurricane");
    }
    else if (windSpeed >= 111) {
      Console.WriteLine("Catagory 3 Hurricane");
    }
    else if (windSpeed >= 96) {
      Console.WriteLine("Catagory 2 Hurricane");
    }
    else if (windSpeed >= 74) {
      Console.WriteLine("Catagory 1 Hurricane");
    }
    else {
      Console.WriteLine("Not Hurricane");
    }
  }
}