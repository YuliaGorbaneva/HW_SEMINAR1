// Напишите программу, которая на вход принимает чило и выдает, является ли число четным (делтся ли оно на два без остатка)

Console.Write("Введите число: ");

int a = int.Parse(Console.ReadLine());

if (a % 2 == 0){
    Console.Write($"true");
}

else
{
    Console.Write($"false");
}