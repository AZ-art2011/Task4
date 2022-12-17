// Задача 4

Console.WriteLine("Вас приветствует программа сравнения трех чисел");

Console.WriteLine("Введите первое число");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numThree = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (numFirst > numSecond){
    max = numFirst;
}
else
{
    max = numSecond;
}

if (numThree > max){
    max = numThree;
}

Console.WriteLine($"Наиюольшее число {max}");