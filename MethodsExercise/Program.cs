namespace MethodsExercise
{
    public class Program
    {
        
        public static int Add(int num1, int num2){
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2){
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2){
            return num1 * num2;
        }

        public static double Divide(int num1, int num2){
            return num1/num2;
        }
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

            Console.WriteLine($"My name is {name}. My favourite color is {favoriteColor}. Of all animals , {favoriteAnimal} is my favorite. I also enjoy music. {favoriteBand} is my favorite band.");

            Console.WriteLine($"Addition: {Add(2,3)}");
            Console.WriteLine($"Addition: {Subtract(20,3)}");
            Console.WriteLine($"Addition: {Multiply(2,3)}");
            Console.WriteLine($"Addition: {Divide(9,3)}");




        }

    }

}
