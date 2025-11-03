// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Creational;

var user = new UserBuilder()
    .SetFirstName("John")
    .SetLastName("Doe")
    .SetAge(25)
    .SetEmail("john@example.com")
    .SetActive(true)
    .Build();

        Console.WriteLine($"User: {user.FirstName} {user.LastName}, Age: {user.Age}, Email: {user.Email}, Active: {user.IsActive}");

    var user2 = new UserBuilder()
    .SetFirstName("Jane")
    .SetLastName("Smith")
    .SetAge(30)
    .SetEmail("jane@example.com")
    .SetActive(false);

   var actualuser = user2.Build();

        Console.WriteLine($"User: {actualuser.FirstName} {actualuser.LastName}, Age: {actualuser.Age}, Email: {actualuser.Email}, Active: {actualuser.IsActive}");

    var user3 = user2.SetFirstName("amir").Build();

        Console.WriteLine($"User: {user3.FirstName} {user3.LastName}, Age: {user3.Age}, Email: {user3.Email}, Active: {user3.IsActive}");

