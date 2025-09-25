using Tyuiu.DunaizevAO.Sprint1.Task3.V1.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double r;
Console.WriteLine("Введите радиус цилиндра: ");
r = Convert.ToInt32(Console.ReadLine());

double h;
Console.WriteLine("Введите радиус цилиндра: ");
h = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Объем цилиндра " + ds.CylinderVolume(r,h));

Console.ReadLine();