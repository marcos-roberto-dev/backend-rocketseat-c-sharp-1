namespace ExerciseApp;

public class CountCharacters
{
    public void Execute()
    {
        Console.WriteLine("Digite seu texto:");
        var input = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Você deve digitar algo!");
            input = Console.ReadLine();
        }

        var count = input.Trim().Length;
        Console.WriteLine($"Seu texto tem {count} caracteres.");
        Console.WriteLine("-----------------------------------");
    }
}
