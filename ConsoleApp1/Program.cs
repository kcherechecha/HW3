
using System;

int n = 0;
bool check = false;
while (!check)
{
    try
    {
        Console.WriteLine("Введiть число");
        n = Int32.Parse(Console.ReadLine());
        check = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine("Ви ввели число " + n); 
