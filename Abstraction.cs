namespace ITexpertera
{
    internal interface IExample
    {
        public void add(int x, int y);
        public void substract(int x, int y);
        public void  multiply(int x, int y);
        public void division(int x,int y);
    }
    public class class1 : IExample
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

        public void substract(int x, int y)
        {
            int result = x-y;
            Console.WriteLine("The Division of "+x+" and " +y+ " is: "+result);
        }
    }
}