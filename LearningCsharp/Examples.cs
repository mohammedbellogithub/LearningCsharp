using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public class Examples
    {
        public static void MyArrayMethods()
        {
            //An Array of Strings
            string[] myStringArray1 = new string[10];
            myStringArray1[0] = "1";
            myStringArray1[1] = "2";
            myStringArray1[2] = "3";    
            myStringArray1[3] = "4";    
            myStringArray1[4] = "4";
            myStringArray1[5] = "5";
            myStringArray1[6] = "6";
            myStringArray1[7] = "7";

            foreach (string eachString1 in myStringArray1)
            {
                //printing each data in the array to terminal
                Console.WriteLine(eachString1);
            }
            Console.WriteLine("------------------------------------");

            //An Array of Strings
            string[] myStringArray2 = { 
                "Mohammed",
                "Babatunde" ,
                "oladipipo",
                "Alex" ,
                "Tolu",
                "walure" ,
                "smartware",
                "governor" ,
                "felix",
                "Deborah"
            };
            foreach (string eachString in myStringArray2)
            {
                //printing each data in the array to terminal
                Console.WriteLine(eachString);
            }
            Console.WriteLine("------------------------------------");

            // An Array of numbers(int)
            int[] myIntArray = {1,2,3,4,5,6,7,8,9,10,11,12,13};

        }

        // A void method
        //that uses that Math Random to generate a random number from 0 - 10
        //using the if statament,string method(ToString) and logical operations(&&) 
        //to print to scream if random number generated is equal to user input
        public static void GiveAway()
        {
            Console.WriteLine("Choose any number from 0 to 10 to win a prize");
            Console.Write("Enter: ");
            string? luckyValue = Console.ReadLine();
            Random keyValue = new Random();
            int key = keyValue.Next(10);
            string? keyX = key.ToString();
            if (luckyValue == "1" && keyX == "1") { Console.WriteLine("1000 USD"); }
            if (luckyValue == "2" && keyX == "2") { Console.WriteLine("2000 USD"); }
            if (luckyValue == "3" && keyX == "3") { Console.WriteLine("3000 USD"); }
            if (luckyValue == "4" && keyX == "4") { Console.WriteLine("4000 USD"); }
            else Console.WriteLine($"you choose: {luckyValue} and prize key is :{keyX}");
            Console.WriteLine("------------------------------------");
        }
    }
   
    //A Class with Collection of data
    internal class MypeopleList
    {
        //Creating and working with Collection with LINQ
        List<Person> PeopleList = new List<Person>(){
        new Person {
            Id = 1,
            Age = 23,
            FirstName = "Mohammed",
            LastName = "Bello",
            HasGraduated = true,
            School = " University of Lagos"
        },
        new Person
        {
            Id = 10,
            Age = 16,
            FirstName = "Halimat",
            LastName = "Bello",
            HasGraduated= false,
            School = "Bishimillah",
        },
        new Person
        {
            Id = 11,
            Age = 7,
            FirstName = "Abudulliah",
            LastName = "Bello",
            HasGraduated = false,
            School = "Bishimillah"
        },
        new Person
        {
            Id = 12,
            Age = 6,
            FirstName = "Aisha",
            LastName = "Bello",
            HasGraduated = false,
            School = "Saint saviors primary school"
        },
        new Person {
            Id = 2,
            Age = 31,
            FirstName = "Ibraheen",
            LastName = "Bello",
            HasGraduated = true,
            School = "Ladoke Akintola university of technology"
        },
        new Person {
            Id = 3,
            Age = 27,
            FirstName = "Fausiat",
            LastName = "Bello",
            HasGraduated = true,
            School = "University of Lagos"
        },
        new Person {
            Id = 4,
            Age = 25,
            FirstName = "Wale",
            LastName = "Oyedele",
            HasGraduated = true,
            School = "Lagos state university"
        },
        new Person {
            Id = 5,
            Age = 22,
            FirstName = "Afeez",
            LastName = "Moronkola",
            HasGraduated = false,
            School = "University of Lagos"
        },
        new Person { Id = 6,
            Age = 19,
            FirstName = "Mobarq",
            LastName = "Oyedele",
            HasGraduated = false,
            School = "University of Lagos"
        },
        new Person {
            Id = 7,
            Age = 12,
            FirstName = "Osadare",
            LastName = "Abayomi",
            HasGraduated = false,
            School = "University of Lagos"
        },
        new Person {
            Id = 8,
            Age = 9,
            FirstName = "Hasssan",
            LastName = "Oyedele",
            HasGraduated = false,
            School = "NIL"
        },
        new Person {
            Id = 9,
            Age = 17,
            FirstName = "Opeyemi",
            LastName = "Isaac",
            HasGraduated = true,
            School = "Ondo state university"
        }
};
        public void MypeopleListHandler()
        {
            var belloFamily = from person in PeopleList
                              where person.HasGraduated == true
                              && person.LastName == "Bello"
                              orderby person.Age descending
                              select person;

            var oyedeleFamily = from person in PeopleList
                                where person.LastName == "Oyedele"
                                && person.HasGraduated == true
                                select person;

            var underage = from person in PeopleList
                           where person.Age <= 20
                           orderby person.Age descending
                           select person;

            foreach (Person person in belloFamily)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName}");
               
            }
            Console.WriteLine("------------------------------------");
            foreach (var person in underage)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName} is {person.Age}");
                
            }

            Console.WriteLine("------------------------------------");
            foreach (Person person in oyedeleFamily)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName} graduated from {person.School} ");
            }
            Console.WriteLine("------------------------------------");
        }
    }
    //Creating a Class of Person
    class Person
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public int Age { get; set; }
        public string? School { get; set; }
        public bool HasGraduated { get; set; }


        //A default constructor for class person with no properties
        public Person()
        {

        }
        // An instance constructor with 2 parameters
        public Person(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

    }
    class User : Person
    {
        // An extra property added to class user
        protected int Level { get; set; }

        // A method created in class Person and it is accecible from classes derived from class User
        public int MyUserMethod()
        {
            return Id = Level++;
        }
        //A default constructor for class user
        public User() { }
        // An instance constructor with 6 parameters
        public User(string firstName, string lastName, int age, string school, bool hasGraduated , int level)
        {
            FirstName = firstName;
            LastName = lastName;    
            Age = age;
            School = school;
            HasGraduated = hasGraduated;    
            Level = level;
        }
    }
    class Employees : User
    {
        // A default constructor for class Employess that inherits from Class User
        //and set the property Id to value returned from the user method( MyUserMethod )
        public Employees()
        {
            Id = MyUserMethod();
        }
    }
}
