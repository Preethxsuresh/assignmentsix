namespace Simple_app
{
    /// <summary>
    /// Program class carries out the task of Greeting User.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method prompts user to enter name and greet the user.
        /// </summary>
        /// <param name="args"> Argument passed to the Greeting Application</param>
        public static void Main(string[] args)
        {
            Console.Write("Hello There !! \nEnter Your Name : ");
            var name = Console.ReadLine();
            int count = 0;
            while (string.IsNullOrWhiteSpace(name) && count < 3)
            {
                count++;
                Console.Write("Invlaid Input.Enter again : ");
                name = Console.ReadLine();
            }

            if (count == 3)
            {
                Console.WriteLine("You have entered invalid input multiple times.Exiting Program...");
                Environment.Exit(0);
            }
            Console.WriteLine($"\nHey {name}, Thankyou for using.");

        }
    }
}