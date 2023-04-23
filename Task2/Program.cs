// Задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(b<a && c<a) {
    Console.WriteLine($"Наибольшее число: {a}");
}
else {
if(a<b && c<b) {
        Console.WriteLine($"Наибольшее число: {b}");
    }
    else {
        if(a<c && b<c) {
            Console.WriteLine($"Наибольшее число: {c}");
        }
    }
}