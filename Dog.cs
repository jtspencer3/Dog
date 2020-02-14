using System;

namespace Dog
{
    public enum Gender {Male, Female}
    public class Dog
    {
          public Dog(string dogName, string ownerName, int dogAge, Gender doggender)
        {
            name = dogName;
            owner = ownerName;
            age = dogAge;
            gender = doggender;
        }
        public string name;
        public string owner;
        public int age;
 
        public Gender gender;
        
        public void Bark(int barkamount)
        {
   
            for(int i = 0;i<barkamount;i++)
            {
                Console.WriteLine("woof!");
            }
         }

          public string GetTag()
        {
            string tag = "";
            if(gender == Gender.Male && age >1)
            {
                tag = "if lost, call " + owner + ". His name is " + name + " and he is " + age + "years old.";

            }else if(gender == Gender.Male && age <= 1)
            {
                tag = "If lost, call " + owner + ". His name is " + name + " and he is " + age + "year old.";
            
            }else if(gender == Gender.Female && age>1)
            {
                tag = "If lost, call " + owner + ". Her name is " + name + " and he is " + age + "years old.";

            }else if(gender == Gender.Female && age<=1)
            {
                tag = "If lost, call " + owner + ". Her name is " + name + " and she is" + age + "year old.";

            }
            return tag;
        }
    }
    class Program     
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("geoff","greg", 2, Gender.Male);
            dog.Bark(3);
            Console.WriteLine(dog.GetTag());
            
            Dog max = new Dog("max", "kyle", 3, Gender.Female);
            max.Bark(2);
            Console.WriteLine(max.GetTag());
        }
    }
}