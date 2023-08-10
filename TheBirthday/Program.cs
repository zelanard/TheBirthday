namespace TheBirthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Prompt the user for birth year.
                Console.Write("which year was your child born: ");
                int Year = int.Parse(Console.ReadLine());

                //Prompt the user for birth month.
                Console.Write("which month was your child born: ");
                int Month = int.Parse(Console.ReadLine());

                //Prompt the user for birth day.
                Console.Write("which day was your child born: ");
                int Day = int.Parse(Console.ReadLine());

                //convert the input to a DateTime.
                DateTime birthday = new DateTime(Year, Month, Day, 0, 0, 0);

                //get the current time.
                DateTime now = DateTime.Now;

                //calculate the age.
                TimeSpan age = now - birthday;

                //print the childs age in days and years.
                Console.WriteLine();
                PrintCon($"Your child is: {DaysToYears(age.TotalDays)} years and {RemainingDays(age.TotalDays)} old.");
                Console.WriteLine();

                //prompt the user for further action
                PrintCon("If you want to clear the console before calculate another age, please press enter.");
                PrintCon("If you wnat to terminate the program, please press esc.");
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.Enter)
                {
                    //if the enter key was pressed, clear the console, the app will run keep running in the while loop.
                    Console.Clear();
                }
                else if (key == ConsoleKey.Escape)
                {
                    //if escape was pressed the while loop will terminate.
                    break;
                }
            }
        }

        /// <summary>
        /// Write to Console.
        /// </summary>
        /// <param name="obj"></param>
        static void PrintCon(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        /// <summary>
        /// Convert days to years.
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        static int DaysToYears(double days)
        {
            return (int)Math.Floor(days / 365.2425F);
        }

        /// <summary>
        /// Get the remaining days.
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        static int RemainingDays(double days)
        {
            return (int)Math.Floor(days % 365.2425F);
        }
    }
}