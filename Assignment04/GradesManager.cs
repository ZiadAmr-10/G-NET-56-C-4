namespace Assignment04
{
    internal static class GradesManager
    {
        public static EnumGrades GetGrades(int score)
        {
            if (score >= 90)
                return EnumGrades.A;
            else if (score >= 80)
                return EnumGrades.B;
            else if (score >= 70)
                return EnumGrades.C;
            else if (score >= 60)
                return EnumGrades.D;
            else
                return EnumGrades.F;
        }
        public static double GetAverage(int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return (double)sum / scores.Length;
        }
        public static void GetMinMax(int[] scores, out int min, out int max)
        {
            min = scores[0];
            max = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }


        }
    }
}

