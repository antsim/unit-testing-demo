namespace UnitTestingDemo
{
    public class Mathematics
    {
        public int Multiply(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            
            return x * y;
        }
    }
}