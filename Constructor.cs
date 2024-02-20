using System.Security.Cryptography.X509Certificates;

namespace Math
{
    public class Cube
    {
        public int length{get; set;}
        public int breath{get;set;}
        public int height{get;set;}
        public int Volume{get;set;}
        // constructor for the cube object
        public Cube(int l, int b, int h)
        {
            length = l;
            breath = b;
            height = h;
            Volume = (length * breath * height);
        }
        public void showData()
        {
            Console.WriteLine("Volume of Cube is =  " +Volume );
        }
    }
}