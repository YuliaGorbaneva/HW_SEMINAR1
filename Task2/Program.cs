// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел


 Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int c = int.Parse(Console.ReadLine());

if ((a > b) && (a > c)){
    Console.Write($"max = {a}");
}
else{
    if (b > c){
        Console.Write($"max = {b}");
    }
    else{
        Console.Write($"max = {c}");
    }
}