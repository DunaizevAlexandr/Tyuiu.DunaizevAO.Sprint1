using Tyuiu.DunaizevAO.Sprint1.Task5.V3.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int k;
Console.WriteLine("Введите K: ");
k = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(k));

Console.ReadLine();