Console.WriteLine("1");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "moqmedeba");
char symbol = Convert.ToChar(Console.ReadLine());
Console.WriteLine("2");
double number2 = Convert.ToDouble(Console.ReadLine());


if (number2 == 0)
{
    Console.WriteLine("nulze gayofa ar SeiZleba");   
}
else if(symbol=='+')
{
    Console.WriteLine(number1+number2);
}
else if (symbol == '-')
{
    Console.WriteLine(number1 - number2);
}
else if (symbol == '*')
{
    Console.WriteLine(number1 * number2);
}
else if (symbol == '/')
{
    Console.WriteLine(number1 / number2);
}
else if (symbol == '^')
{
    Console.WriteLine(number1 * number1);
}
