namespace Assignment04
{
    internal static class CircleCalculator
    {
        public static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;

            circumference = 2 * Math.PI * radius;
            
        }
       
    }
}
