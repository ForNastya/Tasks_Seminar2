//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine ("Введите номер дня недели");
int x = int.Parse(Console.ReadLine());

if (x < 5)
{
    Console.WriteLine("Рабочий");
}
else
{
    Console.WriteLine("Выходной");
}