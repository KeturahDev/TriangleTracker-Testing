using System;
using System.Collections.Generic;

namespace Triangle
{

  public class Tracker
  {
    //old method
    //new daddy method
    public static string DetectTriangle(bool triangle)
    {
      if (triangle == false) 
      {
        return "not a triangle";
      }
      else 
      {
        return "is triangle";
      }
    }
    //baby methods
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
      return false;
    }

    public static void Main ()
    {
      Console.WriteLine("Please enter 3 sides, and we'll tell you if its a triangele, and what kind");
      string side1Str = Console.ReadLine();
      string side2Str = Console.ReadLine();
      string side3Str = Console.ReadLine();

      int side1 = int.Parse(side1Str);
      int side2 = int.Parse(side2Str);
      int side3 = int.Parse(side3Str);

      // string result = TypeOfTriangle(side1, side2, side3);
      bool triangle = isTriangle(side1, side2, side3);
      string result = DetectTriangle(triangle);
      Console.WriteLine(result);
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