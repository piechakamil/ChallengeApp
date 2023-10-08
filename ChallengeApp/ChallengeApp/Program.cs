using ChallengeApp;


List<Employee> employeeList = new List<Employee>();

Employee employee1 = new Employee("Jan", "Nowak", 40);
employeeList.Add(employee1);
employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(7);

Employee employee2 = new Employee("Janina", "Nowakowska", 41);
employeeList.Add(employee2);
employee2.AddScore(1);
employee2.AddScore(2);
employee2.AddScore(3);

Employee employee3 = new Employee("Marek", "Markowski", 42);
employeeList.Add(employee3);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);

Employee instanceWithHighestScore = employeeList.MaxBy(i => i.Score);

Console.WriteLine($"Najwyższy wynik {instanceWithHighestScore.Score} został uzyskany przez" +
    $" {instanceWithHighestScore.Name} {instanceWithHighestScore.Surname} (lat: {instanceWithHighestScore.Age})");



