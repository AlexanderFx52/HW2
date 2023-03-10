Console.Clear();

int a = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {a}");
int a1 = a / 10;
int a2 = a1 % 10;

Console.WriteLine(a2);
