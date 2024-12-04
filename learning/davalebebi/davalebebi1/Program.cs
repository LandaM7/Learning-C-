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


//randomnamber

//Console.WriteLine("Please guess number, the number must be from 0 to 100 inclusive ");
//int usernumber = -1;

//while (true)
//{
//    Random random = new Random();
//    int randomnamber = random.Next(0, 10);
//    if (randomnamber % 2 == 0)
//    {
//        continue;
//    }
//    else
//    {

//        while (true)
//        {

//            var isUsernumberSuccessful = int.TryParse(Console.ReadLine(), out int resultusernumber);
//            if (isUsernumberSuccessful)
//            {
//                usernumber = resultusernumber;
//            }
//            else
//            {
//                Console.WriteLine("The entered data is incorrect, please try again. ");
//                continue;
//            }


//            if (randomnamber < usernumber)
//            {
//                Console.WriteLine("The number must be low, please say again");
//                continue;
//            }
//            else if (randomnamber > usernumber)
//            {
//                Console.WriteLine("The number must be high, please say again");
//                continue;
//            }

//            else
//            {
//                Console.ForegroundColor = ConsoleColor.DarkGreen;
//                Console.WriteLine($"You guessed right, number was {randomnamber}");
//                break;
//            }


//        }

//    }
//    break;
//}


//ifelse ების შემთხვევაში brake იანი if უნდა ეწეროს მაღლა
//თრაიპარსის დროს თუ ვერ გაპარსა 0 ს ანიჭებს მნიშვნელობას
//ცვლადს რაიმე ჰარდად მნიშვნელობის მინიჭება არაა კაი, მაგ როგორც მე მქონდა გაწერილი usernumber -1 
//int usernumber=default; შემიძლია დეფაულტ მნიშვნელობა გავუწერო
//ან შემეძლო ორჯერ მომეთხოვა ინფუთი
//int usernumber = default;
//usernumber = int.Parse(Console.ReadLine())
//var თან ვერ ვიყენებ დეფაულტ მნიშვნელობას

//trycatch დიდ რიცხვს ვერ დაიჭერს მაგალითად და დაიქრაშება პროგრამა და თრაიპარს დაჰენდლავს 

//დიდი ასოები გადაყავს პატარაში
//string ansver = Console.ReadLine().Trim().ToLower();
//if (ansver=="yes")
//{
//    Console.WriteLine( "yes");
//}

//else
//{
//    Console.WriteLine( "NO");
//}


//// ++ randomnamber



//Console.WriteLine("Please guess number, the number must be from 0 to 100 inclusive ");
//int usernumber = default;


//Random random = new Random();
//int randomnamber = random.Next(0, 101);

//while (randomnamber % 10 == 0)
//{
//    randomnamber = random.Next(0, 101);
//}

//while (usernumber != randomnamber)
//{
//    var isUsernumberSuccessful = int.TryParse(Console.ReadLine(), out int resultusernumber);
//    usernumber = resultusernumber;

//    if (isUsernumberSuccessful)
//    {
//        if (randomnamber < usernumber)
//        {
//            Console.WriteLine("The number must be low, please say again");            
//        }
//        else if (randomnamber > usernumber)
//        {
//            Console.WriteLine("The number must be high, please say again");        
//        }  

//        else
//        {
//            Console.ForegroundColor = ConsoleColor.DarkGreen;
//            Console.WriteLine($"You guessed right, number was {randomnamber}");  
//        }   
//    }
//    else
//    {
//        Console.WriteLine("The entered data is incorrect, please try again. ");        
//    }

//}


//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Configuration;


//var configurationManager = new ConfigurationManager();
//configurationManager.AddJsonFile("appsettings.json");

//String _ConnectionStrings = configurationManager.GetConnectionString("DefaultConnection");

//using (var connection = new SqlConnection(_ConnectionStrings))
//{
//    connection.Open();

//    using (var command = new SqlCommand("SELECT*FROM [TestNewDatabase].[dbo].[books]", connection))
//    {
//        using (var reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                var book = new Book();
//                book.Id = reader.GetInt32(0);
//                book.Name = reader.GetString(1);
//                book.Author = reader.GetString(2);
//                Console.WriteLine(book);
//            }
//        }
//    }
//}






//record Book
//{
//    public int Id;
//    public string Name;
//    public string Author;
//}


////Console.WriteLine($"Connection String: {_ConnectionStrings}");

