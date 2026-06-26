namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            DayOfWeek Day ;
            bool Flag=false;
            do
            {
                Console.WriteLine("Enter a day number (1-7) :");
                bool isParse = int.TryParse(Console.ReadLine(), out int num );
                if (isParse && num >= 1 && num <= 7)
                { Day = (DayOfWeek)num;
                    switch (Day) {
                        case DayOfWeek.Saturday:
                        case DayOfWeek.Friday:
                            Console.WriteLine("Weekend");
                            break;
                        default:
                            Console.WriteLine("WorkDay");
                       break;
                    }
                    Flag = true;
                }
                else
                    Console.WriteLine("Invalid Number Try again ");
             } while (!Flag);
            #endregion
        }
    }
}
