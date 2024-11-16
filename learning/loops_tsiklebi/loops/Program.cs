// alt+shift და ისრებით შემიძლია ზემოთ ქვემოთ ავიდე 


//// ეს ჯერ გაზრდის და მერე ბეჭდავს რიცხვებს , ამიტომ დაწერს 1 დან 5 ის ჩათვლით
//int number = 0;
//while (number<5)
//{
//    number++;
//    Console.WriteLine(number);

//}

//// ეს ჯერ წერს და მერე ზრდის , ამიტომ დაბეჭდავს 0 დან 4 ისჩათვლით
//int number2 = 0;
//while (number2 < 5)
//{
//    Console.WriteLine(number2);
//    number++;
//}

////დაწერს რიცხვებს 0 დან კლიენტის შემოტანილი რიცხვის ჩათვლით
//int index = 0;
//int number = Convert.ToInt32(Console.ReadLine());
//while (index<=number)
//{
//    Console.WriteLine(index);
//    index++;
//}

//// ეს დაბეჭდავს უკუღმა
//int index = 0;
//int number = Convert.ToInt32(Console.ReadLine());
//while (number >= index)
//{
//    Console.WriteLine(number);
//    number--;
//}

////ეს არასდროს არ შემოწმდება
//int index = 10;
//while(index<5)
//{
//    Console.WriteLine(index);
//    index++;
//}

//// do while ერთხელ მაინც შესრულდება. ჯერ სრულდება და მერე ამოწმებს
//int index = 10;
//do
//{
//    Console.WriteLine(index);
//    index++;
//}
//while (index<5);


//პირველი არის ინიციალიზაცია,იქმნება ინტეჯერი 
//მეორე პირობა
//მესამე იტერაცია 

//for (int i=0; i<6; i++)

//{
//    Console.WriteLine(i);
//}


//int number = Convert.ToInt32(Console.ReadLine());
//for(int i=0; i>number; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i=1; i<=7; i++)
//{
//    Console.WriteLine( i );
//}


//int number = 10;
//for (int i=number;  i>=0; i--)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i<10; i++)
//{
//    Console.WriteLine("ricxvi" + i);
//}



//როცა რაღაც ცვლად ვადეკლარირებ, ეს ცვლადი არსებსბ მხოლოდ ამ ციკლში/იგივეა თრაიქეთჩში
//while (true)
//{
//    var testNumber = 100;
//}
//testNumber


//თუ გარედან მინდა მივწვდე ცვლადი უნდა დადეკლარირდეს ციკლის გარეთ

//var testNumber=10;
//while (true)
//{
//    testNumber = 20;
//    Console.WriteLine(testNumber);
//}   





// რატის
//Looping constructs

//var x = 1;
//while (x <= 5)
//{    
//    Console.WriteLine(x);
//    x++;
//}



//Loops may run forever / ციკლები შეიძლება უსასრულოდ მუშაობდეს
//while (true)
//{
//    Console.WriteLine("Never exiting");
//}

//var x = 1;
//do
//{
//    //Variables declared inside loops are scoped only inside that loop
//    //ცვლადები, რომლებიც ციკლის შიგნით გამოცხადებულია, მოქმედებს მხოლოდ იმ ციკლის ფარგლებში
//    var doubledValue = x *= 2;
//    Console.WriteLine(doubledValue);
//    x++;
//}
//while (x <= 5);


//for (var y = 1; y <= 5; y++)
//{
//    Console.WriteLine(y);
//}

//for (int y = 1, z = 10; y <= 5 && z >= 5; y++, z--)
//{
//    Console.WriteLine(y + " " + z);

//}

//Such syntax is also valid
//for (;;);
//for (; true; Console.WriteLine("Test")) ;



//"შეიყვანეთ 'quit' ციკლიდან გამოსასვლელად, წინააღმდეგ შემთხვევაში გააგრძელეთ გაშვება".
//while (true)
//{
//    Console.WriteLine("Type 'quit' to break out of the loop, otherwise continue running");
//    if (Console.ReadLine() == "quit")
//        break;
//}


//დაჯამების ოპერაციაა 
//var total = 0;
//while (total < 100)
//{
//    Console.WriteLine("Type a number to add to total");
//    var inputNumber = int.Parse(Console.ReadLine()!);
//    if (inputNumber > 50)
//    {
//        Console.WriteLine("Can't add more than 50 at a time");
//        continue;
//    }

//    total += inputNumber;
//    Console.WriteLine($"Total is {total}");
//}



