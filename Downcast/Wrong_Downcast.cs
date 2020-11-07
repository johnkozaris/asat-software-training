    class Program
{
    static void Main(string[] args)
    {
        List<Animal> myAnimals = new List<Animal>();

        myAnimals.Add(new Monkey());
        myAnimals.Add(new Dog());

        foreach (Animal a in myAnimals)
        {
            Program.FeedAnimal(a);
        }
    }

    void FeedAnimal(Monkey m) {
        Console.WriteLine("Fed a monkey.");
    }

    void FeedAnimal(Dog d)
    {
        Console.WriteLine("Fed a dog.");
    }

}