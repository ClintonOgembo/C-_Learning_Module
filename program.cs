﻿// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;
// using System.Runtime.InteropServices;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello, World!");
//         // Console.WriteLine("Ready to learn C #");

//         // // data diff types
//         // byte number = 2;
//         // int count = 10;
//         // float totalPrice = 20.45f;  // you must include the f at the end to switch the real number from double which is set by default
//         // char character = 'A';
//         // string firstName = "Clinton";
//         // bool isworking = false;

//         // // alternatively you can replace the datatype name with keyword "var" and let c# decide the datatype

//         // Console.WriteLine(number);
//         // Console.WriteLine(count);
//         // Console.WriteLine(totalPrice);
//         // Console.WriteLine(character);
//         // Console.WriteLine(firstName);
//         // Console.WriteLine(isworking);

//         // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
//         // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

//         // // implicit type conversion
//         // byte b = 1;
//         // int x = b;

//         // // explicit conversion
//         // float f = 1.0f;
//         // int i = (int)f;   // casting = forcing the compiler to change datatype even if there will be loss of data

//         // // non-compatible types conversion
//         // string s = "1";
//         // int m = Convert.ToInt32(s);
//         // // OR
//         // int j = int.Parse(s);

//         // try and catch block, helps our code not to crash incase of an exception instead it runs and throws an exception message, 
//         // try
//         // {
//         //     var num = "234.0";
//         //     int c = Convert.ToInt32(num);
//         //     System.Console.WriteLine(c);
//         // }
//         // catch (Exception e)
//         // {
//         //     System.Console.WriteLine(e.Message);
//         // }

//         // // taking inputs
//         // Console.Write("Enter your name: ");
//         // string name = Console.ReadLine()!;
//         // Console.Write("Enter your age: ");
//         // string age = Console.ReadLine()!;
//         // Console.WriteLine("Hello " + name + " you are " + age + " old.");

//         // simle calculator
//         // Console.Write("Enter first number: ");
//         // var val1 = Convert.ToDouble(Console.ReadLine());

//         // System.Console.Write("Enter the operator: ");
//         // string oper = Console.ReadLine()!;

//         // Console.Write("Enter second number: ");
//         // var val2 = Convert.ToDouble(Console.ReadLine());

//         // if (oper == "+")
//         // {
//         //     System.Console.WriteLine(val1 + val2);
//         // }
//         // else if (oper == "*")
//         // {
//         //     System.Console.WriteLine(val1 * val2);
//         // }
//         // else if (oper == "/")
//         // {
//         //     System.Console.WriteLine(val1 / val2);
//         // }
//         // else if (oper == "-")
//         // {
//         //     System.Console.WriteLine(val1 - val2);
//         // }
//         // else
//         // {
//         //     System.Console.WriteLine("Invalid operator...!");
//         // }

//         // // simple madlib
//         // string color, pluralNoun, celebrity;

//         // Console.Write("Enter a color: ");
//         // color = Console.ReadLine()!;

//         // Console.Write("Enter a plural noun: ");
//         // pluralNoun = Console.ReadLine()!;

//         // Console.Write("Enter name of a celeb: ");
//         // celebrity = Console.ReadLine()!;

//         // System.Console.WriteLine();     // blank line

//         // System.Console.WriteLine("Roses are " + color);
//         // System.Console.WriteLine(pluralNoun + " are blue");
//         // System.Console.WriteLine("i love " + celebrity);

//         // System.Console.WriteLine();     // blank line

//         // // Arrays
//         // int[] luckyNumbers = { 4, 5, 6, 7 };
//         // System.Console.WriteLine(luckyNumbers[2]);
//         // luckyNumbers[0] = 400; // output : {400, 5, 6, 7}

//         // string[] friends = new string[5];  // holds 5 elements
//         // friends[0] = "john";
//         // friends[1] = "james";

//         // 2 dimensions array
//         // string[,] animals = {
//         //     {"weaver", "eagle"},
//         //     {"crocodile", "snake"},
//         //     {"tilapia","madfish"}
//         // };
//         // System.Console.WriteLine(animals[1, 1]);


//         // //if statement
//         // bool isMale = false;
//         // bool isTall = true;

//         // if (isMale && isTall)
//         // {
//         //     System.Console.WriteLine("You are a male and Tall");
//         // }
//         // else if (isMale && !isTall)
//         // {
//         //     System.Console.WriteLine("You ara a short male");
//         // }
//         // else if (!isMale && isTall)
//         // {
//         //     System.Console.WriteLine("You ara a tall and not male");
//         // }
//         // else
//         // {
//         //     System.Console.WriteLine("You are not a male or tall or both");
//         // }

//         // while loops
//         // int index = 1;
//         // while (index <= 5)
//         // {
//         //     System.Console.WriteLine(index);
//         //     index++;
//         // }
//         // System.Console.WriteLine();

//         // // do...while loop
//         // int num1 = 5;
//         // do
//         // {
//         //     System.Console.WriteLine(num1);
//         //     num1++;
//         // } while (num1 <= 4);

//         // // GUESSING GAME:
//         // string secrectWord = "cow";
//         // string guess = "";
//         // int attempts = 0;
//         // int maxAttempts = 3;
//         // while (guess != secrectWord)
//         // {
//         //     System.Console.WriteLine("Enter guess: ");
//         //     guess = Console.ReadLine()!;
//         // }
//         // System.Console.WriteLine("You Win");

//         // do ... while loop
//         // do
//         // {
//         //     Console.WriteLine("Enter guess: ");
//         //     guess = Console.ReadLine()!;
//         // } while (guess != secrectWord);

//         // do
//         // {
//         //     System.Console.Write("Enter a guess: ");
//         //     guess = Console.ReadLine()!;
//         //     attempts++;

//         //     if (guess == secrectWord)
//         //     {
//         //         System.Console.WriteLine("You Win");
//         //         break;
//         //     }
//         //     else if (attempts < maxAttempts)
//         //     {
//         //         System.Console.WriteLine("Wrong Guess! try again");
//         //     }

//         // } while (attempts < maxAttempts);

//         // if (guess != secrectWord)
//         // {
//         //     System.Console.WriteLine("finished attempts. correct word was: " + secrectWord);
//         // }

//         // for..loop
//         // for (int i = 1; i <= 5; i++)
//         // {
//         //     System.Console.WriteLine(i);
//         // }

//         // // using for loop to go thru array elements
//         // int[] numbers = { 4, 6, 8, 10, 12 };
//         // for (int i = 0; i < numbers.Length; i++)
//         // {
//         //     Console.WriteLine(numbers[i]);
//         // }

//         // // calling methods
//         // System.Console.WriteLine();

//         // SayHi("Clinton", 34);

//         // System.Console.WriteLine();

//         // Console.WriteLine(Cube(5));
//         // int cubedNumber = Cube(2);
//         // System.Console.WriteLine(cubedNumber);

//         // System.Console.WriteLine();

//         // System.Console.WriteLine(GetMax(31, 60, 41));

//         // System.Console.WriteLine();

//         // System.Console.WriteLine(GetDay(2));

//         // GetPow(3, 3);

//         // objects of class Book
//         Book book1 = new Book("Laws", "Clinton", 440);
//         Book book2 = new Book("mat", "Sam", 54);

//         System.Console.WriteLine(book1.author);
//         book2.author = "jacob";
//         System.Console.WriteLine(book2.author);

//         System.Console.WriteLine(book1.HasHonors());
//         System.Console.WriteLine(book2.HasHonors());

//         Movies movie1 = new Movies("Avengers", "Trevor", "PG-13");
//         Movies movie2 = new Movies("Dexter", "phil", "P");
//         // ratings can only be (G, PG, PG-13, R, NR)

//         System.Console.WriteLine(movie1.Rating);
//         System.Console.WriteLine(movie2.Rating);

//         Chef chef1 = new Chef();
//         chef1.MakeChicken();
//         chef1.MakeSpecial();

//         ItalianChef chef2 = new ItalianChef();
//         chef2.MakeChicken();
//         chef2.MakePaster();
//         chef2.MakeSpecial();

//     }

//     // Other method
//     static void SayHi(string name, int age)
//     {
//         System.Console.WriteLine("Hello " + name + " you are " + age + " old");
//     }

//     static int Cube(int num)
//     {
//         int result = num * num * num;
//         return result;
//     }

//     static int GetMax(int x, int y, int z)
//     {
//         int result;
//         if (x >= y && x >= z)
//         {
//             result = x;
//         }
//         if (y >= x && y >= z)
//         {
//             result = y;
//         }
//         else
//         {
//             result = z;
//         }

//         return result;
//     }

//     // switch statement in a method
//     static string GetDay(int numDay)
//     {
//         string dayName;

//         switch (numDay)
//         {
//             case 0:
//                 dayName = "Sunday";
//                 break;
//             case 1:
//                 dayName = "Mon";
//                 break;
//             case 2:
//                 dayName = "Tue";
//                 break;
//             case 3:
//                 dayName = "Wen";
//                 break;
//             default:
//                 dayName = "Invalid number";
//                 break;
//         }
//         return dayName;

//     }

//     // Exponent Method
//     static void GetPow(int baseNum, int powNum)
//     {
//         System.Console.WriteLine(Math.Pow(baseNum, powNum));
//     }


// }

