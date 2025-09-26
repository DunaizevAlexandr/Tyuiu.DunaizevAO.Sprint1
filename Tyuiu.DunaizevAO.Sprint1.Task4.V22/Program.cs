using Tyuiu.DunaizevAO.Sprint1.Task4.V22.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

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