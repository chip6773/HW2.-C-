// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// НАЧАЛО КОДА ЗАДАЧИ 10


int Line()
{
    Console.Write("введите трёхзначное число -> ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int number = Line();
if (number < 100 || number >=1000)
{
    Console.Write("вы ввели не трёхзначное число");
}
else
{
    Console.Write($"наше число {number}, ");
    int tsifra2 = number /10 %10;
    Console.Write($"вторая цифра у него -> {tsifra2}");
}



// КОНЕЦ КОДА ЗАДАЧИ 10

//--------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// НАЧАЛО КОДА ЗАДАЧИ 13

/*
int Line()
{
    int result = new Random().Next(1, 99999);
    return result;
}

int PoluchaemTretjuTsifru(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    num %= 10;
    return num;
}


int number = Line();
Console.Write("наше число -> " + number);
if (number < 100)
{
    Console.WriteLine(" и третьей цифры у него нет");
}
else
{
    int tsifra3 = PoluchaemTretjuTsifru(number);
    Console.WriteLine(" и третья цифра у него -> " + tsifra3);
}

*/

// КОНЕЦ КОДА ЗАДАЧИ 13

//-------------------------------------------------------------

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// НАЧАЛО КОДА ЗАДАЧИ 13

/*
Console.Clear();
Console.WriteLine("введите цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7 || num <= 0) Console.Write("читать разучился?)) до СЕМИ. это как ПЯТЬ пальцев на твоей руке, только плюс ещё ДВА.");

if (num ==6) Console.WriteLine("этот день в неделе выходной и называется он суббота");
if (num ==7) Console.WriteLine("этот день в неделе выходной и называется он выскресенье");
if (num < 6) Console.WriteLine("этот день в неделе НЕ выходной");

*/
// КОНЕЦ КОДА ЗАДАЧИ 15