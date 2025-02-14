namespace ConsoleApp3;

public class VeterinaryClinic
{
    public bool CheckHealth(Animal animal)
    {
        return new Random().Next(2) == 1;
    }
}