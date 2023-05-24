namespace h2task4
{

    internal class Program
    {
        struct Dog
        {
            public string? name;
            public string? mark;
            public int age;

            public override string ToString()
            {
                return $"The dog's name is {name}, its mark is {mark} and it is {age} years old";
            }
        }
        static void Main()
        {
            Dog dog;
            Console.WriteLine("Enter dogs name");
            dog.name = Console.ReadLine();
            Console.WriteLine("Enter dogs mark");
            dog.mark = Console.ReadLine();
            Console.WriteLine("Enter dogs age");
            dog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dog);
        }
    }
}