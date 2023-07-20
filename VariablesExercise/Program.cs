namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Erik Hedman";

            int weight = 170;

            char favLetter = 'b';

            bool tall = true;

            double wallet = 100;

            decimal pennies = 0.67m;

            Console.WriteLine($"My name is {myName}. I weigh about {weight}, and my favorite letter is {favLetter}.  I have ${wallet} and {pennies} cents in my savings. It is {tall} that I am tall.");

        }
    }
}
