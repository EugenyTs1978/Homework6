/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
int getCountFromUser(string userInformation)
{
    int result = 0;
    while(result < 1) 
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result < 1)
        {
            Console.WriteLine("Нужно ввести целое положительное число");
        }
        else
        {
            break;
        }
    }
    return result;
}
int getNumberFromUser(string userInformation)
{
    int result = 0;
    while(result == 0) 
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result == 0 && userLine != "0")
        {
            Console.WriteLine("Нужно ввести целое число");
        }
        else
        {
            break;
        }
    }
    return result;
}
int getCountOfPositiveNumbers(int CountNumbers)
{
    int count = 0;
    for(int i = 0; i < CountNumbers; i++)
    {
        int userNumber = getNumberFromUser("Введите целое число: ");
        if(userNumber > 0)
        {
            count += 1;
        }
    }
    return count;
}
int userCount = getCountFromUser("Введите количество вводимых чисел: ");
int countPositiveNumbers = getCountOfPositiveNumbers(userCount);
Console.WriteLine($"Количество чисел больших нуля: {countPositiveNumbers}");
