using System.Dynamic;

namespace life
{
    public class Human
    {
        //Properties
        public string Name  { get; set; } = "";
        public int Age{get; set;}
        public string Gender {get;set;} =  "";
        public string  Nationality{get; set;} = "";
        public string Qualification{get;set;} = "";

        //Methods
        public  void eat(string food)
        {
            Console.WriteLine(Name+" is eating "+food);
        }
        public  void Introduction(){
            Console.WriteLine("My Name is "+Name+" \n I am "+Age+" year old"+"\nMy qualifition is "+Qualification+"\n Im an"+Nationality);

        }
    }
}