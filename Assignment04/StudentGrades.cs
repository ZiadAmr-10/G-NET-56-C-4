namespace Assignment04 { 
    internal class StudentGrades
{
    int[,] grades;
    public StudentGrades(int[,] grades)
    {
        this.grades = grades;
    }
    public double GetStudentAverage(int StudentNum)
    {
        int sum = 0;
        for (int i = 0; i < grades.GetLength(1); i++) {

            sum += grades[StudentNum, i];
        }
        return (double)sum / grades.GetLength(1);
    }
    public double GetclassAverage()
    {
        double total = 0;
        for (int i = 0; i < grades.GetLength(0); i++)
        {
                total += GetStudentAverage(i);
        }
        return total / grades.GetLength(0);

    }


} 
}

