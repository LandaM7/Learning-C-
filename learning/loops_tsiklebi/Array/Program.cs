//string[] name = new string[3];
//name[0] = "landa";
//name[1] = "landa2";
//name[2] = "landa3";

//Console.WriteLine(name[2]);



//string[] name = new string[5];
//name[0] = "landa";
//name[1] = "landa2";
//name[2] = "landa3";
//name[3] = "landa4";
//name[4] = "landa5";

//for (int i = 0; i < 5; i += 2)
//{
//    Console.WriteLine(name[i]);
//}



//string[] name = new string[3];

//for (int i = 0; i < name.Length; i++)
//{
//   name[i]=Console.ReadLine();
//}

//for (int i = 0; i < name.Length; i ++)
//{
//    Console.WriteLine(name[i]);
//}


//string[] name = new string[3] { "landa", "landa2", "landa3" };

//string[] name = new string[] { "landa", "landa2", "landa3" };

//string[] name = { "landa", "landa2", "landa3" };


//int[] number = new int[3] {2,3,4 };
//int sum = default;

//for (int i=0; i<number.Length; i++)
//{
//    sum += number[i];
//}

//Console.WriteLine( sum );



//sum პირდაპირ პირველ ელემენტს გავუტოლე და 0 დამატებით მიმატაება აღარა მჭირდება
// ასეთ დროს  i უკვე უნდა იყოს 1 რადგან 0 ინდექსიანი ელემენტი უკვე sum ის მნიშვნელობაა

//int[] number = new int[3] { 2, 3, 4 };
//int sum = number[0];

//for (int i = 1; i < number.Length; i++)
//{
//    sum += number[i];
//}
//Console.WriteLine(sum);


//int[] number = new int[4];
//int sum = default;
//int namravli;
//for (int i = 0; i < number.Length; i++)
//{
//    number[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 0; i < number.Length; i++)
//    Console.WriteLine(number[i]);

//for (int i = 1; i < number.Length; i += 2)
//    sum += number[i];
//Console.WriteLine(sum);

//namravli = number[0];
//for (int i = 1; i < number.Length; i++)
//    namravli *= number[i];
//Console.WriteLine(namravli);


////დაგვიწერს რომ არის სტრინგების მასივი, რამდენ ელემნტიანიც არის იმდენჯერ
//string[] name = { "test1", "test2"};
//for (int i=0; i<name.Length; i++)
//{
//    Console.WriteLine(name);
//}



//string[] name = { "test1", "test2" };
//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}


//რამდენიმე ფორის შემთხვევაში 
//\t სლეში


//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine($"Cycle N1, Iteracia N{i}");

//    for (int j = 1; j < 3; j++)
//    {
//        Console.WriteLine($"\tCycle N2, Iteracia N{j}");

//        for (int z = 1; z < 3; z++)
//        {
//            Console.WriteLine($"\t\tCycle N3, Iteracia N{z}");
//        }

//    }
//}



//int[] numbers = { -4, 0, 4, 5, -11 };
//int min = numbers[0];
//int max = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//    if (min > numbers[i])
//    {
//        min = numbers[i];
//        Console.WriteLine(min);
//    }

//  }



//მინიმუმი და მაქსიმუმი ერთად
//int[] numbers = { -4, 0, 4, 5, -11 };
//int min = numbers[0];
//int max = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i]<min)
//    {
//        min = numbers[i];        
//    }
//    else if (numbers[i]>max)
//    {
//        max = numbers[i];        
//    }

//}
//Console.WriteLine($"min= {min} and max = {max}");


//List<string> names = new List<string>();
//names.Add("test1");
//names.Add("test2");
//names.Add("test3");

//for(int i=0; i<names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}


//List<string> names = new List<string>();

//for (int i=0; i<2; i++)
//{
//    string name = Console.ReadLine();
//    names.Add(name);
//}
//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}



//ყველა მონაცემს აიღებს name მიმდევრობით
//List<string> names = new List<string>() { "test1", "test2" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}


//ცარელი სტრინგით შეავსებს
//List<string> names = new List<string>() { "test1", "test2" };
//for (int i = 0; i < names.Count; i++)
//{
//    names[i] = "";
//}



//List<string> names = new List<string>()
//{
//    "test1", "test2" ,"test3"
//};

//Random random = new Random();
//int i = random.Next(0, names.Count);
//Console.WriteLine( names[i]);


//using System.Security.Cryptography;

//List<int> numbers = new List<int>();
//Random random = new Random();

//for (int i = 0; i < 10; i++)
//{
//    numbers.Add(random.Next(0, 101));
//}

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


//List<int> oddnumber = new List<int>();
//List<int> evennumber = new List<int>();
//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        evennumber.Add(number);
//    }
//    else
//    {
//        oddnumber.Add(number);
//    }
//}


//foreach (int newnumber in oddnumber) 
//{
//    Console.WriteLine(newnumber);
//}
//foreach (int newnumber in evennumber) 
//{
//    Console.WriteLine(newnumber);
//}


