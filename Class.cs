using System;
using System.Collections.Generic;

namespace Ldl2
{
    public enum StudyField
    {
        MECHANICAL_ENGINEERING,
        SOFTWARE_ENGINEERING,
        FOOD_TECHNOLOGY,
        URBANISM_ARCHITECTURE,
        VETERINARY_MEDICINE
    }
    public class Student
    {
        public string firstName;
        public string lastName;
        public string email;
        public int enrollmentDate;
        public int dateOfBirth;
    }

    public class Faculty
    {
        public string Name { get; }
        public string Abbreviation { get; }
        public string Field { get; }
        public List<Student> Students { get; } = new List<Student>();

        public Faculty(string name, string abbreviation, string field)
        {
            Name = name;
            Abbreviation = abbreviation;
            Field = field;
        }

        public static List<Faculty> Faculties { get; } = new List<Faculty>();

        public void nf(string input)
        {
            string[] parts = input.Split('/');
            if (parts.Length != 4)
            {
                Console.WriteLine("Operation requires extra data!");
            }
            else
            {
                string fName = parts[1];
                string fAbbreviation = parts[2];
                string fField = parts[3];

                bool isValidField = false;
                foreach (string enumField in Enum.GetNames(typeof(StudyField)))
                {
                    if (fField.Equals(enumField, StringComparison.OrdinalIgnoreCase))
                    {
                        isValidField = true;
                        break;
                    }
                }
                if (!isValidField)
                {
                    Console.WriteLine("Invalid field. Please provide a valid field");
                    return;
                }

                Faculty newFaculty = new Faculty(fName, fAbbreviation, fField);
                Faculties.Add(newFaculty);
                Console.Write($"New faculty created: {fName}, Abbreviation: {fAbbreviation}, Field: {fField}");
            }
        }
    }
}
