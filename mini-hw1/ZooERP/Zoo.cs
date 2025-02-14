namespace ConsoleApp3;

public class Zoo
{
    private readonly List<Animal> _animals = new();
    private readonly List<Thing> _things = new();
    private readonly VeterinaryClinic _clinic;

    public Zoo(VeterinaryClinic clinic)
    {
        _clinic = clinic;
    }

    public void AddAnimal(Animal animal)
    {
        if (_clinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            Console.WriteLine($"Животное {animal.Name} добавлено в зоопарк.");
        }
        else
        {
            Console.WriteLine($"Животное {animal.Name} не прошло проверку здоровья.");
        }
    }

    public void AddThing(Thing thing)
    {
        _things.Add(thing);
        Console.WriteLine($"Предмет {thing.Name} добавлен в зоопарк.");
    }

    public void PrintFoodConsumption()
    {
        int totalFood = _animals.Sum(a => a.Food);
        Console.WriteLine($"Всего необходимо корма: {totalFood} кг в день.");
    }

    public void PrintInteractiveAnimals()
    {
        var interactiveAnimals = _animals.OfType<Herbo>().Where(h => h.Kindness > 5);
        Console.WriteLine("Животные, доступные для контактного зоопарка:");
        foreach (var animal in interactiveAnimals)
        {
            Console.WriteLine(animal.Name);
        }
    }

    public void PrintInventory()
    {
        Console.WriteLine("Инвентарные номера всех вещей и животных:");
        foreach (var item in _animals.Cast<IInventory>().Concat(_things))
        {
            Console.WriteLine($"{item.Number}: {item.GetType().Name}");
        }
    }
}