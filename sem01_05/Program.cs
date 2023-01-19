/* Напишите программу, которая приниамет на вход 
трехзначное число и на выходе показывает последнюю 
цифру этого числа */ 

Console.WriteLine("Напишите трехзначное число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
int b = a % 10;
Console.WriteLine(b);
