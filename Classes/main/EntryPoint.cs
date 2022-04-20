public class program
{
    public static void Main()
    {
     /* 
     Calculator calculator1 = new();
      calculator1.operand1 = 34.2;
      calculator1.operand2 = 33.4;

      var s = calculator1.Sum();
      var d = calculator1.Subtract();
      var m = calculator1.Multiply();
      var di = calculator1.Divide();
      */
      Calculator calculator1 = new(34.5, 6.9);

      var s2 = calculator1.Sum();
      var d2 = calculator1.Subtract();
      var m2 = calculator1.Multiply();
      var di2 = calculator1.Divide();

    }
}