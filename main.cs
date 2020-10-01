using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter your WEIGHT in pounds:");
    double weight = Double.Parse(Console.ReadLine());
    Console.WriteLine ("Please enter your HEIGHT in inches:");
    double height = Double.Parse(Console.ReadLine());

    double results = CalculateBMI(weight, height);

    BMIResults(results);
  }

  public static void BMIResults (double BMI) {
    Console.WriteLine ("Your BMI:" + BMI);
    if (BMI < 18.5) {
      Console.WriteLine ("Weight Status: Underweight");
    }
    if (BMI > 18.5 && BMI < 24.9) {
      Console.WriteLine ("Weight Status: Normal");
    }
    if (BMI > 25.0 && BMI < 29.9) {
      Console.WriteLine ("Weight Status: Overweight");
    }
    if (BMI > 30.0) {
      Console.WriteLine ("Weight Status: Obese");
    }
  }

  public static double CalculateBMI (double weight, double height) {
    return (weight * 703)/(height * height);
  }

}