namespace ConsoleApp3;

public abstract class Herbo : Animal
{
    public int Kindness { get; }
    
    protected Herbo(int number, string name, int food, int kindness) : base(number, name, food)
    {
        Kindness = kindness;
    }
}