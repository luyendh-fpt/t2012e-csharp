using System;

namespace T2012EHelloWorld.Entities
{
    public class Student
    {
        public string RollNumber { get; set; } //properties ~ property + getter + setter
        public string Name { get; set; }
        public string Email { get; set; }

        public Student()
        {
        }

        public Student(string rollNumber, string name, string email)
        {
            RollNumber = rollNumber;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"Rollnumber: {RollNumber}, Name: {Name}, Email: {Email}";
        }
    }
}