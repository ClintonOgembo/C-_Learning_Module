class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Ready to learn C #");

        // data diff types
        byte number = 2;
        int count = 10;
        float totalPrice = 20.45f;  // you must include the f at the end to switch the real number from double which is set by default
        char character = 'A';
        string firstName = "Clinton";
        bool isworking = false;

        // alternatively you can replace the datatype name with keyword "var" and let c# decide the datatype

        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isworking);

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        // implicit type conversion
        byte b = 1;
        int x = b;

        // explicit conversion
        float f = 1.0f;
        int i = (int)f;   // casting = forcing the compiler to change datatype even if there will be loss of data

        // non-compatible types conversion
        string s = "1";
        int m = Convert.ToInt32(s);
        // OR
        int j = int.Parse(s);

        // try and catch block, helps our code not to crash incase of an exception instead it runs and throws an exception message, 
        try
        {
            var num = "1234";
            byte c = Convert.ToByte(num);
            System.Console.WriteLine(c);
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("The number could not be converted to a byte");
        }

    }
}

