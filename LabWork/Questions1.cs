//Write a C# program to check if user says "Hi" or "Hello"?

public class greet
{
 
 public void greeting()
 {
     Console.WriteLine("Enter 'Hi or 'Hello': ");
     string user_input = Console.Readline();
     var result = (user_input=="Hi" || user_input=="Hello") ?"\nUser Greet saying '{user_input}'" : "\nPlease entered again!";
     Console.WriteLine(result);
 }
}