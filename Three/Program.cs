Console.Clear();
Console.WriteLine("Ну что, давай проверим, работаешь ли ты сегодня или у тебя выходной, введи числом сегодняшний день недели: ");
int a = int.Parse(Console.ReadLine()!);
while (a<1 || a>7)
{
    Console.Write("Друг, нет такого дня недели...\nПопробуй еще разок: ");
    a = int.Parse(Console.ReadLine()!);
}
if(a > 0 && a < 6 )
    Console.WriteLine("Зря ты тут время проводишь, иди работай, сегодня не выходной!");
else
    Console.WriteLine("Опаньки! Это выходной!!! Иди на диван, братик, отдыхай");
