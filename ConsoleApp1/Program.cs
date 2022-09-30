//22 ИСП 2/2 Чистков Арсений

Console.WriteLine("Введите x:");
var x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
var y = double.Parse(Console.ReadLine());
var result = Math.Pow(1 - Math.Tan(x), 1 / Math.Tan(x)) + Math.Cos(x - y);
Console.WriteLine($"(1 - tgx)^ctgx+cos(x-y)={result}");
Console.ReadLine();
