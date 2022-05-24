

 public class Program
 {
     public static void Main2()
    {
      
//       // Calculator calculator1 = new();
//       // calculator1.operand1 = 34.2;
//       // calculator1.operand2 = 33.4;

//       //  var s = calculator1.Sum();
//       //  var d = calculator1.Subtract();
//       //  var m = calculator1.Multiply();
//       //  var di = calculator1.Divide();
    
//       // Calculator calculator2 = new(34.5, 6.9);

//       // var s2 = calculator1.Sum();
//       // var d2 = calculator1.Subtract();
//       // var m2 = calculator1.Multiply();
//       // var di2 = calculator1.Divide();

//       for  (long i = 10; i < 20; i++)
//       {
//         Console.WriteLine("Hi");
//       }

//       double[] weights = { 34.5, 67.8, 23.5, 34.1};
//       var t = weights[4];

//       for (byte j = 0; j < weights.Length; j++)
//       {
//         Console.WriteLine(weights[j]);
//       }

//       foreach(var x in weights)
//       {
//         Console.WriteLine(x);
//       }

//     }
// }

 FileIO fileIO = new();
        string path = @"C:\Users\I82287\OneDrive - Cotiviti\Documents\vedas.txt";
        fileIO.ReadFileFromDisk(path);   
        fileIO.CreateFileToDisk();    
    }
 }






