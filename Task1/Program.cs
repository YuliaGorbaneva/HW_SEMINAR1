// Напишите программу, которая на вход принимает два числа ивыдает, какое число больше

Console.Write("Видите чило: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число ");
int b = int.Parse(Console.ReadLine());

if (a > b){
    System.Console.WriteLine($"max = {a}");
}
else {
    System.Console.WriteLine($"max = {b}"); 
}