namespace ConsoleApp3;

public class Animal : IAlive, IInventory
{
    public int Food { get; protected set; }
    public int Number { get; }
    public string Name { get; }
    
    protected Animal(int number, string name, int food)
    {
        Number = number;
        Name = name;
        Food = food;
    }
}