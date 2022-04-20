class Methods
{
    //1. NO return value, no parameter
    void PrintHello()
    {
        Console.WriteLine("Hello everyone!");
    }
     
     //2.no return value but single parameter
    void PrintHello(string name)
    {
        Console.WriteLine("Hello,  {name}");

    }
    //3. return value amd two parameters

    string FormatName(string firstNmae, string lastName)
    {
        return $"{lastName}, {firstName}";

    }

    //4. Expressio syntax
    string FormatName2(string firstName, string lastName) => $"{lastName}, {firstName}";

    bool IsEven(short number) => number % 2 ==0;

    //5. Varialble number of arguments
    public double Sum(params double[] numbers) => numbers.Sum();

   //6. Optional arguments
   public string Greet(string firstName, string lastName, string salutation = "Mr.") => 
      $"Hello, {salutation} {firstName} {lastName}";

   //7.Returning multiple values
   public (double, double) CalcSumAndAverage()
   {
       double ay = 45.8;
       double sum = 34555.6;
       return (ay, sum);
   }

}