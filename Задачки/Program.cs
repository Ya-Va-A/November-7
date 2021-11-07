// Задача 1: по двум заданным числам проверить является ли первое квадратом второго
// int a = 16;
//int b = 4;

//bool SQR (int a, int b)
//{
//if(a==b*b)
//{
//    return true;
//}
//return false;
//}

//Console.WriteLine($"{SQR (a,b)} a: {a} , b: {b} ");

// Задача 3 - по заданомму номеру лня недели вывести его название
//Зададим как метод

Console.WriteLine($"Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

void DayWeek(int number)
{
     if (number == 1) Console.WriteLine ("понедельник");
     if (number == 2) Console.WriteLine ("вторник");
     if (number == 3) Console.WriteLine ("среда");
     if (number == 4) Console.WriteLine ("четверг");
     if (number == 5) Console.WriteLine ("пятница");
     if (number == 6) Console.WriteLine ("суббота");
     if (number == 7) Console.WriteLine ("воскресенье");
}
  DayWeek(number);