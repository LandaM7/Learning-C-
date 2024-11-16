//f5 გაშვება
//ctrl+k+e ან ctrl+k+d  ხაზების გასწორება

//int-რიცხვები
//double-ათწილადი
//string-"landa" ტექსტი
//char-'%' სიმბოლო
//bool- true&false


//int number = 20;
//Console.WriteLine( number);

//int Number = 21;// დიდ და პატარა ასოს აქვს განსხვავება
//Console.WriteLine( Number);

//string greeting = "hello world";
//Console.WriteLine( greeting);

//char symbol = '#';
//Console.WriteLine( symbol);

//double number2 = 2.2;
//Console.WriteLine( number2);

////number = number2; - int ში ვერ ჩაიწერება double
//number2 = number;
//Console.WriteLine( number2);

//bool isMyFirstProject = true;
//Console.WriteLine(isMyFirstProject);


//int firstnumber = 1;
//int seconnumber = 2;
//Console.WriteLine( firstnumber+seconnumber);

//int firstnumber = 1;
//int seconnumber = 2;
//int sum = firstnumber + seconnumber;
//Console.WriteLine(sum);

//string ansver = "4+5";
//Console.WriteLine( ansver);

//Console.WriteLine($"ansver = {4+5}");

//int firstnumber = 1;
//double seconnumber = 2.6;
////int sum = firstnumber + seconnumber;
//double sum = firstnumber + seconnumber;
//Console.WriteLine(sum);

//char symbol = '3';
//double sum = 2.2;
//string ansver = "3+3";
//int number = 4;
//Console.WriteLine(symbol+sum); //აქ ვერ მივხვიდ :( 
//Console.WriteLine(ansver+ symbol); // ერთიანი სტრინგი შექიმნა
//Console.WriteLine(ansver+number); // ერთიანი სტრინგი შექიმნა 
//Console.WriteLine(ansver-symbol); // გამოკლებას ვერ გააკეთებს, მხოლოდ შეკრების შემთხვევაში აკრავს და ერთიანი სტრინგი იქმნება

//bool a = 4 > 2;
//Console.WriteLine(a);
//Console.WriteLine( 4>2);

//int x = 2;
//x = x + 1; // მინიჭების ოპერატორი
//Console.WriteLine(x);

//int x = 2;
//x += 1; // ეს იგივეა რაც x = x + 1 , შემოკლებით ასე იწერება

//int x = 2;
//x++; //ზრდის ერთით
//Console.WriteLine(x);

//int x = 2;
//x--;
//Console.WriteLine(x);

//int y = 3;
//y *= 5; // y=y*5
//Console.WriteLine(y);

//int x = 3;
//Console.WriteLine( x++); // ჯერ დაწერა მნიშვნელობა და მერე გაზარდა 
//Console.WriteLine( x);// აქ უკვე გაზრდილი აჩვენა

//int x = 3;
//Console.WriteLine(++x); 
//Console.WriteLine(x);

//int a, b, c;
//a = 2;
//b = 3;
//c = 4;
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);

//int a = 2;
//int b = 4;
//Console.WriteLine($"a - {a}");
//Console.WriteLine($"b - {b}");

//int c;
//c = b;
//b = a;
//a = c;
//Console.WriteLine($"a - {a}");
//Console.WriteLine($"b - {b}");


//int a = 3;
//int b = 10;
//Console.WriteLine($"a - {a}");
//Console.WriteLine($"b - {b}");

//a = b - a;
//b = b - a;
//a = a + b;
//Console.WriteLine($"a - {a}");
//Console.WriteLine($"b - {b}");

//Console.WriteLine( "landa \nMindiashvili");// შემდეგ ხაზზე გადატანა

//Console.WriteLine("landa");
//Console.WriteLine("mindiashvili");
////ეს აბავას ერთმანეთს და ახალი ლაინით არ იწყებს
//Console.Write("landa");
//Console.Write("mindiashvili");

//% - ნაშთი გაყოფისის დროს
//int x = 10;
//int y = 10 % 3;
//Console.WriteLine(y);

//int a = 10;
//int b = 10%2;
//Console.WriteLine(b);

//var age = 18; // არ ეთითება რა ტიპია
//var number = 3.3;
//var name = "landa";
//Console.WriteLine(age);
//Console.WriteLine(number);
//Console.WriteLine(name);

//char x = '#';
//char y = '2';
//string sum = x + " " + y;
//Console.WriteLine(sum);

/*
ბევრი
ხაზის 
დაკომენტარება
*/



////Example for implicit conversion

//using System.Threading.Channels;

//byte number = 10;
//int number2 = number;


////Example of explicit conversion
////long numberLong = 2147483648;
////int number4 = (int)numberLong;
////int number3 = Convert.ToInt32(numberLong);

////Example of checked/unchecked context
//checked
//{
//    long numberLong = 2147483648;
//    int number4 = (int)numberLong;
//}

////Example of char ASCII Behavior
//char testCharacter = Convert.ToChar(61);
//testCharacter = (char)5;
//testCharacter = '\u0061';
//Console.WriteLine(testCharacter);


//var result = 2 + 4;
//result = 2 - 4;
//result--;
//--result;
//result = 2 * 4;
//result *= 2;
//result = 2 / 4;
//result = 2 % 4;
//result = (int)Math.Pow(2, 4);//ახარისხება
//Console.WriteLine(result++);
//Console.WriteLine(result);

////XOR Operator example
////010
////100
////110
//result = 2 ^ 4;
//Console.WriteLine(result);


////Math operations are not defined for all types, thus implicit type conversion occurs
//byte byte1 = 4;
//byte byte2 = 5;
//byte byteResult = (byte)(byte1 + byte2);

//byte res = 255;
//res++;

//byte maxByteVal = 255;
//var res3 = maxByteVal + 1;
//Console.WriteLine("Byte value is " + res);
//Console.WriteLine("Second Byte value is " + res3);

////Working with strings
//var testStringEscaped = "\"Example With Quotes\"";
//var testStringEscaped2 = @"D:\OL\repo\Week01\Week0101\bin";
//var stringInterpolation = $"Working with variables inside braces {byte1,20}";
//var stringInterpolation2 = $"{"Test Text",-50} - 1";
//var stringInterpolation3 = $"{"Test Text Three with longer input",-50} - 2";


//Console.WriteLine(stringInterpolation);
//Console.WriteLine(stringInterpolation2);
//Console.WriteLine(stringInterpolation3);


////Example of arithmetic operators
////https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/