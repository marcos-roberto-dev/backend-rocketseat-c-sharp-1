using ExerciseApp;

class Program
{
    static void Main()
    {
        var welcome = new Welcome();
        var fullname = new Fullname();
        var calculateDouble = new CalculateDouble();
        var countCharacters = new CountCharacters();
        var validatePlate = new ValidatePlate();
        var showDate = new ShowDate();

        welcome.Execute();
        fullname.Execute();
        calculateDouble.Execute();
        countCharacters.Execute();
        validatePlate.Execute();
        showDate.Execute();
    }
}