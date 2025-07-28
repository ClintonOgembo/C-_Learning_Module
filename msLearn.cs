class Program
{
    static void Main(string[] args)
    {
        // Escape sequence
        System.Console.WriteLine("Hi Clinton\n");
        System.Console.WriteLine("Unit\tGrade");
        System.Console.WriteLine("directory: user\\files\\demo");
        System.Console.WriteLine("Have you read \"48 laws of power\" book?");

        // verbatim string literal
        System.Console.Write(@"     c:\source\repos");

        // string interpolation
        string name = "Clinton";
        string city = "Nairobi";
        System.Console.WriteLine($"Hello {name}, do you live in {city}?");

        // combination of verbatim and interpolation
        string projectName = "Attain-Task-Support";
        System.Console.WriteLine($@"C:User\Output\{projectName}\date");

        // CHALLENGE: Desired output
        /* View English output:
            c:\Exercise\ACME\data.txt

        Посмотреть русский вывод:
            c:\Exercise\ACME\ru-RU\data.txt*/

        // SOLUTION
        string projoName = "ACME";

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.Write($"View English output:\n\tc:\\Exercise\\{projoName}\\data.txt\n\n");
        Console.Write($@"{russianMessage}:
            c:Exercise\{projoName}\ru-RU\data.tx");
    }
}