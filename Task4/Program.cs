// Задача 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>0) {
    Console.Write("Все чётные числа от 1 до N: ");

    if (a==1) {
       Console.WriteLine("Вывод пустой"); 
    }
    else {
    for (int x = 2; x<=a; x+=2) 
    {
    Console.Write($"{x} "); 
}
    }
}
else Console.WriteLine("Введите число больше 0");