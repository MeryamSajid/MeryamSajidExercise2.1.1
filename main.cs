using System;

class Program {
private static double CENT_IN_INCH = 2.54;
  
  public static void Main (string[] args) {
    double numInches; 

    Console.Write("Type the inches you want to convert: ");
    numInches = Double.Parse(Console.ReadLine());

    Console.WriteLine(numInches + " inches");
    Console.WriteLine(numInches * CENT_IN_INCH + " centimeters");

    
    
    
  
  

    
  }
}