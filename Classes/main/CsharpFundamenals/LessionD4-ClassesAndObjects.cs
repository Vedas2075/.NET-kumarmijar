using System;
namespace ABC;
//Calculator
public class Calculator
{
  public Calculator()
  {


  }
    public Calculator(double op1, double op2)
    {
      operand1 = op1;
      operand2 = op2;
    }

   public double operand1;

   public double operand2;

   public double Sum() => operand1 + operand2;

   public double Subtract() => operand1 - operand2;
   public double multiplly() => operand1 * operand2;
   public double Divide() => operand1 / operand2;
}