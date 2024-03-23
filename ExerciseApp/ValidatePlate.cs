using System.Text.RegularExpressions;

namespace ExerciseApp;

public class ValidatePlate
{
    public void Execute()
    {
        Console.WriteLine("Digite a placa do veículo:");
        var input = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Você deve digitar algo!");
            input = Console.ReadLine();
        }

        var isValid = IsPlateValid(input);
        Console.WriteLine(isValid ? "Verdadeiro" : "Falso");
        Console.WriteLine("-----------------------------------");
    }

    private bool IsPlateValid(string plate)
    {
        var regex = new Regex(@"^[a-zA-Z]{3}\d{4}$");
        return regex.IsMatch(plate);
    }
}
