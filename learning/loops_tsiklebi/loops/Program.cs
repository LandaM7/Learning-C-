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