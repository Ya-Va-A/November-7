// Задача 1: по двум заданным числам проверить является ли первое квадратом второго
int a = 16;
int b = 4;

bool SQR (int a, int b)
{
if(a==b*b)
{
    return true;
}
return false;
}

Console.WriteLine($"{SQR (a,b)} a: {a} , b: {b} ");