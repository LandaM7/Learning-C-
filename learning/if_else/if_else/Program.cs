﻿////რამდენიმე if ის დროს ელსი ეკუთვნის ბოლო if ს
//int number = 5;
//if (number > 0)
//{
//    Console.WriteLine("<0");
//}
//if (number == 0)
//{
//    Console.WriteLine("=0");
//}
//else
//{
//    Console.WriteLine("<0");
//}

// else if ის დროს ერთიერთი მაინც თუ შესრულდა დანარჩენში საერთოდ აღარ შევა
//int number = 5;
//if (number > 0)
//{
//    Console.WriteLine("<0");
//}
//else if (number == 0)
//{
//    Console.WriteLine("=0");
//}
//else
//{
//    Console.WriteLine("<0");
//}

//string matOperator = Console.ReadLine();
//switch (matOperator)
//{
//    case "+":
//        Console.WriteLine("+");
//        break;
//    case "-":
//        Console.WriteLine("-");
//        break;
//    case "*":
//        Console.WriteLine("*");
//        break;
//    case "/":
//        Console.WriteLine("/");
//        break;
//    default: // რაც იფში არის else
//        Console.WriteLine("NO");
//        break;
//}


//int number = Convert.ToInt32(Console.ReadLine());
//if (number == 0)
//{
//    Console.WriteLine($"{number} ar aris arc lutzi da arc kenti");
//}
//else if (number % 2 == 0)
//{
//    Console.WriteLine($"{number} aris lutwi");
//}
//else
//{
//    Console.WriteLine($"{number} aris kenti");
//}


//რატი
//var age = 13;
//var name = "Rati";

//if (age == 18 && name == "Rati")
//{
//    Console.WriteLine("Eigtheen");
//}
//else if (age == 25)
//{
//    Console.WriteLine("five");
//}
//else
//{
//    Console.WriteLine("Unknown");
//}



//Relational operators: ==, !=, <, >, <=, >=, ||, &&

//Block statements have local scope
//if (true)
//{
//    var test = "test";
//}
//Console.WriteLine(test);

////Conditional operator
//var age = true ? 18 : 60; //ამ ჩანაწერს ვერ მივხვდი

var age = 62;
//Switch
switch (age)
{
    case 18:
        Console.WriteLine("Age is eighteen");
        break;
    case 60:
    case 61:
        goto case 62;
    case 62:
        {
            Console.WriteLine("Age is sixty or over");
            break;
        }
    default:
        {
            Console.WriteLine("Age unknown");
            break;
        }
}




//var age = 26;
//string resultAge = age switch
//{
//    18 => "Age eighteen",
//    20 => "age 20",
//    _ => "Unknown" //ქეჩალ ვალიიუ, თუ ზემოთ ჩამოთვლილი არცერთი არ შესრულდა შესრულდება ეს ნაწილი
//};
//Console.WriteLine(resultAge);


//Foreach, while, dowhile, for, continue, break, return ...
//Control Flow
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
