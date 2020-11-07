    class Program
{
    static void Main(string[] args)
    {
        List<Animal> myAnimals = new List<Animal>();

        myAnimals.Add(new Monkey());
        myAnimals.Add(new Dog());

       foreach (Monkey m in myAnimals.OfType<Monkey>()){}
            Program.FeedAnimal(m);
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