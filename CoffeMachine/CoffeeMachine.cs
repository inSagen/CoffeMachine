namespace CoffeMachine;

public class CoffeeMachine
{
    private string[] coffeeMenu = { "Эспрессо", "Американо", "Капучино", "Латте", "Мокко" };

    public void ShowMenu()
    {
        Console.WriteLine("Меню кофе-машины:");
        for (int i = 0; i < coffeeMenu.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {coffeeMenu[i]}");
        }
    }

    public void CookCoffee(int choice)
    {
//предполагается что кофе-машина иммет графический/физический(кнопки) интерфейс, поэтому проверку ввода писать не стал.
        string selectedCoffee = coffeeMenu[choice - 1];
        Console.WriteLine($"Готовится {selectedCoffee}...");
        ShowSostav(selectedCoffee);
        Console.WriteLine($"{selectedCoffee} готов, приятного аппетита!");
    }

    private void ShowSostav(string coffeeType)
    {
        switch (coffeeType)
        {
            case "Эспрессо":
                Console.WriteLine("Состав: Вода - 50мл, Кофе - 10г.");
                break;
            case "Американо":
                Console.WriteLine("Состав: Вода - 100мл, Кофе - 10г.");
                break;
            case "Капучино":
                Console.WriteLine("Состав: Вода - 50мл, Кофе - 10г, Молоко - 50мл.");
                break;
            case "Латте":
                Console.WriteLine("Состав: Вода - 50мл, Кофе - 10г, Молоко - 100мл.");
                break;
            case "Мокко":
                Console.WriteLine("Состав: Вода - 50мл, Кофе - 10г, Шоколад - 20г.");
                break;
        }
    }
}