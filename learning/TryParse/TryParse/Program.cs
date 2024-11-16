//კომილერის ეროირს დროს პროგრამა არც ეშვება 
//რანთაიმ ერორი დროს რაღაც მიუვიდა გაშვების მერე ისეთი რასაც არ ელოდებოდა 

//Exception არის ყველა ექსეფშენის მშობელი კლასი, მაგ ფორმატექსეფშენი

//int number = Convert.ToInt32(Console.ReadLine());

// try ში ვაქცევ იმ კოდს რაც მინდა იყოს დაცული და შემდეგ ვწერ 
// catch ექსპრეშენში ვწერ რა ლოგიკა მინდა შესრულდეს იმ შემთხვევაში, როცა დაერორდება ოპერაცია
// finally შესრულდება ყოველთვის try შე მოთავსებული ბლოკი დაექსეფშენდა თუ არა 
// 



//int number;
//try
//{
//   number = Convert.ToInt32(Console.ReadLine());
//}
//catch (Exception exeption)
//{
//    number = 0;
//    Console.WriteLine(exeption);
//}
//finally
//{
//    Console.WriteLine("finally");
//}

//// throw როცა წერია ვიჭერ ერორს, მარა არ ვამუშავებ და ვისვრი ისევ
//// throw exeption ამდროს ვერ ვიგებ სად დაერორდა , რომელ ლაინზე 
//catch (Exception exeption)
//{
//number = 0;
//throw;
//Console.WriteLine(exeption);
//}


// შევა ტრაიში და თუ ერორი იქნება , ზევიდან ქვემოთ შევა იმ ქეჩბლოკში რომელი ერორიც გაისროლა . დანარჩენ ქეჩბლოკებს აღარ შეხედავს
//var number=0;
//try
//{
//    number = Convert.ToInt32(Console.ReadLine());
//}
//catch (DivideByZeroException ZeroException)
//{
//    Console.WriteLine("zero");
//}
//catch (FormatException formatException)
//{
//    Console.WriteLine("format error");
//}
//catch (Exception exeption)
//{
//    Console.WriteLine(exeption);
//}
//finally
//{
//    Console.WriteLine("finally");
//}


//რადგან ზემოდან ქვემოთ მიყვება ქეჩბლოკებს და Exception არის მშობელი ტიპის - მიერორებს. კომპაილერი ხვდება უკვე
//ცვლადი გარეთ უნდა დაადეკლარირო რომ try ის გარეშე მივწვდე 
//var number = 0;
//try
//{
//    number = Convert.ToInt32(Console.ReadLine());
//}
//catch (Exception exeption)
//{
//    Console.WriteLine(exeption);
//}
//catch (ArithmeticException aritmeticException)
//{
//    Console.WriteLine("aritmetik");
//}
//catch (DivideByZeroException ZeroException)
//{
//    Console.WriteLine("zero");
//}
//catch (FormatException formatException)
//{
//    Console.WriteLine("format error");
//}

//finally
//{
//    Console.WriteLine("finally");
//}    



//var number1 = Convert.ToInt32(Console.ReadLine());
//var number2 = int.Parse(Console.ReadLine());

//TryParse ბულიანს აბრუნებს თრუ ან ფოლსი
//var numberparseSuccess = int.TryParse(Console.ReadLine(), out int reultparse);
//if(numberparseSuccess)
//{
//    var number = numberparseSuccess;
//    Console.WriteLine(reultparse);
//}
//else
//{
//    Console.WriteLine("false"); 
//}


//ქეთჩი შემიძლია საერთოდ არ დავაკონკრეტო ან საერთოდ არ გავწერო ქეთჩი, გადავა პირდაპირ ფაინალიზე
//თუ ცარელი ქეთცი მექნება არ გამომიტანს ერორს 
//არ ვაკონკრეტებ რა ერორს ვჰენდლაბ

//var number = 0;
//try
//{
//    number = Convert.ToInt32(Console.ReadLine());
//}
//catch 
//{
//Console.WriteLine("ექსეფშენი" );
//}
//finally
//{
//    Console.WriteLine("finally");
//}

///ძალიან ცუდი რამაა !! ექსეფშენი მოდის და ყლაპავ, არც ლოგავ , დებაგერით ვერ მიაგნებს/ იმიტრომ შიგნით ლოგიკა არ მიწერია, ჩაყლაპავს და გააგრძელებს მუშაობას ჩვეულებრივ
//var number = 0;
//try
//{
//    number = Convert.ToInt32(Console.ReadLine());
//}
//catch
//{

//}
//finally
//{
//    Console.WriteLine("finally");
//}






////Error handling

bool isConversionSuccessful = false;
while (!isConversionSuccessful)
{
    try
    {
        Console.WriteLine("Please input an integer");
        var testInputString = Console.ReadLine();
        int numberConverted = Int32.Parse(testInputString);
        isConversionSuccessful = true;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Overflow Exception, please enter different value");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Bad Formatting, try again");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception occured, details: {ex}");
    }
    finally
    {
        Console.WriteLine("Finally block always executes");
    }
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Program reached end!");