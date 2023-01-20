/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");

int A = x2 - x1;
int B = y2 - y1;

double length = Math.Sqrt(A * A + B * B);
Console.WriteLine($"Длинна отрезка {length}");

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

int getCoordFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
                break;
        }        
        else{
            Console.WriteLine("You've entered incorrect number");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int bx, int by){
    double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by, 2));
    return result;
}

int ax = getCoordFromUser("Enter x coordinate of the first point");
int ay = getCoordFromUser("Enter y coordinate of the first point");


int bx = getCoordFromUser("Enter x coordinate of the second point");
int by = getCoordFromUser("Enter y coordinate of the second point");

double distance = getDistance(ax, ay, bx, by);

Console.WriteLine($"Distance between({ax},{ay}) and ({bx},{by}) is {distance}");*/

