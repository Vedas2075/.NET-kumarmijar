
//Write a C# program to check if entered number is even or not (use ternary operator)?

using System;

  public class check_num
  {
      public void check_Evennum()
      {
          Console.WriteLine("Enter a number:");
          int test=1;
          while(test>0)
          {
              bool input =Int32.TryParse(Console.ReadLine(), out int numb);

              if(input==true && numb>=0)
              {
                  var num1=(numb%2==0)?"Even number": "Odd number";
                  Console.WriteLine(num1);
                  test=-1;
              }
              else{
                  Console.WriteLine("Please valid number.");
              }
          }
      }
  }