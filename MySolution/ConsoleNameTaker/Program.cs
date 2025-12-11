using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class User
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    // public required int Id { get; set; }
    private string _password = "";
    public required string Password
    {
        get => _password;
        set
        {
            if (value.Length < 8)
            {
                throw new Exception("password lenght must be at least 8 char.");
            }
            else
            {
                _password = value;
            }

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var dataBase = new Dictionary<int, User>();
        int countedTime = 0;

        void submiter(string firstName, string lastName, string password)
        {
            countedTime++;
            dataBase.Add(countedTime, new User
            {
                FirstName = firstName,
                LastName = lastName,
                Password = password,
            });
        }

        Console.WriteLine("Hello Welcome");
        Console.WriteLine("=========================================");

        while (true)
        {
            Console.WriteLine("Write your FirstName:");
            string firstNameInput = Console.ReadLine();

            Console.WriteLine("Write your LastName:");
            string lastNameInput = Console.ReadLine();

            Console.WriteLine("Write your Password:");
            string passwordInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstNameInput))
            {
                Console.WriteLine("FirstName is required");
                continue;
            }

            if (string.IsNullOrWhiteSpace(lastNameInput))
            {
                Console.WriteLine("LastName is required");
                continue;
            }

            if (string.IsNullOrWhiteSpace(passwordInput))
            {
                Console.WriteLine("Password is required");
                continue;
            }

            try
            {
                submiter(firstNameInput, lastNameInput, passwordInput);
                Console.WriteLine("User added successfully!");
                Console.WriteLine("=========================LOOP=========================");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                continue;
            }
        }
    }

}