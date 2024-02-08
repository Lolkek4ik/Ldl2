using System;

namespace Ldl2
{
    internal class Program
    {
        static Faculty faculty = new Faculty("", "", "");
        static void Main()
        {
        start:;
            Console.Clear();
            Console.WriteLine("                    ``                          ");
            Console.WriteLine("Welcome to  UTM's student manager system !      ");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" g - General opperations\n");
            Console.WriteLine(" f - Faculty opperations\n");
            Console.WriteLine(" s - Student opperations\n\n");
            Console.WriteLine(" q - Quit Program\n\n");
            Console.Write("your input> ");

            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                goto start;
            }

            char act1 = userInput[0];

            switch (act1)
            {
                case 'g': goto grl;
                case 'f': goto fct;
                case 's': goto std;
                case 'q': goto end;
            }

        grl:;
            Console.Clear();
            Console.WriteLine("General opperations");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" nf/<faculty name>/<faculty abbreviation>/<field> - creat new faculty");
            Console.WriteLine(" ss/<student email> - search student and show faculty");
            Console.WriteLine(" df - display faculties");
            Console.WriteLine(" df/<field> - display all faculties of a field\n\n");
            Console.WriteLine(" b - Back\n");
            Console.WriteLine(" q - Quit Program\n\n");
            Console.Write("your input> ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("q")) { goto end; }
                else if (input.StartsWith("b")) { goto start; }
                else if (input.StartsWith("nf/")) { faculty.nf(input); Console.ReadLine(); goto grl; }
                else if (input.StartsWith("ss/")) {/*=======SEARCH STUDENT FUNCTION=======*/}
                else if (input.StartsWith("df")) {/*=======DISPLAY FACULTIES FUNCTION=======*/}
                else if (input.StartsWith("df/")) {/*=======DISPLAY FACULTIES OF A FIELD FUNCTION=======*/}
                else { Console.WriteLine($"Operation {input} is not a valid operation"); Console.ReadLine(); goto grl; }
            }

        fct:;
            Console.Clear();
            Console.WriteLine("Faculty opperations");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" ns/<faculty abbreviation>/<first name>/<last name>/<email>/<day>/<month>/<year> - create student");
            Console.WriteLine(" gs/<email> - (g)raduate (s)tudent");
            Console.WriteLine(" ds/<faculty abbreviation> - (d)isplay enrolled (s)tudents");
            Console.WriteLine(" dg/<faculty abbreviation> - (d)ispaly (g)raduated students");
            Console.WriteLine(" bf/<faculty abbreviation>/<email> - check if student (b)elong to (f)aculty\n\n");
            Console.WriteLine(" b - Back\n");
            Console.WriteLine(" q - Quit Program\n\n");
            Console.Write("your input> ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.StartsWith("q")) { goto end; }
                else if (input.StartsWith("b")) { goto start; }
                else if (input.StartsWith("ns/")) {/*=======CREATE STUDENT FUNCTION=======*/}
                else if (input.StartsWith("gs/")) {/*=======GRADUATE STUDENT FUNCTION=======*/}
                else if (input.StartsWith("ds")) {/*=======DISPLAY ENROLLED STUDENTS FUNCTION=======*/}
                else if (input.StartsWith("dg/")) {/*=======DISPLAY GRADUATED STUDENTS FUNCTION=======*/}
                else if (input.StartsWith("bf/")) {/*=======IF STUDENT BELONG TO FACULTY FUNCTION=======*/}
                else { Console.WriteLine($"Operation {input} is not a valid operation"); }
            }


        std:;
            Console.Clear();
            Console.WriteLine("NUI НИХУЯ SCRIS IN FAILUL CU LUCRARE. НЕ ЕБЁТ!!");
            goto start;

        end:;
            Console.WriteLine("Ending the Program...");
        }
    }
}
