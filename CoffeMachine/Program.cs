using System;
using CoffeMachine;
public class Program
{
    static void Main(string[] args)
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();
        coffeeMachine.ShowMenu();
        
        Console.WriteLine("Выберите номер кофе, который хотите приготовить:");
        int choice = int.Parse(Console.ReadLine());
        coffeeMachine.CookCoffee(choice);
    }
}