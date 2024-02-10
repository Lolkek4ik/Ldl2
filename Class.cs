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
        public string firstName {  get; }
        public string lastName {  get; } 
        public string email { get; }
        public int[] enrollmentDate { get; }
        public string FacAbb  { get; }
        /* public int dateOfBirth; */            //NAHUIA, DACA NU SE VA FOLOSI ?
        public Student(string firstName, string lastName, string email, int[] enrollmentDate, string FacAbb)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.enrollmentDate = enrollmentDate;
            this.FacAbb = FacAbb;
        }
    }

    public class Faculty
    {
        public string Name { get;}
        public string Abbreviation { get; }
        public string Field { get; }
        public List<Student> EStudents { get; } = new List<Student>();
        public List<Student> GStudents { get; } = new List<Student>();

        public Faculty(string name, string abbreviation, string field)
        {
            Name = name;
            Abbreviation = abbreviation;
            Field = field;
        }

        public static List<Faculty> Faculties { get; } = new List<Faculty>();






        //==============NF============NF============NF====================================================
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





        //=================NS==============NS===============NS====================================================
        public void ns(string input)
        {
            string[] parts = input.Split('/');
            if (parts.Length != 8)
            {
                Console.WriteLine("Operation requires extra data!");
                return;
            }

            string FFacAbb = parts[1];
            string FFirstName = parts[2];
            string FLastName = parts[3];
            string FEmail = parts[4];
            int[] FDate = new int[3];

            bool facAbbExists = Faculties.Any(f => f.Abbreviation.Equals(FFacAbb, StringComparison.OrdinalIgnoreCase));

            if (!facAbbExists)
            {
                Console.WriteLine($"Faculty with abbreviation {FFacAbb} does not exist.");
                return;
            }

            FDate[0] = Convert.ToInt32(parts[5]);
            FDate[1] = Convert.ToInt32(parts[6]);
            FDate[2] = Convert.ToInt32(parts[7]);

            Student newStudent = new Student(FFirstName, FLastName, FEmail, FDate, FFacAbb);
            EStudents.Add(newStudent);
            Console.WriteLine($"New Student created:{FFirstName} {FLastName} - {FEmail}, at the {FDate[0]}/{FDate[1]}/{FDate[2]}");
        }





        //=====================GS==============================GS================================GS==================================

        public void gs(string input)
        {
            string[] parts = input.Split ('/');

            Student studentToMove = EStudents.Find(student => student.email == parts[1]);

            if (studentToMove != null)
            {
                EStudents.Remove(studentToMove);
                GStudents.Add(studentToMove);
                Console.WriteLine($"Student {studentToMove.firstName} {studentToMove.lastName} was Graduated.");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }





        //====================DS===============================DS====================================DS===================================

        public void ds(string input)
        {
            string[] parts = input.Split('/');

            bool abbreviationExists = Faculties.Any(f => f.Abbreviation.Equals(parts[1], StringComparison.OrdinalIgnoreCase));

            if (abbreviationExists)
            {
                Faculty faculty = Faculties.Find(f => f.Abbreviation.Equals(parts[1], StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"Enrolled Students in {faculty.Name} ({faculty.Abbreviation}):");
                foreach (var student in EStudents)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} - {student.email} ({student.enrollmentDate[0]}/{student.enrollmentDate[1]}/{student.enrollmentDate[2]})");
                }
            }
            else
            {
                Console.WriteLine($"Faculty with abbreviation {parts[1]} not found.");
            }
        }








        //===================DG================================DG=====================================DG=====================================

        public void dg(string input)
        {
            string[] parts = input.Split('/');

            bool abbreviationExists = Faculties.Any(f => f.Abbreviation.Equals(parts[1], StringComparison.OrdinalIgnoreCase));

            if (abbreviationExists)
            {
                Faculty faculty = Faculties.Find(f => f.Abbreviation.Equals(parts[1], StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"Graduated Students in {faculty.Name} ({faculty.Abbreviation}):");
                foreach (var student in GStudents)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} - {student.email} ({student.enrollmentDate[0]}/{student.enrollmentDate[1]}/{student.enrollmentDate[2]})");
                }
            }
            else
            {
                Console.WriteLine($"Faculty with abbreviation {parts[1]} not found.");
            }
        }








        //===================BF=================================BF=====================================BF========================================

        public void bf(string input)
        {
            string[] parts = input.Split('/');
            
            if (parts.Length != 3)
            {
                Console.WriteLine("Operation requires extra data!");
                return;
            }
            string facultyAbbreviation = parts[1];
            string studentEmail = parts[2];
            Faculty faculty = Faculties.Find(f => f.Abbreviation.Equals(facultyAbbreviation, StringComparison.OrdinalIgnoreCase));

            if (faculty != null)
            {
                Student student = faculty.EStudents.Find(s => s.email.Equals(studentEmail, StringComparison.OrdinalIgnoreCase));
                if (student != null)
                {
                    Console.WriteLine($"Student {student.firstName} {student.lastName} belongs to {faculty.Name}.");
                }
                else
                {
                    Console.WriteLine($"Student with email {studentEmail} does not belong to {faculty.Name}.");
                }
            }
            else
            {
                Console.WriteLine($"Faculty with abbreviation {facultyAbbreviation} not found.");
            }
            
        }






        //===================SS=================================SS=====================================SS========================================
        public void ss(string input)
        {
            string[] parts = input.Split('/');

            if (parts.Length != 2)
            {
                Console.WriteLine("Operation requires extra data!");
                return;
            }

            string studentEmail = parts[1];

            foreach (var faculty in Faculties)
            {
                Student student = faculty.EStudents.Find(s => s.email.Equals(studentEmail, StringComparison.OrdinalIgnoreCase));
                if (student != null)
                {
                    Console.WriteLine($"Student {student.firstName} {student.lastName} belongs to {faculty.Name}.");
                    return;
                }
            }

            Console.WriteLine($"Student with email {studentEmail} does not belong to any faculty.");
        }








        //===================DF=================================DF=====================================DF========================================
        public void df()
        {
            Console.WriteLine("Faculties:");
            foreach (var faculty in Faculties)
            {
                Console.WriteLine($"Name: {faculty.Name}, Abbreviation: {faculty.Abbreviation}, Field: {faculty.Field}");
            }
        }





        //================
        public void df(string input)
        {
            string[] parts = input.Split('/');

            if (parts.Length != 1)
            {
                Console.WriteLine("Operation requires extra data!");
                return;
            }

            string fieldToDisplay = parts[1];

            Console.WriteLine($"Faculties of Field '{fieldToDisplay}':");
            foreach (var faculty in Faculties)
            {
                if (faculty.Field.Equals(fieldToDisplay, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Name: {faculty.Name}, Abbreviation: {faculty.Abbreviation}");
                }
            }
        }

        


    }
}
