using _6_LINQ.SampleData;
//uncomment the method
//you are interested in to see how it behaves

//All.Run();
//Any.Run();
//Average.Run();
//Contains.Run();
//Count.Run();
//Distinct.Run();
//FirstLast.Run();
//Select.Run();
//Where.Run();

List<Person> people =
[
            new Person { FirstName = "John", LastName = "Doe", Age = 25, Weight = 70.5, Height = 175.0, Occupation = Occupation.Engineer },
            new Person { FirstName = "Jane", LastName = "Smith", Age = 30, Weight = 65.0, Height = 160.0, Occupation = Occupation.Doctor },
            new Person { FirstName = "Alice", LastName = "Johnson", Age = 22, Weight = 55.0, Height = 165.0, Occupation = Occupation.Teacher },
            new Person { FirstName = "Bob", LastName = "Brown", Age = 40, Weight = 80.0, Height = 180.0, Occupation = Occupation.Artist },
            new Person { FirstName = "Charlie", LastName = "Davis", Age = 35, Weight = 75.0, Height = 170.0, Occupation = Occupation.Lawyer },
            new Person { FirstName = "Diana", LastName = "Evans", Age = 28, Weight = 60.0, Height = 162.0, Occupation = Occupation.Chef },
            new Person { FirstName = "Ethan", LastName = "Garcia", Age = 32, Weight = 85.0, Height = 178.0, Occupation = Occupation.Scientist },
            new Person { FirstName = "Fiona", LastName = "Harris", Age = 27, Weight = 58.0, Height = 159.0, Occupation = Occupation.Athlete },
            new Person { FirstName = "George", LastName = "Clark", Age = 45, Weight = 90.0, Height = 182.0, Occupation = Occupation.Engineer },
            new Person { FirstName = "Hannah", LastName = "Lewis", Age = 29, Weight = 63.0, Height = 167.0, Occupation = Occupation.Doctor }
        ];
IEnumerable<Person> query = [.. people.OrderBy(p => p.LastName)];



Console.WriteLine("\nPress any key to close.");
Console.ReadKey();
