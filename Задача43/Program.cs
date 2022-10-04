/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/
void PrintPoint(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
    {
        if(b1 == b2)
        {
            Console.WriteLine("Прямые совпадают - точек пересечения бесконечно много");
        }
        else
        {
            Console.WriteLine("Прямые параллельны - точек пересечения нет");
        }    
    }
    else
    {
        double x0 = (b2 - b1)/(k1-k2);;
        double y0 = x0 * k1 + b1;
        Console.WriteLine($"({x0}, {y0}) - точка пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2}");
    }    
}

Console.Write("Введите k1: ");
double userK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double userB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double userK2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double userB2 = Convert.ToDouble(Console.ReadLine());

PrintPoint(userK1,userB1,userK2,userB2);
