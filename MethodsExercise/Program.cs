namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your favorite color");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("Enter your favorite animal");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("Whats your favorite band");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"My name is {name}. My favourite color is {favoriteColor}. Of all animals , {favoriteAnimal} is my favorite. I also enjoy music. {favoriteBand} is my favorite band".);

        }
    }
}
