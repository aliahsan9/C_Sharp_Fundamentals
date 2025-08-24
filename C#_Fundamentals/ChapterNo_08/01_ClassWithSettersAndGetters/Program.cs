using System;

class Program
{
    public class Cat
    {
        //Field name
        private string name;
        //field color
        private string color;

        //Now define Setters ans Getters methods for Name, because fileds are private

        public string Name
        {
           get
           {
           return this.name;
           }
           set
           {
            this.name = value;
           }
        }

        //Now define Setters adn Getters for Color because filed of color is private
        
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                 this.color = value;
            }
        }
        //Default Constructor

        public Cat()
        {
            this.name = "UnNamed";
            this.color = "Gray";
        }
       // Constructor with parameters

       public Cat(string name, string color)
       {
        this.name = name;
        this.color = color;
       }

     //Method sayMeou
    public void SayMeou()
      {
    Console.WriteLine("Cat {0} said meou", name);
      }
    }

    static void Main(string[] args)
    {
        Cat firstCat = new Cat();
        firstCat.Name = "Tony";
        firstCat.SayMeou();

        Cat secondCat = new Cat("Pepy", "red");
        secondCat.SayMeou();
        Console.WriteLine("Cat {0} is {1}",secondCat.Name, secondCat.Color);
    }
}