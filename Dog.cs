using System;

namespace Dog
{
    public class Dog
    {
        public enum Gender {Male, Female}
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
        }
    }

}
