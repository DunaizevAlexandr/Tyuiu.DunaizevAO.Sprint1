using Tyuiu.DunaizevAO.Sprint1.Task3.V1.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double r;
Console.WriteLine("Введите радиус цилиндра: ");
r = Convert.ToDouble(Console.ReadLine());

double h;
Console.WriteLine("Введите радиус цилиндра: ");
h = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Объем цилиндра " + ds.CylinderVolume(r,h));

Console.ReadLine();