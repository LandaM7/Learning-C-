////რამდენიმე if ის დროს ელსი ეკუთვნის ბოლო if ს
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


////Switch
//var age = 18;
//switch (age)
//{
//    case 18:
//        Console.WriteLine("Age is eighteen");
//        break;
//    case 60:
//    case 61: 
//    case 62:
//        {
//            Console.WriteLine("Age is sixty or over");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("Age unknown");
//            break;
//        }
//}


////Switch
////!!ცუდიაა/ გადახტომის ოპერატორი. goto ს დროს გადადის შემდეგ ქეისზე 
//var age = 61;
//switch (age)
//{
//    case 18:
//        Console.WriteLine("Age is eighteen");
//        break;
//    case 60:
//    case 61:
//        Console.WriteLine("goto");
//        goto case 62;
//    case 62:
//        {
//            Console.WriteLine("Age is sixty or over");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("Age unknown");
//            break;
//        }
//}


//ლამბდაექსპრეშენი =>
//var age = 26;
//string resultAge = age switch
//{
//    18 => "Age eighteen",
//    20 => "age 20",
//    _ => "Unknown" //ქეჩალ ვალიიუ, თუ ზემოთ ჩამოთვლილი არცერთი არ შესრულდა შესრულდება ეს ნაწილი
//};
//Console.WriteLine(resultAge);



//////Error handling
//// დადებით ქეისზე ციკლი სრულდება - უარყოფიტზე გრძელდება
//bool isConversionSuccessful = false;
//while (!isConversionSuccessful)
//{
//    try
//    {
//        Console.WriteLine("Please input an integer");
//        var testInputString = Console.ReadLine();
//        int numberConverted = Int32.Parse(testInputString);
//        isConversionSuccessful = true;
//    }
//    catch (OverflowException ex)
//    {
//        Console.WriteLine($"Overflow Exception, please enter different value");
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine($"Bad Formatting, try again");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception occured, details: {ex}");
//    }
//    finally
//    {
//        Console.WriteLine("Finally block always executes");
//    }
//}

//Console.ForegroundColor = ConsoleColor.DarkGreen;
//Console.WriteLine("Program reached end!");



//Foreach, while, dowhile, for, continue, break, return ...
//Control Flow
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
