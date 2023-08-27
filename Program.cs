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
            string? userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nHey {userName}, Welcome :)");

        }
    }
}