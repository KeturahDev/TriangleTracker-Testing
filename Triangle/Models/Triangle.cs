using System;
using System.Collections.Generic;

namespace Triangle
{

  public class Tracker
  {
    public static string DetectTriangle(bool triangle)
    {
      if (triangle == false) 
      {
        return "not a triangle";
      }
      else 
      {
        return "a triangle";
      }
    }
    public static bool isTriangle (int side1, int side2, int side3)
    {
      if (((side1 + side2) < side3 || (side2 + side3) < side1 || (side1 + side3) < side2))
      {
        return false;     
      }
      else
      {
        return true;
      }
    }
    public static bool isEqualateral(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool isIsosceles(int side1, int side2, int side3)
    {
      if (side1 == side2 || side2 == side3 || side3 == side1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool isScalene(int side1, int side2, int side3)
    {
      if (side1 != side2 && side2 != side3 && side3 != side1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static string TypeOfTriangle(int side1, int side2, int side3)
    {
    
      if (isEqualateral(side1,side2,side3) == true)
      {
        return "Equalateral";
      }
      else if (isIsosceles(side1,side2,side3) == true)
      {
        return "Isosceles";
      }
      else if (isScalene(side1,side2,side3) == true)
      {
        return "Scalene";
      }
      else 
      {
        return "ERROR: something went really wrong.. what the heckerino";
      }
    }
    public static void Main ()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(@"╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐                
║║║├┤ │  │  │ ││││├┤    │ │ │                
╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘                
╔╦╗┬─┐┬┌─┐┌┐┌┌─┐┬  ┌─┐  ╔╦╗┬─┐┌─┐┌─┐┬┌─┌─┐┬─┐
 ║ ├┬┘│├─┤││││ ┬│  ├┤    ║ ├┬┘├─┤│  ├┴┐├┤ ├┬┘
 ╩ ┴└─┴┴ ┴┘└┘└─┘┴─┘└─┘   ╩ ┴└─┴ ┴└─┘┴ ┴└─┘┴└─
                                                                                                                           "); Console.ResetColor();
      Console.WriteLine("Please enter 3 sides, and we'll tell you if its a triangele, and what kind");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Side 1:   ");
      Console.ForegroundColor = ConsoleColor.Green;
      string side1Str = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Side 2:   ");
      Console.ForegroundColor = ConsoleColor.Green;
      string side2Str = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write("Side 3:   ");
      Console.ForegroundColor = ConsoleColor.Green;
      string side3Str = Console.ReadLine();

      int side1 = int.Parse(side1Str);
      int side2 = int.Parse(side2Str);
      int side3 = int.Parse(side3Str);

      // string result = TypeOfTriangle(side1, side2, side3);
      bool triangle = isTriangle(side1, side2, side3);
      string triangleType = TypeOfTriangle(side1, side2, side3);
      string result = DetectTriangle(triangle);
      Console.WriteLine($"your sides = {result}");

      if(triangle == true) 
      {
        Console.WriteLine($"Your triangle is a {triangleType} type.");
      }
    }
  }
}
// ================OLD METHOD===========================================
    // public static string TypeOfTriangle()
    // {
    //   if ((side1 + side2) < side3 || (side2 + side3) < side1 || (side1 + side3) < side2)
    //   {
    //     return "not-a-triangle";
    //   }   
    //   else if ((side1 + side2) >= side3)
    //   {
    //     if (side1 ==  side2 && side2 == side3)
    //     {
    //       return "equilateral";
    //     } 
    //     else if (side1 ==  side2 ||  side2 == side3 || side3 == side1)
    //     {
    //       return "isosceles";
    //     } 
    //     else 
    //     {
    //       return "scalene";
    //     }
    //   } 
    //   else if ( side2 + side3 > side1)
    //   {
    //     if (side1 ==  side2 && side2 == side3)
    //     {
    //       return "equilateral";
    //     } 
    //     else if (side1 ==  side2 ||  side2 == side3 || side3 == side1)
    //     {
    //       return "isosceles";
    //     } 
    //     else
    //     {
    //       return "scalene";
    //     }
    //   } 
    //   else if (side3 + side1 >  side2)
    //   {
    //     if (side1 ==  side2 && side2 == side3)
    //     {
    //       return "equilateral";
    //     } 
    //     else if (side1 ==  side2 ||  side2 == side3 || side3 == side1) 
    //     {
    //       return "isosceles";
    //     } 
    //     else 
    //     {
    //       return "scalene";
    //     }
    //   }
    //   else
    //   {
    //     return "not a triangle";
    //   }
    // }