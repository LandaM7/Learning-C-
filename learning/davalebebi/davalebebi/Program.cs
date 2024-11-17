////coordinates

//double X;
//double Y;
//while (true)
//{
//    Console.Write("Please enter the X coordinate: ");
//    var isXCoordinateSuccessful = double.TryParse(Console.ReadLine(), out double resultparsex);
//    if (isXCoordinateSuccessful)
//    {
//        X = resultparsex;
//    }
//    else
//    {
//        Console.WriteLine("The input data is incorrect. Please try again");
//        continue;
//    }

//    Console.Write("Please enter the Y coordinate: ");
//    var isYCoordinateSuccessful = double.TryParse(Console.ReadLine(), out double resultparsey);
//    if (isYCoordinateSuccessful)
//    {
//        Y = resultparsey;
//    }
//    else
//    {
//        Console.WriteLine("The input data is incorrect. Please try again.");
//        continue;
//    }

//    if (X < 0)
//    {
//        if (Y > 0)
//        {
//            Console.WriteLine("The enemy is to the North West!");
//        }
//        else if (Y == 0)
//        {
//            Console.WriteLine("The enemy is to the West!");
//        }
//        else
//        {
//            Console.WriteLine("The enemy is to the South West!");
//        }
//    }
//    else if (X == 0)
//    {
//        if (Y > 0)
//        {
//            Console.WriteLine("The enemy is to the North!");
//        }
//        else if (Y == 0)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("The enemy is here!");
//        }
//        else
//        {
//            Console.WriteLine("The enemy is to the South!");
//        }
//    }
//    else
//    {
//        if (Y > 0)
//        {
//            Console.WriteLine("The enemy is to the North East!");
//        }
//        else if (Y == 0)
//        {
//            Console.WriteLine("The enemy is to the East!");
//        }
//        else
//        {
//            Console.WriteLine("The enemy is to the South East!");
//        }
//    }
//    break;
//}



////calculator

//double firstnumber;
//double secondnumber;
//char matoperator;
//double result;
//string FinishorContinue;
//while (true)
//{
//    Console.WriteLine("Simple calculator");
//    Console.WriteLine("You can two numbers  + ; - ; * ; / ; ^ . ");

//    Console.Write("Please enter the first number: ");
//    var isfirstnumberSuccessful = double.TryParse(Console.ReadLine(), out double resultparsefirtnumber);
//    if (isfirstnumberSuccessful)
//    {
//        firstnumber = resultparsefirtnumber;
//    }
//    else
//    {
//        Console.WriteLine("The input data is incorrect. ");
//        break;
//    }
//    Console.Write("Please enter the mathematical operator : ");
//    var ismatoperatorSuccessful = char.TryParse(Console.ReadLine(), out char resultparsematoperator);
//    if (ismatoperatorSuccessful)
//    {
//        matoperator = resultparsematoperator;
//    }
//    else
//    {
//        Console.WriteLine("The input data is incorrect. ");
//        break;
//    }

//    Console.Write("Please enter the second number: ");
//    var issecondnumberSuccessful = double.TryParse(Console.ReadLine(), out double resultparsesecondnumber);
//    if (issecondnumberSuccessful)
//    {
//        secondnumber = resultparsesecondnumber;
//    }
//    else
//    {
//        Console.WriteLine("The input data is incorrect. ");
//        break;
//    }


//    switch (matoperator)
//    {
//        case '+':
//            result = firstnumber + secondnumber;
//            Console.WriteLine($"{firstnumber} + {secondnumber} = {result}");
//            break;
//        case '-':
//            result = firstnumber - secondnumber;
//            Console.WriteLine($"{firstnumber} - {secondnumber} = {result}");
//            break;
//        case '*':
//            result = firstnumber * secondnumber;
//            Console.WriteLine($"{firstnumber} * {secondnumber} = {result}");
//            break;
//        case '/':
//            if (secondnumber != 0)
//            {
//                result = firstnumber / secondnumber;
//                Console.WriteLine($"{firstnumber} / {secondnumber} = {result}");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Division by zero is not allowed");
//            }
//            break;
//        case '^':
//            result = Math.Pow(firstnumber, secondnumber);
//            Console.WriteLine($"{firstnumber} ^ {secondnumber} = {result}");
//            break;
//        default:
//            Console.WriteLine("Incorrect matoperator! \nPlease try again. ");
//            continue;
//    }
//    Console.WriteLine("Do you want to continue? Please enter YES or NO   ");
//    FinishorContinue = Console.ReadLine();
//    if (FinishorContinue == "YES" || FinishorContinue == "yes")
//    {
//        continue;
//    }
//    else if (FinishorContinue == "NO" || FinishorContinue == "no")
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("The entered command is incorrect! ");
//        break;
//    }


//}



