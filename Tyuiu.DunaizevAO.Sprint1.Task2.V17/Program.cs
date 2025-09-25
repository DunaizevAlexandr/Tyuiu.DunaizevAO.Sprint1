using Tyuiu.DunaizevAO.Sprint1.Task2.V17.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x;

Console.WriteLine("Введите значение X: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Время в часах: " + ds.ConvertMinutesToHours(x));

Console.ReadLine();