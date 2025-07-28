class Program
{
    static void Main(string[] args)
    {
        // // Escape sequence
        // System.Console.WriteLine("Hi Clinton\n");
        // System.Console.WriteLine("Unit\tGrade");
        // System.Console.WriteLine("directory: user\\files\\demo");
        // System.Console.WriteLine("Have you read \"48 laws of power\" book?");

        // // verbatim string literal
        // System.Console.Write(@"     c:\source\repos");

        // // string interpolation
        // string name = "Clinton";
        // string city = "Nairobi";
        // System.Console.WriteLine($"Hello {name}, do you live in {city}?");

        // // combination of verbatim and interpolation
        // string projectName = "Attain-Task-Support";
        // System.Console.WriteLine($@"C:User\Output\{projectName}\date");

        // // CHALLENGE: Desired output
        // /* View English output:
        //     c:\Exercise\ACME\data.txt

        // Посмотреть русский вывод:
        //     c:\Exercise\ACME\ru-RU\data.txt*/

        // // SOLUTION
        // string projoName = "ACME";

        // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        // Console.Write($"View English output:\n\tc:\\Exercise\\{projoName}\\data.txt\n\n");
        // Console.Write($@"{russianMessage}:
        //     c:Exercise\{projoName}\ru-RU\data.tx");

        // initialize variables - graded assignments 
        int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        float sophy = (float)(sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
        float nico = (float)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
        float zac = (float)(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
        float jeo = (float)(jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;
        System.Console.WriteLine(@"Student     Grade");
        System.Console.WriteLine($@"Sophia      {sophy}");
        System.Console.WriteLine($@"Nicholas    {nico}");
        System.Console.WriteLine($@"Zacharia    {zac}");
        System.Console.WriteLine($@"Jeong       {jeo}");


    }
}