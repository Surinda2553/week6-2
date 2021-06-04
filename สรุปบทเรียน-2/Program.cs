using System;
class BMICalc
{
    static void Main()
    {
        Console.Write("Enter your weight (in kg): ");
        double w = double.Parse(Console.ReadLine());
        Console.Write("Enter your height (in m): ");
        double h = double.Parse(Console.ReadLine());
        double bmi = w / (h * h);
        Console.WriteLine("Your BMI is {0:f2}.", bmi);
        if ( bmi < 18.5 )
            Console.WriteLine("You are underweight.");
         else if ( bmi < 25 )
             Console.WriteLine("You are normal.");
         else if ( bmi < 30 )
            Console.WriteLine("You are overweight.");
         else
            Console.WriteLine("You are obese.");
    }
}