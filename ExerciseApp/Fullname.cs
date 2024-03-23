namespace ExerciseApp;

public class Fullname
{
    private string? FirstName { get; set; }
    private string? LastName { get; set; }
    public void Execute()
    {
        while (string.IsNullOrWhiteSpace(FirstName))
        {
            Console.WriteLine("Digite seu primeiro nome: ");
            FirstName = Console.ReadLine();
        }

        while (string.IsNullOrWhiteSpace(LastName))
        {
            Console.WriteLine("Digite seu sobrenome: ");
            LastName = Console.ReadLine();
        }

        if(!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
        {
            FullnameMessage();
        }

    }

    private void FullnameMessage()
    {
        Console.WriteLine($"Seu nome é: {FirstName} {LastName}!");
        Console.WriteLine("-----------------------------");
    }
}
