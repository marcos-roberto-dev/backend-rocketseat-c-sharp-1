namespace ExerciseApp;

public class Welcome
{
    private string? FirstName { get; set; }

    public void Execute()
    {
        while (string.IsNullOrWhiteSpace(FirstName))
        {
            Console.WriteLine("Digite seu nome: ");
            FirstName = Console.ReadLine();
        }

        if(!string.IsNullOrEmpty(FirstName))
        {
            WelcomeMessage();
        }
    }

    private void WelcomeMessage()
    {
        Console.WriteLine($"Olá, {FirstName}! Seja muito bem-vindo!");
        Console.WriteLine("-----------------------------");
    }
}
