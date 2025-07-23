using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("Ready to learn C #");

        // // data diff types
        // byte number = 2;
        // int count = 10;
        // float totalPrice = 20.45f;  // you must include the f at the end to switch the real number from double which is set by default
        // char character = 'A';
        // string firstName = "Clinton";
        // bool isworking = false;

        // // alternatively you can replace the datatype name with keyword "var" and let c# decide the datatype

        // Console.WriteLine(number);
        // Console.WriteLine(count);
        // Console.WriteLine(totalPrice);
        // Console.WriteLine(character);
        // Console.WriteLine(firstName);
        // Console.WriteLine(isworking);

        // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        // // implicit type conversion
        // byte b = 1;
        // int x = b;

        // // explicit conversion
        // float f = 1.0f;
        // int i = (int)f;   // casting = forcing the compiler to change datatype even if there will be loss of data

        // // non-compatible types conversion
        // string s = "1";
        // int m = Convert.ToInt32(s);
        // // OR
        // int j = int.Parse(s);

        // // try and catch block, helps our code not to crash incase of an exception instead it runs and throws an exception message, 
        // try
        // {
        //     var num = "1234";
        //     byte c = Convert.ToByte(num);
        //     System.Console.WriteLine(c);
        // }
        // catch (System.Exception)
        // {
        //     System.Console.WriteLine("The number could not be converted to a byte");
        // }

        // // taking inputs
        // Console.Write("Enter your name: ");
        // string name = Console.ReadLine()!;
        // Console.Write("Enter your age: ");
        // string age = Console.ReadLine()!;
        // Console.WriteLine("Hello " + name + " you are " + age + " old.");

        // // simle calculator
        // Console.Write("Enter first number: ");
        // var val1 = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Enter second number: ");
        // var val2 = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine(val1 + val2);
        // System.Console.WriteLine(val1 * val2);
        // System.Console.WriteLine(val1 / val2);
        // System.Console.WriteLine(val1 - val2);

        // // simple madlib
        // string color, pluralNoun, celebrity;

        // Console.Write("Enter a color: ");
        // color = Console.ReadLine()!;

        // Console.Write("Enter a plural noun: ");
        // pluralNoun = Console.ReadLine()!;

        // Console.Write("Enter name of a celeb: ");
        // celebrity = Console.ReadLine()!;

        // System.Console.WriteLine();     // blank line

        // System.Console.WriteLine("Roses are " + color);
        // System.Console.WriteLine(pluralNoun + " are blue");
        // System.Console.WriteLine("i love " + celebrity);

        // System.Console.WriteLine();     // blank line

        // // Arrays
        // int[] luckyNumbers = { 4, 5, 6, 7 };
        // System.Console.WriteLine(luckyNumbers[2]);
        // luckyNumbers[0] = 400; // output : {400, 5, 6, 7}

        // string[] friends = new string[5];  // holds 5 elements
        // friends[0] = "john";
        // friends[1] = "james";

        //if statement
        bool isMale = false;
        bool isTall = true;

        if (isMale && isTall)
        {
            System.Console.WriteLine("You are a male and Tall");
        }
        else if (isMale && !isTall)
        {
            System.Console.WriteLine("You ara a short male");
        }
        else if (!isMale && isTall)
        {
            System.Console.WriteLine("You ara a tall and not male");
        }
        else
        {
            System.Console.WriteLine("You are not a male or tall or both");
        }

        // calling methods
        System.Console.WriteLine();

        SayHi("Clinton", 34);

        System.Console.WriteLine();

        Console.WriteLine(Cube(5));
        int cubedNumber = Cube(2);
        System.Console.WriteLine(cubedNumber);

        System.Console.WriteLine();

        System.Console.WriteLine(GetMax(31, 60, 41));


    }

    // Other method
    static void SayHi(string name, int age)
    {
        System.Console.WriteLine("Hello " + name + " you are " + age + " old");
    }

    static int Cube(int num)
    {
        int result = num * num * num;
        return result;
    }

    static int GetMax(int x, int y, int z)
    {
        int result;
        if (x >= y && x >= z)
        {
            result = x;
        }
        if (y >= x && y >= z)
        {
            result = y;
        }
        else
        {
            result = z;
        }

        return result;
    }
}

