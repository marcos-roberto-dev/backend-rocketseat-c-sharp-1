namespace ExerciseApp;

public class ShowDate
{

// 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
//     - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
//     - Apenas a data no formato "01/03/2024".
//     - Apenas a hora no formato de 24 horas.
//     - A data com o mês por extenso.
    string? option = null;
    public void Execute()
    {
        while (string.IsNullOrWhiteSpace(option))
        {
            InputMessage();
            option = Console.ReadLine();
        }
        dispathOption(option);
    }

    private void InputMessage(){
        Console.WriteLine("Digite 1 para exibir a data no formato completo.");
        Console.WriteLine("Digite 2 para exibir apenas a data no formato '01/03/2024'.");
        Console.WriteLine("Digite 3 para exibir apenas a hora no formato de 24 horas.");
        Console.WriteLine("Digite 4 para exibir a data com o mês por extenso.");
    }

    private void dispathOption(string option)
    {
        switch (option)
        {
            case "1":
                Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;
            case "2":
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                break;
            case "4":
                Console.WriteLine(DateTime.Now.ToString("dd/MMMM/yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
