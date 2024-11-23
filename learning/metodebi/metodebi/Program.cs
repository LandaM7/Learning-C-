
//string name = "landa";

////ამოწმებს რითი იწყება
//bool a = name.StartsWith('a');
////ამოწმებს რითი მთავრდება
//bool b = name.EndsWith("a");
////ამოწმებს თუ არის ეს სიმბოლო
//bool c = name.Contains("n");
////ამოწმებს ტოლობას
//bool d = name.Equals("test");


//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);


////ფროფერთია 
////ასოების რაოდენობა
//string name = "landa";
//int a = name.Length;
//Console.WriteLine(a);


//string name = "landa";
//// დიდი ასეობი
//string a = name.ToUpper();
//Console.WriteLine(a);
////პატარა ასოები
//string b = name.ToLower();
//Console.WriteLine(b);


//// თავში და ბოლოში აცლის სფეისებს
//string name = "  la nd a  ";
//string a = name.Trim();
//Console.WriteLine(a);


//// ამოწმებს რომელ ინდექსზე დგას , თავიდან ითვლის 
//// სიმბოლო თუ საერთოდ არაა აბრუნებს -1 ს
//string name = "landa";
//int a = name.IndexOf("n");
//Console.WriteLine(a);


//// ამოწმებს რომელ ინდექსზე დგას , ბოლოდან ითვლის 
//string name = "landa";
//int a = name.LastIndexOf("d");
//Console.WriteLine(a);

////შესაბამის ინდექსზე ჩაამატებს
//string name = "landa";
//string a = name.Insert(0, "1");
//Console.WriteLine(a);

////შლის ინდექსიდან ყველაფერს
//string name = "landa";
//string a = name.Remove(2);
//Console.WriteLine(a);


////შლის ინდექსებს შორის
//string name = "landa";
//string a = name.Remove(0, 2);
//Console.WriteLine(a);

////შლის კონკრეტულ ინდექსამდე
//string name = "landa";
//string a = name.Substring(4);
//Console.WriteLine(a);


////ანაცვლებს
//string name = "landa";
//string a = name.Replace("n", "m");
//Console.WriteLine(a);

////სეპარატორი - გამყოფი
////დაყო და ერეი მივიღე 
//string name = "landa1, landa2, landa3";
//string[] b = name.Split(',');
//for(int i=0; i<b.Length; i++)
//{
//    Console.WriteLine(b[i]);
//}


////შლის 1 ინდექსიდან 2 ცალს
//int[] number = { 1, 2, 3 };
//Array.Clear(number, 1, 2);


////შეატრიალებს
//int[] number = { 1, 2, 3 };
//Array.Reverse(number);
//for (int i = 0; i < number.Length; i++)
//{
//    Console.WriteLine(number[i]);
//}


////პატარიდან დიდისკენ ალაგებს
//int[] number = { 1, 2, 3,-2, 10 };
//Array.Sort(number);
//for (int i = 0; i < number.Length; i++)
//{
//    Console.WriteLine(number[i]);
//}

////მინიმალური და მაქსიმალური min max
//int[] number = { 1, 2, 3, -2, 10 };
//int a = number.Max();
//Console.WriteLine(a);



//// წაშლის
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//number.Clear();


//// შეაბრუნებს
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//number.Reverse();



////ლისტში ჩაამატებს მეორე ლისტის ელემენტებს
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//List<int> number1 = new List<int>() { 5, 6, 7, 8 };
//number.AddRange(number1);



//// შლის კონკრეტულ ელემენტს
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//number.Remove(3);

//foreach (int newnumber in number)
//{
//    Console.WriteLine(newnumber);
//}


////წაშლის 1 ინდექსიდან 2 ელემენტს / კონკრეტული ინდექსიდან კონკრეტულ რაოდენობას
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//number.RemoveRange(1,2);

//foreach (int newnumber in number)
//{
//    Console.WriteLine(newnumber);
//}



////ჩაამატებს 1 ინდექსიდან  ჩანაწერს  4 ს 
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//number.Insert(1,4);

//foreach (int newnumber in number)
//{
//    Console.WriteLine(newnumber);
//}


// ჩააინსერტა მთლიანი ლისტი
//List<int> number = new List<int>() { 1, 2, 3, 4 };
//List<int> number1 = new List<int>() { 5,6,7 };
//number.InsertRange(2,number1);

//foreach (int newnumber in number)
//{
//    Console.WriteLine(newnumber);
//}


//მატრიცის დახატვა
//int height = 3;
//int widht = 4;

//for (int i = 0; i < height; i++)
//{
//    for (int j = 0; j < widht; j++)
//    {
//        Console.Write('*');
//    }

//    Console.WriteLine();
   
//}

