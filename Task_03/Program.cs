//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");
int quarterNumber = int.Parse(Console.ReadLine());
string range = " ";

if (quarterNumber == 1)
{
    Console.WriteLine("Диапазон возможных координат x > 0, y > 0");
}
else if (quarterNumber == 2)
{
    Console.WriteLine("Диапазон возможных координат x < 0, y > 0");
}
else if (quarterNumber == 3)
{
     Console.WriteLine("Диапазон возможных координат x < 0, y < 0");
}
else
{
     Console.WriteLine("Диапазон возможных координат x > 0, y < 0");
}