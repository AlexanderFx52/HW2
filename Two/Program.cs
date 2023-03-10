Console.Clear();
Console.WriteLine("ТАДАМ! А СЕЙЧАС Я ПОКАЖУ МАГИЮ! ЕСЛИ ЧИСЛО БУДЕТ НЕ МЕНЬШЕ ЧЕМ ТРЁХЗНАЧНОЕ, ТО Я ПОКАЖУ ТЕБЕ ТРЕТЬЮ ЦИФРУ!");
Console.WriteLine("Вжууух!");
int a = new Random().Next(10,10000000);
Console.WriteLine($"Твоё число = {a}");
while(a > 1000)
    a = a/10;
Console.WriteLine(a%10);
