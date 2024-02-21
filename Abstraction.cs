namespace ITexpertera
{
    internal interface IExample
    {
        public void add(int x, int y);
        public void substract(int x, int y);
        public void  multiply(int x, int y);
        public void division(int x,int y);
    }
    public interface ITest
    {
        public void Square(int x);
    }
    public class Sqrroot
    {
        public int squarRoot(double x)
        {
            double result = Math.Sqrt((double)x);
            return (int)result;
        }
    }
    public class class1:Sqrroot,IExample,ITest
    {
        public void add(int x, int y)
        {
            int result = x+y;
            Console.WriteLine("The Sum of "+x+" and " +y+ " is: "+result);
        }

        public void division(int x, int y)
        {
            int result = x/y;
            Console.WriteLine("The Substraction of "+x+" and " +y+ " is: "+result);
        }

        public void multiply(int x, int y)
        {
           int result = x*y;
            Console.WriteLine("The Multiplication of "+x+" and " +y+ " is: "+result);
        }

        public void Square(int x)
        {
            int result = x*x;
            Console.WriteLine("The Square of " + x + " is: " + result);
        }

        public void substract(int x, int y)
        {
            int result = x-y;
            Console.WriteLine("The Division of "+x+" and " +y+ " is: "+result);
        }
    }
}