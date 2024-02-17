namespace Complex
{
    public class Transform
    {
        public int real{get;set;}
        public int img{get;set;}

        public void SetComplexNumber(int r , int i)
        {
            real = r;
            img = i;
        }
        public void PrintComplexNumber()
        {
            Console.WriteLine("The value of the complex number is : "+real+" + "+img+"i");
        }
    }
}