using Tyuiu.DunaizevAO.Sprint1.Task7.V3.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                y - 1         *");
Console.WriteLine("*           3 + e              *");
Console.WriteLine("* z = ---------------------    *");
Console.WriteLine("*            2                 *");
Console.WriteLine("*       1 + x  |y - tg x|      *");

double x;
Console.WriteLine("Введите X: ");
x = Convert.ToDouble(Console.ReadLine());

double y;
Console.WriteLine("Введите Y: ");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();