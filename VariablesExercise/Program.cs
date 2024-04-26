namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Jojo";

            int dogAge = 4;

            char lastInitial = 'M';

            bool badDog = true;

            double dogHeight = 20.4;

            decimal dogWeight = 24.7m;



            Console.WriteLine($"My dog is a rat terrier, & his name is {dogName} {lastInitial}.");
            Console.WriteLine($"{dogName} is approximately {dogHeight} inches tall and weighs {dogWeight} pounds.");
            Console.WriteLine($"It's {badDog}, {dogAge} year old {dogName} LIVES to be naughty!");
        }
    }
}
