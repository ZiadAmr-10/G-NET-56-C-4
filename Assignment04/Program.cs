namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //DayOfWeek Day ;
            //bool Flag=false;
            //do
            //{
            //    Console.WriteLine("Enter a day number (1-7) :");
            //    bool isParse = int.TryParse(Console.ReadLine(), out int num );
            //    if (isParse && num >= 1 && num <= 7)
            //    { Day = (DayOfWeek)num;
            //        switch (Day) {
            //            case DayOfWeek.Saturday:
            //            case DayOfWeek.Friday:
            //                Console.WriteLine("Weekend");
            //                break;
            //            default:
            //                Console.WriteLine("WorkDay");
            //           break;
            //        }
            //        Flag = true;
            //    }
            //    else
            //        Console.WriteLine("Invalid Number Try again ");
            // } while (!Flag);
            #endregion
            #region Question02
            //int[] arr;
            //bool isValid = false;
            //do {
            //    Console.WriteLine("Enter a SizeOfArray : ");
            //    bool isParse = int.TryParse(Console.ReadLine(), out int size);
            //    if (isParse&&size>0)
            //    {
            //        isValid = true;
            //        arr = new int[size];
            //        for (int i = 0; i < size; i++)
            //        {
            //            Console.WriteLine($"Enter Element {i + 1} : ");
            //            arr[i] = int.Parse(Console.ReadLine());
            //        }
            //        ArrayStatistics array = new ArrayStatistics(arr);
            //        Console.WriteLine($"Sum : {array.GetSum()}");
            //        Console.WriteLine($"Average :{array.GetAverage()}");
            //        Console.WriteLine($"Max Number : {array.GetMax()}");
            //        Console.WriteLine($"Min Number : {array.GetMin()}");
            //        Console.WriteLine("Reverse Array : ");
            //        array.PrintReverse();
            //    }
            //    else
            //        Console.WriteLine("/InValid Number Try Again !");
            //}
            //while (!isValid);
            #endregion
            #region Question03
            //int[,] StudentGrades = new int[3, 4];
            //for (int student = 0; student < StudentGrades.GetLength(0); student++)
            //{
            //    Console.WriteLine($"Student {student + 1}");

            //    for (int subject = 0; subject < StudentGrades.GetLength(1); subject++)
            //    {
            //        Console.Write($"Enter Subject {subject + 1} Grade: ");
            //        StudentGrades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}
            //StudentGrades Student=new StudentGrades(StudentGrades);
            //for (int i = 0; i < StudentGrades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student {i + 1} Average = {Student.GetStudentAverage(i)}");
            //}
            //Console.WriteLine($"Class Average = {Student.GetclassAverage()}");

            #endregion
         
        }
    }
}
