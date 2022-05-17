//Language Integrated Query (LINQ)

public class Query
{
    byte[] ages = {23,45,67,12,20,};


    List<Person> people = new()
    {
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
        new Person { nameof = "Ram", Address = "ktm", GenericUriParser = "m"},
    }

    //List all people older than 50 years

    public void Test()
    { 
        //List all odd numbers
        var Numbers = Numbers.Where(x => x % 2 != 0);

        //List all numbers greater than 50
        var numbersGreaterThan50 = Numbers.Where(x => x > 50 && x % 2 == 0);
        numbersGreaterThan50 = from num in Numbers
                                where num> 50 && num % 2 == 0
                                select num;
        
        //Get squares of all elements
        var squares = Numbers.Select(y => y * y);

        //Check if collection has number greater than 100

        var x = numbers.Any(x => x > 100);
        var y = numbers.All(x => x 100);

        //Skip and table
        var z = numbers.Skip(5).Take(4);

        //Ordering
        var orderedNumbers = numbers.OrderBy(x => x).Select(x => x);

         var orderedNumbers1 = from number in numbers
                            orderby x
                            select x;                     


    //List all persons who Lives in Kathmandu
    var ktmNiwasi = people.Where(x => x.Address == "ktm");

    //list all males whose names which start with letter
    var hnames = people.

    }

    
}