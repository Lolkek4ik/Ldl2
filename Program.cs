using System;

namespace Ldl2
{
    internal class Program
    {
        static Faculty faculty = new Faculty("", "", "");
        

        static void Main()
        {

            Faculty.LoadData("data.txt");
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
                if (input.StartsWith("nf/")) { faculty.nf(input); Console.ReadLine(); goto grl; }
                else if (input.StartsWith("ss/")) { faculty.ss(input); Console.ReadLine(); goto grl; }
                else if (input.StartsWith("df/")) { faculty.df(input); Console.ReadLine(); goto grl; }
                else if (input.StartsWith("df")) { faculty.df(); Console.ReadLine(); goto grl; }
                else if (input.StartsWith("b")) { goto start; }
                else if (input.StartsWith("q")) { goto end; }
                else { Console.WriteLine($"Operation {input} is not a valid operation"); Console.ReadLine(); goto grl; }
            }

        fct:;
            Console.Clear();
            Console.WriteLine("Faculty opperations");
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine(" ns/<faculty abbreviation>/<first name>/<last name>/<email>/<day>/<month>/<year> - create student"); //DA NAHUI ATUNCI NE TREBU DateOfBirth/EnrollmentDate IN CLASSA STUDENT, DACA IN MOMENTUL CREARII UNUI STUDENT NOU, NOI NU AVEM NEVOIE DE UNA DIN ACESTE DOUA, A ?
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
                if (input.StartsWith("ns/")) { faculty.ns(input); Console.ReadLine(); goto fct; }
                else if (input.StartsWith("gs/")) { faculty.gs(input); Console.ReadLine(); goto fct; }
                else if (input.StartsWith("ds/")) { faculty.ds(input); Console.ReadLine(); goto fct; }
                else if (input.StartsWith("dg/")) { faculty.dg(input); Console.ReadLine(); goto fct; }
                else if (input.StartsWith("bf/")) { faculty.bf(input); Console.ReadLine(); goto fct; }
                else if (input.StartsWith("b")) { goto start; }
                else if (input.StartsWith("q")) { goto end; }
                else { Console.WriteLine($"Operation {input} is not a valid operation"); Console.ReadLine(); goto fct; }
            }

            
        std:;
            Console.Clear();
            Console.WriteLine("NUI НИХУЯ SCRIS IN FAILUL CU LUCRARE. НЕ ЕБЁТ!!");
            Console.ReadLine(); goto start;

        end:;
            Console.WriteLine("Ending the Program...");
            Faculty.SaveData("data.txt");

        }
    }
}