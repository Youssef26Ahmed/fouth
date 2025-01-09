using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;

namespace AssignmentFive
{
    internal class Program
    {
        //Q1
        enum WeekDays
        {
         Mon = 1,
         tue = 2,
         wed = 3,
         thu = 4,
         fri = 5,
         sat = 6,
         sun = 7,
        }
        struct Person
        {
            public string Name;
            public int Age;
        }
        enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        enum Permissions
        {
            Read = 0,
            Write = 1,
            Delete = 2,
            Execute = 3
        }

        struct Point
        {
            public int X;
            public int Y;
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }


        static void Main(string[] args)
        {
            #region Q1
            //1.Create an enum called "WeekDays" with the days of the week(Monday to Sunday)
            //as its members.Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q2
            //2.Define a struct "Person" with properties "Name" and "Age". Create an array of
            //three "Person" objects and populate it with data.Then,
            // write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];

            //people[0].Name = "youssef";
            //people[0].Age = 22;

            //people[1].Name = "ahmed";
            //people[1].Age = 23;

            //people[2].Name = "rashed";
            //people[2].Age = 24;

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion
            #region Q3
            //3.Create an enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) as
            //its members.Write a C# program that takes a season name as input from the user and
            //displays the corresponding month range for that season. Note range 

            //for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string inputSeason = Console.ReadLine().ToLower();

            //if (!Enum.TryParse(inputSeason, true, out Seasons season))
            //{
            //    Console.WriteLine("Invalid season name.");
            //    return;
            //}

            //switch (season)
            //{
            //    case Seasons.Spring:
            //        Console.WriteLine("March to May");
            //        break;
            //    case Seasons.Summer:
            //        Console.WriteLine("June to August");
            //        break;
            //    case Seasons.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    case Seasons.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //}
            #endregion
            #region Q4
            //4.Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //⮚ Create Variable from previous Enum to Add and Remove Permission from variable,
            //   check if specific Permission is existed inside variable

            //Permissions userPermissions = Permissions.Read | Permissions.Write | Permissions.Execute;

            //userPermissions |= Permissions.Delete;
            //Console.WriteLine("Permissions after adding Delete: " + userPermissions);

            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine("Permissions after removing Write: " + userPermissions);

            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("User has Read permission");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Read permission");
            //}
            #endregion
            #region Q5
            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user
            //and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color (Red, Green, Blue):");
            //string inputColor = Console.ReadLine().ToLower();

            //if (!Enum.TryParse(inputColor, true, out Colors color))
            //{
            //    Console.WriteLine("Invalid color name.");
            //    return;
            //}

            //if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{color} is not a primary color.");
            //}

            #endregion
            #region Q6
            //6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a 
            //C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter the coordinates of the first point:");
            //int.TryParse(Console.ReadLine(), out int x1);
            //int.TryParse(Console.ReadLine(), out int y1);
            //Point point1 = new Point {X= x1,Y = y1};

            //Console.WriteLine("Enter the coordinates of the second point:");
            //int.TryParse(Console.ReadLine(), out int x2);
            //int.TryParse(Console.ReadLine(), out int y2);
            //Point point2 = new Point { X = x2, Y = y2 };

            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            //Console.WriteLine($"The distance between the two points is: {distance:F2}");

            #endregion
            #region Q7
            //7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes
            //details of 3 persons as input from the user and displays the name and age of the oldest person.
            
            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details of person {i + 1}:");
            //    Console.Write("Name: ");
            //    people[i].Name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    people[i].Age = int.Parse(Console.ReadLine());
            //}

            //Person oldestPerson = people[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (people[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = people[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}");

            #endregion




        }
    }
}
