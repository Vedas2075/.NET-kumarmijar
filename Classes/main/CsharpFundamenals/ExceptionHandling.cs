
using System;
public class ExceptionHandling
{
    public double Compute(double x, double y, double z)
    {
        // double value = (x+y)/x;
        // double c = value * x / (y + z);
        // return c;

        if(x == 0 || y == 0 )
          throw new Exception("Parameter value 0 supplied on x or y");

        double c = 0;
        try
        {
            double value = (x +y) / z;
            c = value * x / (y + z);
        }

        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(c == 0)
               c = 20;
        }

        return c;

    }

    public void Test()
    {
        var v = Compute(23,45,0);
    }
}