namespace ExerciseApp;

public class CalculateDouble
{
    private double FirstNumber { get; set; }
    private double SecondNumber { get; set; }
    public void Execute()
    {
        while (FirstNumber == 0)
        {
            Console.WriteLine("Digite o primeiro número: ");
            FirstNumber = Convert.ToDouble(Console.ReadLine());
        }

        while (SecondNumber == 0)
        {
            Console.WriteLine("Digite o segundo número: ");
            SecondNumber = Convert.ToDouble(Console.ReadLine());
        }

        if (FirstNumber != 0 && SecondNumber != 0)
        {
            SumMessage();
            SubtractMessage();
            MultiplyMessage();
            DivideMessage();
            MedianMessage();
             Console.WriteLine("-----------------------------------");
        }

    }

    private void SumMessage()
    {
        double sum = FirstNumber + SecondNumber;
        Console.WriteLine($"A soma dos números é: {sum}!");
    }

    private void SubtractMessage()
    {
        double difference = FirstNumber - SecondNumber;
        Console.WriteLine($"A subtração dos números é: {difference}!");
    }

    private void MultiplyMessage()
    {
        double product = FirstNumber * SecondNumber;
        Console.WriteLine($"A multiplicação dos números é: {product}!");
    }

    private void DivideMessage()
    {
        if (SecondNumber != 0)
        {
            double quotient = FirstNumber / SecondNumber;
            Console.WriteLine($"A divisão dos números é: {quotient}!");
        }
        else
            Console.WriteLine("Error: Division by zero is not allowed.");
    }

    private void MedianMessage()
    {
        double median = (FirstNumber + SecondNumber) / 2;
        Console.WriteLine($"A média dos dois numeros é: {median}!");
    }
}
