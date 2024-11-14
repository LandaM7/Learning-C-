
//Console.WriteLine("1");
//double number1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine( "moqmedeba");
//char symbol = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("2");
//double number2 = Convert.ToDouble(Console.ReadLine());


//if (number2 == 0)
//{
//    Console.WriteLine("nulze gayofa ar SeiZleba");   
//}
//else if(symbol=='+')
//{
//    Console.WriteLine(number1+number2);
//}
//else if (symbol == '-')
//{
//    Console.WriteLine(number1 - number2);
//}
//else if (symbol == '*')
//{
//    Console.WriteLine(number1 * number2);
//}
//else if (symbol == '/')
//{
//    Console.WriteLine(number1 / number2);
//}
//else if (symbol == '^')
//{
//    Console.WriteLine(number1 * number1);
//}


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